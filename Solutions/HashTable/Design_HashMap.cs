using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solutions.HashTable
{
    public class Design_HashMap
    {
        private MyLinkedList[] dic;

        /** Initialize your data structure here. */
        public Design_HashMap()
        {
            this.dic = new MyLinkedList[10000];
        }

        /** value will always be non-negative. */
        public void Put(int key, int value)
        {
            int i = key % 10000;
            var visit = dic[i];
            if (visit == null)
            {
                dic[i] = new MyLinkedList(key, value);
                return;
            }
            while (visit.Next != null && visit.Key != key)
                visit = visit.Next;
            if (visit.Key == key)
                visit.Value = value;
            else
            {
                var newNode = new MyLinkedList(key, value);
                visit.Next = newNode;
                newNode.Prev = visit;
            }
        }

        /** Returns the value to which the specified key is mapped, or -1 if this map contains no mapping for the key */
        public int Get(int key)
        {
            int i = key % 10000;
            var visit = dic[i];
            while (visit != null && visit.Key != key)
                visit = visit.Next;
            return visit == null ? -1 : visit.Value;
        }

        /** Removes the mapping of the specified value key if this map contains a mapping for the key */
        public void Remove(int key)
        {
            int i = key % 10000;
            var visit = dic[i];
            while (visit != null && visit.Key != key)
                visit = visit.Next;
            if (visit == null)
                return;
            if (visit.Prev != null)
                visit.Prev.Next = visit.Next;
            else
                dic[i] = visit.Next;
            if (visit.Next != null)
                visit.Next.Prev = visit.Prev;
            visit.Prev = null;
            visit.Next = null;
        }
    }
}
