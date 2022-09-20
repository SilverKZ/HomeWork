using System;

namespace DataStructure
{
    public class List : Collection
    {
        public int Capacity => Items.Length;
        public string this[int index]
        {
            get 
            { 
                ValidateIndex(index); 
                return Items[index]; 
            }
            set => Insert(index, value);
        }

        public List() : base()
        {
        }

        public List(int capacity) : base(capacity)
        {
        }

        public void Insert(int index, string item)
        {
            TryResize();
            ValidateIndex(index);

            for (var i = Count - 1; i > index; i--)
                Items[i] = Items[i - 1];

            Items[index] = item;
        }

        public void RemoveAt(int index)
        {
            ValidateIndex(index);

            for (var i = index; i < Count - 1; i++)
            {
                Items[i] = Items[i + 1];
            }

            Items[Count - 1] = default;
        }

        public int IndexOf(string item) => Array.IndexOf(Items, item);

        public void Add(string item)
        {
            Insert(Count, item);
        }

        public void Remove(string item) => RemoveAt(IndexOf(item));

        public void Reverse() => Array.Reverse(Items, 0, Count);

        public void Sort() => Array.Sort(Items, 0, Count);

        private void ValidateIndex(int index)
        {
            if (index < 0 || index > Count)
            {
                throw new IndexOutOfRangeException(nameof(index));
            }
        }
    }
}
