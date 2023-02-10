using System;
using System.Runtime.Caching;


/// <summary>
/// The Util namespace.
/// </summary>
namespace UniversityMgmtUtil
{
    /// <summary>
    /// This class used to hold object in Cache object.
    /// </summary>
    public class CacheBase
    {
        /// <summary>
        /// The defaul t_ cach e_ interva l_ minutes
        /// </summary>
        public const int DEFAULT_CACHE_INTERVAL_MINUTES = 20;
        private static Object _lockObject = new object();
        /// <summary>
        /// Initializes a new instance of the <see cref="CacheBase"/> class.
        /// </summary>
        public CacheBase()
        {
        }
        /// <summary>
        /// Add the value into Cache
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="val">The value.</param>
        public static void Add(string key, object val)
        {
            Add(key, val, new TimeSpan(0, DEFAULT_CACHE_INTERVAL_MINUTES, 0));
        }

        /// <summary>
        /// Adds the with key dependency.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="val">The value.</param>
        /// <param name="dependencyStr">The dependency string.</param>
        public static void AddWithKeyDependency(string key, object val, string dependencyStr)
        {
            //key.DebugFormat("CacheBase: Adding [{0}] key type of [{1}] object with CacheDependencyKey [{2}] to Cache", key, (val == null) ? "null" : val.GetType().FullName, dependencyStr);
            string[] keys = new String[1];
            keys[0] = dependencyStr;
            
            System.Web.Caching.CacheDependency cd = new System.Web.Caching.CacheDependency(null, keys);

            Add(key, val, cd);
        }
        /// <summary>
        /// Adds the with file dependency.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="val">The value.</param>
        /// <param name="dependencyFile">The dependency file.</param>
        public static void AddWithFileDependency(string key, object val, string dependencyFile)
        {
            //key.DebugFormat("CacheBase: Adding [{0}] key type of [{1}] object with CacheDependencyFile [{2}] to Cache", key, (val == null) ? "null" : val.GetType().FullName, dependencyFile);
            System.Web.Caching.CacheDependency cd = new System.Web.Caching.CacheDependency(dependencyFile);

            Add(key, val, cd);
        }

        /// <summary>
        /// Add the value into Cache with dependency object.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="val">The value.</param>
        /// <param name="dep">The dep.</param>
        public static void Add(string key, object val, CacheDependency dep)
        {
            Add(key, val, dep, new TimeSpan(0, DEFAULT_CACHE_INTERVAL_MINUTES, 0));
        }

        /// <summary>
        /// Add the value into Cache with dependency object and timespan
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="val">The value.</param>
        /// <param name="dep">The dep.</param>
        /// <param name="ts">The ts.</param>
		public static void Add(string key, object val, CacheDependency dep, TimeSpan ts)
        {
            lock (_lockObject)
            {
                //key.DebugFormat("CacheBase: Key [{0}] added to Cache of type [{1}]", key, (val == null) ? "null" : val.GetType().FullName);
                HttpRuntime.Cache.Insert(key, val, dep, DateTime.MaxValue, ts, CacheItemPriority.Normal, new CacheItemRemovedCallback(OnRemove));
            }
        }

        /// <summary>
        /// This event will triggered by CacheItemRemovedCallback.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="val">The value.</param>
        /// <param name="reason">The reason.</param>
        public static void OnRemove(string key, object val, CacheItemRemovedReason reason)
        {
            //key.DebugFormat("CacheBase: Key [{0}] removed from Cache. Reason=[{1}]", key, reason.ToString());
            HttpRuntime.Cache.Remove(key);
        }
        /// <summary>
        /// For Sliding epiration
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="val">The value.</param>
        /// <param name="ts">The ts.</param>
        public static void Add(string key, object val, TimeSpan ts)
        {
            lock (_lockObject)
            {
                //key.DebugFormat("CacheBase: Key [{0}] added to Cache of type [{1}]. Expires in [{2}] seconds", key, (val == null) ? "null" : val.GetType().FullName, ts.TotalSeconds);
                HttpRuntime.Cache.Insert(key, val, null, Cache.NoAbsoluteExpiration, ts, CacheItemPriority.Normal, new CacheItemRemovedCallback(OnRemove));
            }
        }
        /// <summary>
        /// For Absolute epiration
        /// </summary>
        /// <param name="key">The key.</param>
        /// <param name="val">The value.</param>
        /// <param name="dt">The dt.</param>
        public static void Add(string key, object val, DateTime dt)
        {
            lock (_lockObject)
            {
                //key.DebugFormat("CacheBase: Key [{0}] added to Cache of type [{1}]. Expires on [{2}]", key, (val == null) ? "null" : val.GetType().FullName, dt.ToString());
                HttpRuntime.Cache.Insert(key, val, null, dt, Cache.NoSlidingExpiration, CacheItemPriority.Normal, new CacheItemRemovedCallback(OnRemove));
            }
        }

        /// <summary>
        /// This will remove object from Cache.
        /// </summary>
        /// <param name="key">The key.</param>
        public static void Remove(string key)
        {
            //key.DebugFormat("CacheBase: Removing [{0}] key from Cache", key);

            HttpRuntime.Cache.Remove(key);
        }

        /// <summary>
        /// Get the object from Cache based on the specified key.
        /// </summary>
        /// <param name="key">The key.</param>
        /// <returns>System.Object.</returns>
        public static object GetItem(string key)
        {
            //key.DebugFormat("Getting [{0}] key from Cache", key);
            object obj = HttpRuntime.Cache[key];
            return obj;
        }

        public static T GetItem<T>(string key)
        {
            return (T)GetItem(key);           
        }
    }
}
