using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Solutions._05
{
    internal class Design_HashSet
    {
        //public MyHashSet() { }

        Dictionary<int, bool> dic = new Dictionary<int, bool>();

        public void Add(int key)
        {
            dic.Remove(key);
            dic.Add(key, true);
        }

        public void Remove(int key)
        {
            dic.Remove(key);
            dic.Add(key, false);
        }

        public bool Contains(int key)
        {
            return dic.ContainsKey(key) ? dic[key] : false;
        }
    }
}
