namespace Trees
{
    public class Vertex<V>
    {
        public Vertex(int key, V element) {
            this.Key = key;
            this.Element = element;
        }

        public int Key { get; private set; }

        public V Element { get; internal set; }

        public Vertex<V>? Left { get; internal set; }
        public Vertex<V>? Right { get; internal set; }

        internal void Add(int key, V element)
        {
            if (key < Key)
            {
                // the key is smaller than the Key of the Vertex,
                // place it to the left, to keep sort order

                if (Left == null) { 
                    // there is available space!
                    // place the new element as the left child
                    Left = new Vertex<V>(key, element);
                    return;
                }
                else
                {
                    // otherwise Left exists!
                    // call the method recursively
                    Left.Add(key, element);
                    return;
                }
            }
            else
            {
                // the key is larger than (or equal to) the Key of the Vertex
                // place it to the right, to keep sort order
                if (Right == null)
                {
                    // there is available space!
                    // place the new element as the right child
                    Right = new Vertex<V>(key, element);
                    return;
                }
                else
                {
                    // otherwise Right exists!
                    // call the method recursively
                    Right.Add(key, element);
                    return;
                }
            }
        }

        internal V Search(int key)
        {
            if (Key == key)
            {
                // the key matches this vertex!
                // we have found what we have been looking for!
                return Element;
            }

            if (key < Key)
            {
                // the key we are searching for is SMALLER than the key of this vertex
                // sort-order: look left!

                if (Left == null)
                {
                    throw new KeyNotFoundException();
                }
                else
                {
                    V result = Left.Search(key);
                    return result;
                }
            }
            else // key >= Key
            {
                // the key we are searching for is LARGER than the key of this vertex
                // sort-order: look right!

                // Exercise: TO DO, implement this!
                throw new NotImplementedException("Exercise!");
            }

        }
    }
}