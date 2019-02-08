using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrioteretKaldsKoe
{
    class PriorityQueue<T> where T : Opkald

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

    public T GetOldestCall()
    {
        T returnObject;
        returnObject = arrayOfGivenObjectType[0];
        return returnObject;
    }

    public T GetsNextCall(int callerID)
    {
        return arrayOfGivenObjectType[callerID];
    }

    public void Dequeue(T obj)
    {



        T[] theNewArray = new T[arrayOfGivenObjectType.Length - 1];
        int foreachiterator = 0;
        bool foundIt = false;
        foreach (var opkald in arrayOfGivenObjectType)
        {
            if (foundIt == false && arrayOfGivenObjectType[0].GetType() == typeof(PrioriteretOpkald))
            {
                arrayOfGivenObjectType = arrayOfGivenObjectType.Skip(1).ToArray();
                foundIt = true;
            }
            else
            {
                theNewArray[foreachiterator] = arrayOfGivenObjectType[0];
                arrayOfGivenObjectType = arrayOfGivenObjectType.Skip(1).ToArray();
                foreachiterator++;

                }

            


        }

        currentArraySpot--;
        arrayOfGivenObjectType = theNewArray;
    }

    public void Dequeue()
    {

        arrayOfGivenObjectType = arrayOfGivenObjectType.Skip(1).ToArray();
        currentArraySpot--;

    }
    }
}
