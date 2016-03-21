using System;

namespace MemberSuite.SDK.Manifests.Searching
{
    [Serializable]
    public struct ShortenedSearchManifest
    {
        private string _displayName;
        private string _module;
        private string _name;

        public ShortenedSearchManifest(string displayName, string name, string module)
        {
            _displayName = displayName;
            _module = module;
            _name = name;
        }

        public string DisplayName
        {
            get { return _displayName; }
            set { _displayName = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Module
        {
            get { return _module; }
            set { _module = value; }
        }
    }
}