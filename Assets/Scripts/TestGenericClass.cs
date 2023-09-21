using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestGenericClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TestGeneric01();
    }

    public class Generic<T>
    {
        public T Field;
    }

    void TestGeneric01()
    {
        Generic<string> g = new Generic<string>();
        g.Field = "A string";
        //...
        Debug.Log($"Generic.Field           = \"{ g.Field}\"");
        Debug.Log($"Generic.Field.GetType() = {g.Field.GetType().FullName}");
    }

    void TestGeneric02()
    {
        int[] arr = { 0, 1, 2, 3, 4 };
        List<int> list = new List<int>();

        for (int x = 5; x < 10; x++)
        {
            list.Add(x);
        }

        ProcessItems<int>(arr);
        ProcessItems<int>(list);
    }

    void ProcessItems<T>(IList<T> coll)
    {
        // IsReadOnly returns True for the array and False for the List.
        Debug.Log($"IsReadOnly returns {coll.IsReadOnly} for this collection.");

        // The following statement causes a run-time exception for the
        // array, but not for the List.
        //coll.RemoveAt(4);        
        foreach (T item in coll)
        {
            Debug.Log(item.ToString());
        } 
    }

}

class A
{
    T G<T>(T arg)
    {
        T temp = arg;
        //...
        return temp;
    }
}

class Generic<T>
{
    T M(T arg)
    {
        T temp = arg;
        //...
        return temp;
    }
}