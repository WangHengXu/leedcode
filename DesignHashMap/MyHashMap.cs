using System.Collections.Generic;
using System.Linq;
namespace DesignHashMap
{
    public class Node
    {
        public int key;
        public int value;
    }
    public class MyHashMap
    {

        List<Node> nodes;
        public MyHashMap()
        {
            nodes = new List<Node>();
        }
        public void Put(int key, int value)
        {
            var findnode = nodes.FirstOrDefault(x => x.key == key);
            if (findnode == null)
            {
                nodes.Add(new Node() { key = key, value = value });
            }
            else
            {
                findnode.value = value;
            }
        }

        public int Get(int key)
        {
            var findnode = nodes.FirstOrDefault(x => x.key == key);
            return findnode == null ? -1 : findnode.value;
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            var findnode = nodes.FirstOrDefault(x => x.key == key);
            if (findnode != null) nodes.Remove(findnode);
        }
    }
}
