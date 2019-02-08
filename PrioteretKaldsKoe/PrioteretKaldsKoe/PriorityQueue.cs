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
        Opkald ny =new Opkald();



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

        public T GetOldestCall()
        {
            T returnObject;
            returnObject = arrayOfGivenObjectType[0];
            return returnObject;
        }

            public void Dequeue(T obj)
            {

                //arrayOfGivenObjectType[obj]
                T numToRemove = obj;

                arrayOfGivenObjectType = arrayOfGivenObjectType.Where(val => val != numToRemove).ToArray();
                foreach (T opkald in arrayOfGivenObjectType)
                {
                    if (arrayOfGivenObjectType[0])
                    {
                        else
                        {
                                
                        }
                    }
                }
        }
        public void Dequeue()
        {

            arrayOfGivenObjectType = arrayOfGivenObjectType.Skip(1).ToArray();
            currentArraySpot--;

        }
    }
}
