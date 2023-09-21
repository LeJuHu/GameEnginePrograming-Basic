using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestStackClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TestStack();
    }

    void TestStack()
    {
        Stack<string> numbers = new Stack<string>();
        numbers.Push("one");
        numbers.Push("two");
        numbers.Push("three");
        numbers.Push("four");
        numbers.Push("five");

        // A stack can be enumerated without disturbing its contents.
        foreach (string number in numbers)
        {
            Debug.Log(number);
        }

        Debug.Log($"Popping '{numbers.Pop()}'");
        Debug.Log($"Peek at next item to destack: {numbers.Peek()}");
        Debug.Log($"Popping '{numbers.Pop()}'");

        // Create a copy of the stack, using the ToArray method and the
        // constructor that accepts an IEnumerable<T>.
        Stack<string> stack2 = new Stack<string>(numbers.ToArray());

        Debug.Log("Contents of the first copy:");
        foreach (string number in stack2)
        {            
            Debug.Log(number);
        }

        // Create an array twice the size of the stack and copy the
        // elements of the stack, starting at the middle of the
        // array.
        string[] array2 = new string[numbers.Count * 2];
        numbers.CopyTo(array2, numbers.Count);

        // Create a second stack, using the constructor that accepts an
        // IEnumerable(Of T).
        Stack<string> stack3 = new Stack<string>(array2);

        Debug.Log("Contents of the second copy, with duplicates and nulls:");
        foreach (string number in stack3)
        {
            Debug.Log(number);
        }

        Debug.Log($"stack2.Contains(\"four\") = {stack2.Contains("four")}");
        Debug.Log("stack2.Clear()");
        stack2.Clear();
        Debug.Log($"stack2.Count = {stack2.Count}");
    }
}

/* This code example produces the following output:

five
four
three
two
one

Popping 'five'
Peek at next item to destack: four
Popping 'four'

Contents of the first copy:
one
two
three

Contents of the second copy, with duplicates and nulls:
one
two
three


stack2.Contains("four") = False

stack2.Clear()

stack2.Count = 0
 */