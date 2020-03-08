using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace ProjectList
{
    public class MaxQueue
    {
        int maxVulue=-1;
 
        List<int> queueint;
        public MaxQueue()
        {
            queueint = new List<int>();
        }

        public int Max_value()
        {
            if (queueint.Count == 0) return -1;
            return maxVulue;
        }

        public void Push_back(int value)
        {
            if (value > maxVulue) maxVulue = value;
            queueint.Add(value);

        }

        public int Pop_front()
        {
           if(queueint.Count>0)
            {
                int res = queueint[0];
                queueint.RemoveAt(0);
               if(res==maxVulue&& queueint.Count>0)
                {
                    maxVulue = queueint.Max();
                }
                if (queueint.Count == 0) maxVulue = -1;
                return res;
            }
           else
            {
                return -1;
            }
        }
    }
}
