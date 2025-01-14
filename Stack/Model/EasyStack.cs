﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace Stack.Model
{
    public class EasyStack<T>
    {
        public int Count => items.Count;

        public bool IsEmpty => items.Count == 0;

        private List<T> items = new List<T>();

        public void Push(T item)
        {
            items.Add(item);
        }

        public T Pop()
        {
            if (!IsEmpty)
            {
                var item = items.LastOrDefault();
                items.Remove(item);
                return item;
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public void Clear()
        {
            items.Clear();
        }

        public T Peek()
        {
            if (!IsEmpty)
            {
                return items.LastOrDefault();
            }
            else
            {
                throw new NullReferenceException("Stack is empty");
            }
        }

        public object Clone()
        {
            var newStack = new EasyStack<T>();
            newStack.items = new List<T>(items);
            return newStack;
        }

        public override string ToString()
        {
            return $"Stack with {items.Count} elements";
        }
    }

}
