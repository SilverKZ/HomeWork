using System;
using System.Collections;

namespace DataStructure
{
    public abstract class Collection : IEnumerable
    {
        protected string[] Items;

        public int Count => Size();

        protected Collection()
        {
            Items = new string[0];
        }

        protected Collection(int capacity)
        {
            capacity = (capacity < 0) ? 0 : capacity;
            Items = new string[capacity];
        }

        public void Clear() => Array.Clear(Items, 0, Count);

        public bool Contains(string item) => Array.IndexOf(Items, item) >= 0;

        public IEnumerator GetEnumerator()
        {
            string[] list = Items;
            Array.Resize(ref list, Count);
            return list.GetEnumerator();
        }

        protected int Size()
        {
            int length = 0;

            for (int i = 0; i < Items.Length; i++)
            {
                if (Items[i] != null)
                    length++;
            }

            return length;
        }

        protected void TryResize()
        {
            if (Items.Length <= Count)
            {
                Array.Resize(ref Items, Items.Length == 0 ? 1 : Items.Length * 2);
            }
        }
    }
}
