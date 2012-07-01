namespace CircularBufferPattern.Pattern
{
    public class CircularBuffer
    {
        private int[] data;
        private int head;
        private int tail;

        public CircularBuffer(int number)
        {
            this.data = new int[number];
            this.head = 0;
            this.tail = 0;
        }

        public bool Store(int value)
        {
            if (!this.BufferFull())
            {
                this.data[this.tail++] = value;
                if (this.tail == this.data.Length)
                {
                    this.tail = 0;
                }

                return true;
            }
            else
            {
                return false;
            }
        }

        public string Read()
        {
            if (this.head != this.tail)
            {
                int value = this.data[this.head++];
                if (this.head == this.data.Length)
                {
                    this.head = 0;
                }

                return value.ToString();
            }
            else
            {
                return "null";
            }
        }

        private bool BufferFull()
        {
            if (this.tail + 1 == this.head)
            {
                return true;
            }

            if (this.tail == (this.data.Length - 1) && this.head == 0)
            {
                return true;
            }

            return false;
        }
    }
}
