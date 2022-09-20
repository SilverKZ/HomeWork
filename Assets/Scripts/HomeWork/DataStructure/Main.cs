using UnityEngine;

namespace DataStructure
{    
    public class Main : MonoBehaviour
    {
        public void Start()
        {
            // Stack testing
            Stack stack = new Stack();
            Debug.Log(stack.Count);
            stack.Push("Tom");
            stack.Push("Bob");
            stack.Push("Sam");
            Debug.Log(stack.Count);

            foreach (string item in stack)
                Debug.Log(item);

            Debug.Log(stack.Peek());
            Debug.Log(stack.Pop());
            Debug.Log(stack.Pop());
            Debug.Log(stack.Count);

            // Queue testing
            Queue queue = new Queue();
            Debug.Log(queue.Count);
            queue.Enqueue("Tom");
            queue.Enqueue("Bob");
            queue.Enqueue("Sam");
            Debug.Log(queue.Count);
            Debug.Log(queue.Contains("Sam"));
            Debug.Log(queue.Dequeue());
            Debug.Log(queue.Peek());
            queue.Clear();
            Debug.Log(queue.Count);

            // List testing
            List list = new List() { "Tom", "Bob", "Sam" };
            Debug.Log(list[1]);
            list.Add("Bob");
            list.Add("Tom");
            list.Add("Sam");
            list.Add("Kate");
            list.Add("Alice");
            Debug.Log(list.Count);
            Debug.Log(list[2]);
            list.Add("Arg");
            Debug.Log(list.Count);
            list.RemoveAt(5);
            Debug.Log(list.Count);
            Debug.Log(list.IndexOf("Tom"));
            Debug.Log(list.Capacity);

            foreach (string item in list)
                Debug.Log(item);

            list.Sort();

            foreach (string item in list)
                Debug.Log(item);

            Debug.Log(list.Capacity);
            list.Reverse();

            foreach (string item in list)
                Debug.Log(item);

            Debug.Log(list.Capacity);
            list.Add("Robo");

            foreach (string item in list)
                Debug.Log(item);

            Debug.Log(list.Count);
            Debug.Log(list.Capacity);
        }
    }
}

