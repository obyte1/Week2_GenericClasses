﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week2_GenericClasses.Classess;

namespace Week2_GenericClasses
{
    public class Queue<T> : IEnumerable<T>
    {
        LinkedLis<T> QueueTest = new LinkedLis<T>();
        public int count { get; private set; }

        //checks if the queue is empty
        public bool QueueIsEmpty()
        {
            if (QueueTest.Count == 0)
            {
                return true;
            }

            return false;
        }

        //adds to the tail of the queue
        public void QEnqueue(T item)
        {
            QueueTest.Add(item);
            count++;
        }


        //removes from the top of the queue
        public T QDequeue()
        {
            count--;
            return QueueTest.RemoveFirst();
        }

        //returns the size of the queue
        public int Qsize()
        {
            return count;
        }
        public IEnumerator<T> GetEnumerator()
        {
            foreach (T Item in QueueTest)
            {
                yield return Item;

            }

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}