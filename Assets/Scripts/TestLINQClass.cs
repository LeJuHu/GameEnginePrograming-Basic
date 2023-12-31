using System.Linq;
using UnityEngine;

public class TestLINQClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TestLINQ();
    }
    
    void TestLINQ()
    {
        // The Three Parts of a LINQ Query:
        // 1. Data source.
        int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };

        // 2. Query creation.
        // numQuery is an IEnumerable<int>
        var numQuery =
            from num in numbers 
            where (num % 2) == 0
            select num;

        // 3. Query execution.
        foreach (int num in numQuery)
        {
            Debug.Log(string.Format("{0,1} ", num));
        }
    }
}
