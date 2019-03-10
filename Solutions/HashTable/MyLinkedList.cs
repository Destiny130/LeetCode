namespace Solutions.HashTable
{
    class MyLinkedList
    {
        public int Key;
        public int Value;
        public MyLinkedList Prev;
        public MyLinkedList Next;
        public MyLinkedList(int x, int y)
        {
            this.Key = x;
            this.Value = y;
        }
    }
}
