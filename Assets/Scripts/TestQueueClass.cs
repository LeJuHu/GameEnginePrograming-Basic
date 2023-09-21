using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestQueueClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TestQueues();
    }

    void TestQueues()
    {
        Queue<string> numbers = new Queue<string>();
        numbers.Enqueue("one");
        numbers.Enqueue("two");
        numbers.Enqueue("three");
        numbers.Enqueue("four");
        numbers.Enqueue("five");

        // A queue can be enumerated without disturbing its contents.
        foreach (string number in numbers)
        {
            Debug.Log(number);
        }

        Debug.Log($"Dequeuing '{numbers.Dequeue()}'");
        Debug.Log($"Peek at next item to dequeue: {numbers.Peek()}");
        Debug.Log($"Dequeuing '{numbers.Dequeue()}'");

        // Create a copy of the queue, using the ToArray method and the
        // constructor that accepts an IEnumerable<T>.
        Queue<string> queueCopy = new Queue<string>(numbers.ToArray());

        Debug.Log("Contents of the first copy:");
        foreach (string number in queueCopy)
        {
            Debug.Log(number);
        }

        // Create an array twice the size of the queue and copy the
        // elements of the queue, starting at the middle of the
        // array.
        string[] array2 = new string[numbers.Count * 2];
        numbers.CopyTo(array2, numbers.Count);

        // Create a second queue, using the constructor that accepts an
        // IEnumerable(Of T).
        Queue<string> queueCopy2 = new Queue<string>(array2);

        Debug.Log("Contents of the second copy, with duplicates and nulls:");
        foreach (string number in queueCopy2)
        {
            Debug.Log(number);
        }

        Debug.Log($"queueCopy.Contains(\"four\") = {queueCopy.Contains("four")}");
        Debug.Log("queueCopy.Clear()");
        queueCopy.Clear();
        Debug.Log($"queueCopy.Count = {queueCopy.Count}");
    }
}

/* This code example produces the following output:

one
two
three
four
five

Dequeuing 'one'
Peek at next item to dequeue: two
Dequeuing 'two'

Contents of the copy:
three
four
five

Contents of the second copy, with duplicates and nulls:



three
four
five

queueCopy.Contains("four") = True

queueCopy.Clear()

queueCopy.Count = 0
 */