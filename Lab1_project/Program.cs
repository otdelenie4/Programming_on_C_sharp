using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_project
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
    public class Stack
    {
        private class List
        {
            public int value;
            public List next;
            public List(int val=0,List nxt = null)
            {
                value = val;
                next = nxt;
            }
        }
        private List head;
        public Stack()
        {
            head = null;
        }
        public Stack(Stack other_stack) : this()
        {
            List current = other_stack.head;
            int size = other_stack.Size;
            int[] arr = new int[size];
            for(int i = size-1; i>=0; i--)
            {
                arr[i] = current.value;
                current = current.next;
            }
            for (int i = 0; i < size; i++)
            {
                this.Add(arr[i]);
            }
        }
        public Stack(int[] arr) : this()
        {
            for (int i = arr.Length-1; i>=0; i--)
            {
                this.Add(arr[i]);
            }
        }
        //считывание без извлечения элемента стека
        public void CopyTo(out int x)
        {
            throw new NotImplementedException();
        }
        //считывание с извлечением элемента стека
        public void ExtractTo(out int x)
        {
            throw new NotImplementedException();
        }
        //запись элемента в стек
        public void Add(int val)
        {
            throw new NotImplementedException();
        }

        public override bool Equals(object obj)
        {
            return obj is Stack stack && Equals(stack);
        }
        public bool Equals(Stack other_stack)
        {
            if (Size == other_stack.Size)
            {
                List current1 = head;
                List current2 = other_stack.head;
                while (current1 != null)
                {
                    if (current1.value != current2.value)
                    {
                        return false;
                    }
                    current1 = current1.next;
                    current2 = current2.next;
                }
                return true;
            }
            else
            {
                return false;
            }

        }
        public int Size { get
            {
                int size = 0;
                List current = head;
                while (current != null)
                {
                    size++;
                    current = current.next;
                }
                return size;
            } 
        }
    }

}
