using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrioteretKaldsKoe
{
    class PriorityQueue <T>
    {

            private T[] arrayOfGivenObjectType;
            private int arrayCount = 1;
            private int currentArraySpot = 0;



            public PriorityQueue()
            {
                this.arrayOfGivenObjectType = new T[arrayCount];

            }

            public void QueueExpand()
            {
                T[] newArray = new T[arrayOfGivenObjectType.Length * 2];
                for (int i = 0; i < arrayOfGivenObjectType.Length; i++)
                    newArray[i] = arrayOfGivenObjectType[i];
                arrayOfGivenObjectType = newArray;
            }




            public void Enqueue(T obj)
            {

                if (arrayCount == currentArraySpot + 1)
                {

                    QueueExpand();
                    arrayOfGivenObjectType[currentArraySpot] = obj;
                    arrayCount *= 2;
                }
                else
                {

                    arrayOfGivenObjectType[currentArraySpot] = obj;

                }

                currentArraySpot++;
            }

            public void Dequeue(T obj)
            {
            
            arrayOfGivenObjectType = arrayOfGivenObjectType.Skip(1).ToArray();
            currentArraySpot--;

        }
        }
}
