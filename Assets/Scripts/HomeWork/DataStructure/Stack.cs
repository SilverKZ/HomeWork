namespace DataStructure
{
    public class Stack : Collection
    {
        public Stack() : base()
        {
        }

        public Stack(int capacity) : base(capacity)
        {
        }

        public Stack(string[] array)
        {
            Items = new string[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                Items[i] = array[i];
            }
        }

        public void Push(string item)
        {
            TryResize();
            Items[Count] = item;
        }

        public string Peek()
        {
            return Items[Count - 1];
        }

        public string Pop()
        {
            string result = Items[Count - 1];
            Items[Count - 1] = default;
            return result;
        }
    }
}
