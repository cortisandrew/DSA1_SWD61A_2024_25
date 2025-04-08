using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees
{
    /// <summary>
    /// The key, will be of integer type. Exercise: Use an IComparable key!
    /// </summary>
    
    /// <typeparam name="V">The value associated with each key</typeparam>
    public class BinarySearchTree<V>
    {
        public Vertex<V>? Root { get; private set; }

        public void Add(int key, V element)
        {
            // special case, the tree is empty,
            // therefore, the new element is placed at the root!
            if (Root == null)
            {
                Root = new Vertex<V>(key, element);
                return; // all work is finished, so return!
            }

            // Root exists
            Root.Add(key, element);
        }

        public V Search(int key)
        {
            if (Root == null)
            {
                throw new KeyNotFoundException();
            }

            return Root.Search(key);
        }
    }
}
