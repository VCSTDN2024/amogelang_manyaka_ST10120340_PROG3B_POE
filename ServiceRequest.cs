using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG3B_Task1
{
    public class ServiceRequest
    {
        public int RequestId { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public DateTime CreatedAt { get; set; }

        public int Priority { get; set; } 

        public ServiceRequest(int requestId, string title, string status, int priority = 2)
        {
            RequestId = requestId;
            Title = title;
            Status = status;
            CreatedAt = DateTime.Now;
            Priority = priority;
        }

        public override string ToString()
        {
            return $"{RequestId} - {Title} ({Status}) [Priority: {Priority}]";
        }
    }

    public class BSTNode {
        public ServiceRequest Data;
        public BSTNode Left, Right;

        public BSTNode(ServiceRequest data) {
            Data = data;
        }
    }

    public class ServiceRequestBST
    {
        public BSTNode Root;

        public void Insert(ServiceRequest data)
        {
            Root = InsertRec(Root, data);
        }

        private BSTNode InsertRec(BSTNode root, ServiceRequest data)
        { 
            if (root == null)
                return new BSTNode(data);

            if(data.RequestId < root.Data.RequestId)
                root.Left = InsertRec(root.Left, data);
            else if(data.RequestId > root.Data.RequestId)
                root.Right = InsertRec(root.Right, data);   

            return root;

        }

        public ServiceRequest Search(int requestId)
        {
            BSTNode current = Root;
            while (current != null)
            {
                if (requestId == current.Data.RequestId)
                    return current.Data;
                else if (requestId < current.Data.RequestId)
                    current = current.Left;
                else
                    current = current.Right;
            }

            return null;
        }

        public List<ServiceRequest> InOrder()
        { 
            List<ServiceRequest> list = new List<ServiceRequest>();
            InOrderRec(Root, list);
            return list;

        }

        private void InOrderRec(BSTNode root, List<ServiceRequest> list)
        {
            if (root != null)
            {
                InOrderRec(root.Left, list);
                list.Add(root.Data);
                InOrderRec(root.Right, list);
            }
        }
    }
}
