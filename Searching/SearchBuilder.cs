using System;
using System.Collections.Generic;

namespace MemberSuite.SDK.Searching
{
    /// <summary>
    /// Used to construct a search object
    /// </summary>
    [Serializable]
    public class SearchBuilder
    {
        public SearchBuilder(Search s)
        {
            _search = s;
            _currentSearchOperationGroup = _search;
            //MS-1749
            //_search.GroupType = SearchOperationGroupType.And;
            _parenthesesStack = new Stack<SearchOperationGroup>();
        }

        public SearchBuilder() : this ( new Search() )
        {
           

        }

        protected Search _search;
        protected SearchOperationGroup _currentSearchOperationGroup;
        protected Stack<SearchOperationGroup> _parenthesesStack;

        public SearchOperationGroup CurrentSearchOperationGroup { get { return _currentSearchOperationGroup; } }

            /// <summary>
        /// Gets a value indicating whether this instance can close parenthesis.
        /// </summary>
        /// <value>
        /// 	<c>true</c> if this instance can close parenthesis; otherwise, <c>false</c>.
        /// </value>
        public bool CanCloseParenthesis { get { return _parenthesesStack.Count > 0; } }

            /// <summary>
        /// Gets the search.
        /// </summary>
        /// <value>The search.</value>
        public Search Search { get {  return _search; } }

        public void OpenParenthesis()
        {
            SearchOperationGroup sog = new SearchOperationGroup();
            sog.Parent = _currentSearchOperationGroup;
            _currentSearchOperationGroup.Criteria.Add(sog);

            // push the current group on the stack - this is where we are coming back to
            _parenthesesStack.Push(_currentSearchOperationGroup);

            _currentSearchOperationGroup = sog;
        }

        public void CloseParenthesis()
        {
            // pop the group off of the stack
            _currentSearchOperationGroup = _parenthesesStack.Pop();

            
        }

        public void AddOperation(SearchOperation so, SearchOperationGroupType groupType)
        {
            if (so == null) throw new ArgumentNullException("so");

            if (_currentSearchOperationGroup.GroupType == groupType)  // no problem
            {
                _currentSearchOperationGroup.Criteria.Add(so);
                return;
            }

            // ok - it's different, so...
            if (_currentSearchOperationGroup.Criteria.Count <= 1)  // just change the type!
            {
                _currentSearchOperationGroup.GroupType = groupType;
                _currentSearchOperationGroup.Criteria.Add(so);
                return;
            }

            // we must split off another group
            SearchOperationGroup sog = new SearchOperationGroup();
            sog.GroupType = groupType;

            if (_currentSearchOperationGroup.Parent != null)  // we have to replace the parent
            {
                int index = _currentSearchOperationGroup.Parent.Criteria.IndexOf(_currentSearchOperationGroup);
                _currentSearchOperationGroup.Parent.Criteria.RemoveAt(index);
                _currentSearchOperationGroup.Parent.Criteria.Insert(index, sog);
                sog.Criteria.Add(_currentSearchOperationGroup);
                sog.Criteria.Add(so);
                _currentSearchOperationGroup = sog; // reset the current group

            }
            else
            {
                // we're at the top
                SearchOperationGroup soBase = new SearchOperationGroup();
                soBase.GroupType = _currentSearchOperationGroup.GroupType;
                soBase.Criteria.AddRange(_currentSearchOperationGroup.Criteria);
                _currentSearchOperationGroup.Criteria.Clear();
                _currentSearchOperationGroup.Criteria.Add(soBase);
                _currentSearchOperationGroup.GroupType = groupType;
                _currentSearchOperationGroup.Criteria.Add(so);
            }

         
           
        }

        public void RemoveOperation(string operationID)
        {
            _search.RemoveOperation(operationID);

            _checkToMakeSureParentheisStackIsStillValid();
        }

        private void _checkToMakeSureParentheisStackIsStillValid()
        {
            if (_parenthesesStack.Count == 0)
                return;

            var g = _parenthesesStack.Peek();

            if (g == null)
                return;

            if ( _search.FindOperation(g) == null ) // problem
                _parenthesesStack.Pop();

            // now be recursive wit it
            _checkToMakeSureParentheisStackIsStillValid();
        }
    }
}
