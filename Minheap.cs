using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG3B_Task1
{
    public class Minheap
    {
        private List<ServiceRequest> heap = new List<ServiceRequest>();
        
        private int Parent (int i) => (i - 1) / 2;
        private int Left (int i) => 2 * i + 1;
        private int Right (int i) => 2 * i + 2;

        private void Swap (int i, int j)
        {
            var temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }

        public void Insert (ServiceRequest request)
        {
         heap.Add(request);
            int index = heap.Count - 1; 
            while (index > 0 && heap[Parent(index)].Priority > heap[index].Priority)
            {
                Swap(index, Parent(index));
                index = Parent(index);
            }

        }
        public ServiceRequest ExtractMin()
        {
            if (heap.Count == 0) return null;

            var root = heap[0];
            heap[0] = heap[^1];
            heap.RemoveAt(heap.Count - 1);
            MinHeapify(0);

            return root;
        }

        private void MinHeapify(int i)
        {
            int smallest = i;
            int left = Left(i);
            int right = Right(i);

            if (left < heap.Count && heap[left].Priority < heap[smallest].Priority)
                smallest = left;

            if (right < heap.Count && heap[right].Priority < heap[smallest].Priority)
                smallest = right;

            if (smallest != i)
            {
                Swap(i, smallest);
                MinHeapify(smallest);
            }
        }

        public List<ServiceRequest> ToList()
        {
            return new List<ServiceRequest>(heap);
        }

    }
}
