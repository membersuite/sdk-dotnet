using System;
using System.Collections.Generic;

namespace MemberSuite.SDK.DataLoader
{
    public class MarkerCache
    {
        /// <summary>
        ///     Gets or sets the id markers.
        /// </summary>
        /// <value>The id markers.</value>
        private Dictionary<string, Dictionary<string, string>> _cache;

        public MarkerCache()
        {
            Cache = new Dictionary<string, Dictionary<string, string>>();
        }

        /// <summary>
        ///     Gets or sets the id markers.
        /// </summary>
        /// <value>The id markers.</value>
        public Dictionary<string, Dictionary<string, string>> Cache
        {
            get { return _cache; }
            set { _cache = value; }
        }

        public bool ContainsMarker(string marker)
        {
            if (marker == null) throw new ArgumentNullException("marker");
            foreach (var dic in Cache.Values)
                if (dic.ContainsKey(marker))
                    return true;


            return false;
        }

        public void StoreMarker(string objectType, string marker, string markerValue)
        {
            Dictionary<string, string> dic;
            if (!Cache.TryGetValue(objectType, out dic))
            {
                dic = new Dictionary<string, string>();
                Cache[objectType] = dic;
            }

            if (string.IsNullOrWhiteSpace(markerValue))
                dic[marker] = null;
            else
                dic[marker] = markerValue;
        }

        public string LookupMarker(string objectType, string marker)
        {
            Dictionary<string, string> dic;
            if (!Cache.TryGetValue(objectType, out dic))
            {
                //HACK - special case for entities
                if (objectType == "Entity")
                {
                    var indiv = LookupMarker("Individual", marker);
                    if (indiv != null) return indiv;
                    var org = LookupMarker("Organization", marker);
                    if (org != null) return org;
                }

                return null;
            }

            string value;
            if (dic.TryGetValue(marker, out value))
                return value;

            return null;
        }

        public Dictionary<string, Dictionary<string, string>> GetAllMarkers()
        {
            return Cache;
        }

        public int Count()
        {
            var count = 0;
            foreach (var entry in Cache)
                count += entry.Value.Count;

            return count;
        }

        public Dictionary<string, string> GetCacheFor(string objectType)
        {
            Dictionary<string, string> dic;
            if (Cache.TryGetValue(objectType, out dic))
                return dic;

            return null;
        }

        public string LookupAnyMarker(string marker)
        {
            if (marker == null) throw new ArgumentNullException("marker");
            foreach (var dic in Cache.Values)
                if (dic.ContainsKey(marker))
                    return dic[marker];

            return null;
        }
    }
}