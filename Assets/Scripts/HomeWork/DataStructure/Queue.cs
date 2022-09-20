namespace DataStructure
{
    public class Queue : Collection
    {
        public Queue() : base()
        {
        }

        public Queue(int capacity) : base(capacity)
        {
        }

        public Queue(string[] array)
        {
            Items = new string[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                Items[i] = array[i];
            }
        }

        public void Enqueue(string item)
        {
            TryResize();
            Items[Count] = item;
        }

        public string Peek()
        {
            return Items[0];
        }

        public string Dequeue()
        {
            string result = Items[0];

            for (var i = 0; i < Count - 1; i++)
            {
                Items[i] = Items[i + 1];
            }

            Items[Count - 1] = default;

            return result;
        }
    }
}
