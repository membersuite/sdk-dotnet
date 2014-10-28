using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace MemberSuite.SDK.Searching
{

    [KnownType(typeof (List<SearchOperation>))]
    [Serializable]
    [DataContract]
    public class SearchOperationGroup : SearchOperation
    {
        public SearchOperationGroup()
        {
            Criteria = new List<SearchOperation>();
        }

        /// <summary>
        /// Gets or sets the operations.
        /// </summary>
        /// <value>The operations.</value>
        [DataMember]
        [XmlArrayItem("Criterion")]
        public List<SearchOperation> Criteria { get; set; }

        /// <summary>
        /// Gets or sets the type.
        /// </summary>
        /// <value>The type.</value>
        [DataMember]
        public SearchOperationGroupType GroupType { get; set; }


        /// <summary>
        /// Accepts the specified visitor.
        /// </summary>
        /// <param name="visitor">The visitor.</param>
        /// <remarks>We usse this for operations that require navigation the search operation tree, but which
        /// are too sensitive to be exposed to the User Interface layer - most notably generation of SQL.</remarks>
        public override void Accept(ISearchObjectVisitor visitor)
        {
            visitor.Visit(this);
        }

        /// <summary>
        /// Removes the operation.
        /// </summary>
        /// <param name="operationID">The operation ID.</param>
        public void RemoveOperation(string operationID)
        {
            if (operationID == null) throw new ArgumentNullException("operationID");

            for (int i = Criteria.Count - 1; i >= 0; i--)
            {
                var op = Criteria[i];
                var opGroup = op as SearchOperationGroup;

                if (opGroup != null)
                {
                    opGroup.RemoveOperation(operationID);
                    continue;
                }

                if (op.ID == operationID)
                    Criteria.RemoveAt(i);

            }


        }

        public override int CalculateSearchHashCode()
        {
            Clean();
            int hashCode = GroupType.GetHashCode();
            if (this.Criteria != null)
                foreach (var c in this.Criteria)
                    hashCode += c.CalculateSearchHashCode();

            return hashCode;
        }

        public override void Clean()
        {
            if (Criteria == null)
                return;

            for (int i = Criteria.Count - 1; i >= 0; i--)
            {
                var op = Criteria[i];
                SearchOperationGroup sog = op as SearchOperationGroup;

                if (sog != null && (sog.Criteria == null || sog.Criteria.Count == 0)) // its useless
                {
                    Criteria.RemoveAt(i);
                    continue;
                }
                op.Parent = this;
                op.Clean();
            }

            if (Criteria.Count == 1 && Criteria[0] is SearchOperationGroup) // just collapse the group
            {
                SearchOperationGroup sog = (SearchOperationGroup) Criteria[0];
                GroupType = sog.GroupType;
                Criteria.Remove(sog);
                Criteria.AddRange(sog.Criteria); // add the criteria to this group
            }
        }

        /// <summary>
        /// Recursively finds the operation.
        /// </summary>
        /// <param name="so">The so.</param>
        /// <returns></returns>
        public SearchOperation FindOperation(SearchOperation so)
        {
            return FindOperation(so.ID);
        }

        public override bool HasCriteriaForField(string fieldName)
        {
            return base.HasCriteriaForField(fieldName) ||
                   Criteria.Any(searchOperation => searchOperation.HasCriteriaForField(fieldName));
        }

        public override bool HasCriteriaWithValue(object value)
        {
            return base.HasCriteriaWithValue(value) ||
                   Criteria.Any(searchOperation => searchOperation.HasCriteriaWithValue(value));
        }

        public override List<string> GetMergeCriteriaFields()
        {
            List<string> result = base.GetMergeCriteriaFields();

            foreach (
                var mergeCriteriaField in
                    Criteria.SelectMany(
                        searchOperation =>
                            searchOperation.GetMergeCriteriaFields()
                                .Where(
                                    mergeCriteriaField =>
                                        !result.Contains(mergeCriteriaField, StringComparer.InvariantCultureIgnoreCase)))
                )
            {
                result.Add(mergeCriteriaField);
            }

            return result;
        }

        public override void ReplaceCriteriaValue(object oldValue, object newValue)
        {
            base.ReplaceCriteriaValue(oldValue, newValue);

            foreach (var searchOperation in Criteria)
                searchOperation.ReplaceCriteriaValue(oldValue, newValue);
        }

        /// <summary>
        /// Recursively finds the operation.
        /// </summary>
        /// <param name="so">The so.</param>
        /// <returns></returns>
        public SearchOperation FindOperation(string operationID)
        {
            SearchOperation r = null;

            foreach (var c in Criteria)
            {
                if (c.ID == operationID)
                    return c;

                SearchOperationGroup sog = c as SearchOperationGroup;

                if (sog != null)
                {
                    r = sog.FindOperation(operationID);
                    if (r != null)
                        return r;
                }

            }

            return r;
        }

        /// <summary>
        /// Recursively gets the parameterized operations.
        /// </summary>
        /// <returns></returns>
        public List<SearchOperation> GetParameterizedOperations()
        {
            List<SearchOperation> ops = new List<SearchOperation>();
            _getParameterizedOperatoinHelper(ops, this);

            return ops;
        }

        private void _getParameterizedOperatoinHelper(List<SearchOperation> ops,
            SearchOperationGroup searchOperationGroup)
        {
            foreach (SearchOperation so in searchOperationGroup.Criteria)
            {
                // we'll do our recursion up front
                SearchOperationGroup sog = so as SearchOperationGroup;
                if (sog != null)
                    _getParameterizedOperatoinHelper(ops, sog);

                else if (so.EnableParameterization)
                    ops.Add(so);
            }
        }

        public override void PostSerializationCleanse()
        {
            base.PostSerializationCleanse();

            if (Criteria != null)
                foreach (var c in Criteria)
                    c.PostSerializationCleanse();
        }


        /// <summary>
        /// Adds the specified operation to this group. If the group's type (and/or) is different than the groupType
        /// parameter, a new group is spawned and added to this one,
        /// </summary>
        /// <param name="groupType"></param>
        /// <param name="operationToAdd"></param>
        public void InjectCriteriaAndReformatGroupIfNecessary(SearchOperationGroupType groupType,
            SearchOperation operationToAdd)
        {
            if (this.GroupType == groupType)
            {
                this.Criteria.Add(operationToAdd); // easy
                return;
            }

            // ok, so the group type is different
            // we create a new group
            SearchOperationGroup sog = new SearchOperationGroup();
            sog.GroupType = this.GroupType;

            // copy over the current criteria
            sog.Criteria.AddRange(this.Criteria);

            // clear the criteria from this group
            this.Criteria.Clear();

            // set the new type
            this.GroupType = GroupType;

            // add the old criteria, grouped
            Criteria.Add(sog);

            // and add the new operatoin
            Criteria.Add(operationToAdd);
        }
    }
}
