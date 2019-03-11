namespace Solutions.HashTable_LC
{
    public class Design_HashSet
    {
        private DoublyLinkedList[] set;

        /** Initialize your data structure here. */
        public Design_HashSet()
        {
            this.set = new DoublyLinkedList[10000];
        }

        public void Add(int key)
        {
            int i = key % 10000;
            var visit = set[i];
            if (visit == null)
                set[i] = new DoublyLinkedList(key);
            else
            {
                while (visit.Next != null && visit.Val != key)
                    visit = visit.Next;
                if (visit.Val == key)
                    return;
                var newNode = new DoublyLinkedList(key);
                visit.Next = newNode;
                newNode.Prev = visit;
            }
        }

        public void Remove(int key)
        {
            int i = key % 10000;
            var visit = set[i];
            while (visit != null && visit.Val != key)
                visit = visit.Next;
            if (visit == null)
                return;
            if (visit.Prev != null)
                visit.Prev.Next = visit.Next;
            else
                set[i] = visit.Next;
            if (visit.Next != null)
                visit.Next.Prev = visit.Prev;
            visit.Prev = null;
            visit.Next = null;
        }

        /** Returns true if this set contains the specified element */
        public bool Contains(int key)
        {
            int i = key % 10000;
            var visit = set[i];
            while (visit != null && visit.Val != key)
                visit = visit.Next;
            return visit != null;
        }
    }
}
