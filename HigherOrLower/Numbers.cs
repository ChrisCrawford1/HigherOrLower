using System;
using System.Collections.Generic;

namespace HigherOrLower
{
    public class Numbers
    {
        private Stack<int> numberStack = new Stack<int>();

        public Numbers() => GenerateStack();

        private void GenerateStack()
        {
            Random rand = new Random();

            for (int i = 0; i <= 49; i++)
            {
                this.numberStack.Push(rand.Next(0, 1000));
            }
        }

        public Stack<int> GetNumberStack()
        {
            return this.numberStack;
        }
    }
}
