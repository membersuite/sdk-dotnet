using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using MemberSuite.SDK.Manifests.Command;
using MemberSuite.SDK.Manifests.Command.Views;
using MemberSuite.SDK.Searching;
using MemberSuite.SDK.Searching.Operations;

namespace MemberSuite.SDK.Utilities
{
    /// <summary>
    /// Methods designed to optimize the 360 screen. They live here because the JES needs them to warm up.
    /// </summary>
    public static class UIOptimizer
    {
        public static List<string> removeAllFieldsNotRelevantForSection(Search mainSearch, Data360ViewMetadata meta)
        {
            if (mainSearch == null) throw new ArgumentNullException("mainSearch");
            if (meta == null) throw new ArgumentNullException("meta");

            List<string> removedFields = new List<string>();

            ViewMetadata.ControlSection section;
            if (meta.SelectedSection == null)
                section = meta.Sections[0];
            else
            {
                section = meta.Sections.Find(x => x.Name == meta.SelectedSection || x.Label == meta.SelectedSection);
                if (section == null)
                    section = meta.Sections[0];
            }

            // ok, now, let's find all the fields needed by expressions
            List<string> fieldsNeededByExpressions = new List<string>();

            // ok, now let's go through each field in the search
            foreach (var s in meta.Sections)
                if (s.Commands != null)
                    foreach (var c in s.Commands)
                        if (!String.IsNullOrWhiteSpace(c.AppliesIf))
                        {
                            MatchCollection mc = Regex.Matches(c.AppliesIf, RegularExpressions.SearchResultTokenRegex, RegexOptions.Compiled);

                            foreach (Match m in mc)
                                fieldsNeededByExpressions.Add(m.Groups[1].Value);

                        }

            // now, the business card view
            if (section.Text != null)
            {
                MatchCollection mc = Regex.Matches(section.Text, RegularExpressions.SectionTextFieldTokenRegex, RegexOptions.Compiled);
                foreach (Match m in mc)
                    fieldsNeededByExpressions.Add(m.Groups[1].Value);

            }

            // ok, additional fields
            if (meta.AdditionalFields != null)
                fieldsNeededByExpressions.AddRange(meta.AdditionalFields);


            // ok, let's remove all unneccessary fields from search
            for (int i = mainSearch.OutputColumns.Count - 1; i >= 0; i--)
            {
                var of = mainSearch.OutputColumns[i];
                if (!section.ContainsField(of.Name) &&  // contains the field
                    !section.ContainsField(of.Name + ".Name") &&    // or a reference to the name
                    !(of.Name.EndsWith(".ID") && section.ContainsField(of.Name.Replace(".ID", ".Name"))) && // otherwise, URLs won't work
                    !fieldsNeededByExpressions.Contains(of.Name) &&
                    of.Name != "OptOuts" // This is a special case to handle the OptOut lookup values and not remove them from the 
                    )
                {
                    mainSearch.OutputColumns.RemoveAt(i); // get rid of it
                    removedFields.Add(of.Name);
                }
            }

            return removedFields;
        }

        public static void massagePrimarySearch(Search s)
        {
            // now - any where we look for <something>.Name, we need to 
            // pull <something>.ID, so we can reference it!

            var aggregateNames = s.OutputColumns.FindAll(f1 => f1.Name.EndsWith(".Name"));
            foreach (var name in aggregateNames)
            {
                string referenceField = name.Name.Substring(0, name.Name.Length - ".Name".Length);
                referenceField += ".ID";

                if (!s.OutputColumns.Exists(c1 => c1.Name == referenceField))
                    s.OutputColumns.Add(new SearchOutputColumn { Name = referenceField });
            }
        }

        public static Search Generate360Search(string getObjectName, string context)
        {
            Search s = new Search();
            s.Type = getObjectName;

            s.Criteria.Add(new Equals { FieldName = "ID", ValuesToOperateOn = new List<object> { context } });
            return s;
        }

        public static void GenerateSearchFrom360Metadata(Search s, Data360ViewMetadata meta)
        {
            GenerateSearchFrom360Metadata(s, meta, null);
        }

        public static void GenerateSearchFrom360Metadata(Search s, Data360ViewMetadata meta, Hashtable htHasSeen)
        {

            // now, the output fields
            // they are going to be all of the fields that are referenced on this 360 screen

            if (htHasSeen == null)
                htHasSeen = new Hashtable();


            if (meta != null && meta.Sections != null)
            {


                foreach (var f in meta.Sections)
                {

                    foreach (var c in f.LeftControls.Concat(f.RightControls))
                    {
                        if (c.DataSourceExpression == null)
                            continue;

                        if (htHasSeen.ContainsKey(c.DataSourceExpression))
                            continue;

                        if (c.DataSource == null // important, we don't care if the source is something else
                            )
                        {
                            s.OutputColumns.Add(new SearchOutputColumn() { Name = c.DataSourceExpression });
                            htHasSeen[c.DataSourceExpression] = true;
                        }
                    }

                    // now, is there any text?
                    if (f.Text != null)
                    {
                        // if so, let's expand tokens
                        MatchCollection mc = Regex.Matches(f.Text, RegularExpressions.SectionTextFieldTokenRegex, RegexOptions.Compiled);
                        foreach (Match m in mc)
                        {
                            var fieldToken = m.Groups[1].Value.Trim();
                            if (!htHasSeen.ContainsKey(fieldToken))
                            {
                                s.OutputColumns.Add(new SearchOutputColumn() { Name = fieldToken });
                                htHasSeen[fieldToken] = true;
                            }
                        }
                    }
                }
            }

            // let's add any additional fields
            if (meta != null && meta.AdditionalFields != null)
                foreach (var c in meta.AdditionalFields)
                {
                    if (htHasSeen.ContainsKey(c)) continue;
                    s.OutputColumns.Add(new SearchOutputColumn() { Name = c });
                    htHasSeen[c] = true;
                }


        }
    }
}
