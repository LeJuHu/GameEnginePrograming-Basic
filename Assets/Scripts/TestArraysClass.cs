using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public class TestArraysClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        TestArrays();
        TestArrays02();
        TestArrays03();
        TestArrays04();
        TestArrays06();
        TestArrays07();
        TestArrays09();
        TestArrays10();
        TestArrays11();
        TestArrays12();
        TestArrays13();
        TestArrays14();
    }

    void TestArrays()
    {
        // Declare a single-dimensional array of 5 integers.
        int[] array1 = new int[5];               

        // Declare and set array element values.
        int[] array2 = new int[] { 1, 3, 5, 7, 9 };

        // Alternative syntax.
        int[] array3 = { 1, 2, 3, 4, 5, 6 };

        // Declare a two dimensional array.
        int[,] multiDimensionalArray1 = new int[2, 3];

        // Declare and set array element values.
        int[,] multiDimensionalArray2 = { { 1, 2, 3 }, { 4, 5, 6 } };

        // Declare a jagged array.
        int[][] jaggedArray = new int[6][];

        // Set the values of the first array in the jagged array structure.
        jaggedArray[0] = new int[4] { 1, 2, 3, 4 };         
    }

    public class SomeType { };

    void TestArrays02()
    {
        // 배열 생성
        int[] array = new int[5];
        string[] stringArray = new string[6];

        // 배열 초기화
        int[] array1 = new int[] { 1, 3, 5, 7, 9 };
        string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        // 암시적으로 형식화된 배열
        int[] array2 = { 1, 3, 5, 7, 9 };
        string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        // 배열 변수를 만들지 않고 선언할 수 있지만 이 변수에 새 배열을 할당할 때는 new 연산자를 사용해야 합니다.
        int[] array3;
        array3 = new int[] { 1, 3, 5, 7, 9 };   // OK
        //array3 = {1, 3, 5, 7, 9};   // Error

        // 값 형식 및 참조 형식 배열
        SomeType[] array4 = new SomeType[10];
        // 이 문의 결과는 SomeType이 값 형식인지 또는 참조 형식인지에 따라 달라집니다.
        // 값 형식인 경우 이 문은 각각 SomeType 형식인 10개 요소의 배열을 만듭니다.
        // SomeType이 참조 형식인 경우 이 문은 각각 null 참조로 초기화된 10개 요소의 배열을 만듭니다.
        // 두 인스턴스 모두에서 요소가 요소 형식에 대한 기본값으로 초기화됩니다. 
    }

    void TestArrays03()
    {
        // 인덱스를 사용하여 배열의 데이터를 검색할 수 있습니다.
        string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

        Debug.Log(weekDays2[0]);
        Debug.Log(weekDays2[1]);
        Debug.Log(weekDays2[2]);
        Debug.Log(weekDays2[3]);
        Debug.Log(weekDays2[4]);
        Debug.Log(weekDays2[5]);
        Debug.Log(weekDays2[6]);

        /*Output:
        Sun
        Mon
        Tue
        Wed
        Thu
        Fri
        Sat
        */
    }

    void TestArrays04()
    {
        // 다차원 배열 선언    
        int[,] array = new int[4, 2];
        int[,,] array1 = new int[4, 2, 3];

        // 다차원 배열 초기화
        // Two-dimensional array.
        int[,] array2D = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        // The same array with dimensions specified.
        int[,] array2Da = new int[4, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
        // A similar array with string elements.
        string[,] array2Db = new string[3, 2] { { "one", "two" }, { "three", "four" },
                                                { "five", "six" } };

        // Three-dimensional array.
        int[,,] array3D = new int[,,] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                         { { 7, 8, 9 }, { 10, 11, 12 } } };
        // The same array with dimensions specified.
        int[,,] array3Da = new int[2, 2, 3] { { { 1, 2, 3 }, { 4, 5, 6 } },
                                               { { 7, 8, 9 }, { 10, 11, 12 } } };

        TestArrays05(array2D, array2Db, array3D, array3Da);
    }

    void TestArrays05(int[,] array2D, string[,] array2Db, int[,,] array3D, int[,,] array3Da)
    {
        // Accessing array elements.
        Debug.Log(array2D[0, 0]);
        Debug.Log(array2D[0, 1]);
        Debug.Log(array2D[1, 0]);
        Debug.Log(array2D[1, 1]);
        Debug.Log(array2D[3, 0]);
        Debug.Log(array2Db[1, 0]);
        Debug.Log(array3Da[1, 0, 1]);
        Debug.Log(array3D[1, 1, 2]);

        // Getting the total count of elements or the length of a given dimension.
        var allLength = array3D.Length;
        var total = 1;
        for (int i = 0; i < array3D.Rank; i++)
        {
            total *= array3D.GetLength(i);
        }
        Debug.Log($"{allLength} equals {total}");
    }

    void TestArrays06()
    {
        // 순위를 지정하지 않고 배열을 초기화
        int[,] array4 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

        // 초기화하지 않고 배열 변수를 선언하도록 선택할 경우 new 연산자를 사용하여 변수에 배열을 할당
        int[,] array5;
        array5 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };   // OK
        //array5 = {{1,2}, {3,4}, {5,6}, {7,8}};   // Error

        // 배열 요소 할당
        array5[2, 1] = 25;
        // 특정 배열 요소의 값을 가져와 elementValue 변수에 할당
        int elementValue = array5[2, 1];
        // 배열 요소를 기본 값으로 초기화
        int[,] array6 = new int[10, 10];
    }

    void TestArrays07()
    {
        //  각각 정수의 1차원 배열(가변 배열)를 3개를 포함하는 1차원 배열의 선언
        int[][] jaggedArray = new int[3][];

        // 초기화
        jaggedArray[0] = new int[5];
        jaggedArray[1] = new int[4];
        jaggedArray[2] = new int[2];
        // 이니셜라이저를 사용하여 초기화 및 할당
        jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
        jaggedArray[1] = new int[] { 0, 2, 4, 6 };
        jaggedArray[2] = new int[] { 11, 22 };
        // 선언 시 배열을 초기화
        int[][] jaggedArray2 = new int[][]
        {
            new int[] { 1, 3, 5, 7, 9 },
            new int[] { 0, 2, 4, 6 },
            new int[] { 11, 22 }
        };
        // 약식 형태
        // 요소에 대한 기본 초기화가 없으므로 요소 초기화에서 new 연산자를 생략할 수 없습니다.
        int[][] jaggedArray3 =
        {
            new int[] { 1, 3, 5, 7, 9 },
            new int[] { 0, 2, 4, 6 },
            new int[] { 11, 22 }
        };

        TestArrays08(jaggedArray3);
    }

    void TestArrays08(int[][] jaggedArray3)
    {
        // Assign 77 to the second element ([1]) of the first array ([0]):
        jaggedArray3[0][1] = 77;

        // Assign 88 to the second element ([1]) of the third array ([2]):
        jaggedArray3[2][1] = 88;

        // 가변 배열과 다차원 배열을 함께 사용할 수 있습니다.
        int[][,] jaggedArray4 = new int[3][,]
        {
            new int[,] { {1,3}, {5,7} },
            new int[,] { {0,2}, {4,6}, {8,10} },
            new int[,] { {11,22}, {99,88}, {0,9} }
        };

        // 개별 요소에 액세스
        //Debug.Log($"{jaggedArray4[0][1, 0]}");
        Debug.Log(string.Format("{0}", jaggedArray4[0][1, 0]));
        // 배열 길이 반환
        Debug.Log(jaggedArray4.Length);
        // 3
    }

    void TestArrays09()
    {
        // Declare the array of two elements.
        int[][] arr = new int[2][];

        // Initialize the elements.
        arr[0] = new int[5] { 1, 3, 5, 7, 9 };
        arr[1] = new int[4] { 2, 4, 6, 8 };

        StringBuilder strings = new StringBuilder();
        // Display the array elements.
        for (int i = 0; i < arr.Length; i++)
        {
            strings.Append($"Element({i}): ");

            for (int j = 0; j < arr[i].Length; j++)
            {
                strings.Append(
                    string.Format("{0}{1}", arr[i][j], j == (arr[i].Length - 1) ? "" : " "));
            }
            Debug.Log(strings.ToString());
            strings.Clear();
        }
        /* Output:
        Element(0): 1 3 5 7 9
        Element(1): 2 4 6 8
        */
    }

    void TestArrays10()
    {
        // 1차원 배열의 경우 foreach 문은 인덱스 0으로 시작하고
        // 인덱스 Length - 1로 끝나는 늘어나는 인덱스 순서로 요소를 처리합니다.
        int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
        foreach (int i in numbers)
        {
            Debug.Log(i);
        }
        // Output: 4 5 6 1 2 3 -2 -1 0

        // 다차원 배열의 경우 요소는 가장 오른쪽 차원의 인덱스가 먼저 증가한 이후,
        // 다음 왼쪽 차원의 인덱스, 그다음 왼쪽 차원의 인덱스가 증가하는 방식으로 트래버스됩니다.
        int[,] numbers2D = new int[3, 2] { { 9, 99 }, { 3, 33 }, { 5, 55 } };
        // Or use the short form:
        // int[,] numbers2D = { { 9, 99 }, { 3, 33 }, { 5, 55 } };

        foreach (int i in numbers2D)
        {
            Debug.Log(i);
        }
        // Output: 9 99 3 33 5 55
    }

    void TestArrays11()
    {
        int[] theArray = { 1, 3, 5, 7, 9 };
        PrintArray(theArray);
        //  새 배열을 초기화하고 전달
        PrintArray(new int[] { 1, 3, 5, 7, 9 });
    }

    void PrintArray(int[] arr)
    {
        Debug.Log(string.Join(" ", arr));
    }
       
    void DisplayArray(string[] arr) => Debug.Log(string.Join(" ", arr));    

    // Change the array by reversing its elements.
    void ChangeArray(string[] arr) => Array.Reverse(arr);

    void ChangeArrayElements(string[] arr)
    {        
        // Change the value of the first three array elements.
        arr[0] = "Mon";
        arr[1] = "Wed";
        arr[2] = "Fri";
    }

    void TestArrays12()
    {
        // Declare and initialize an array.
        string[] weekDays = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        // Display the array elements.
        DisplayArray(weekDays);
        
        // Reverse the array.
        ChangeArray(weekDays);
        // Display the array again to verify that it stays reversed.
        Debug.Log("Array weekDays after the call to ChangeArray:");
        DisplayArray(weekDays);        

        // Assign new values to individual array elements.
        ChangeArrayElements(weekDays);
        // Display the array again to verify that it has changed.
        Debug.Log("Array weekDays after the call to ChangeArrayElements:");
        DisplayArray(weekDays);
    }

    void TestArrays13()
    {
        int[,] theArray = { { 1, 2 }, { 2, 3 }, { 3, 4 } };
        Print2DArray(theArray);
        // 새 배열을 초기화하고 전달
        Print2DArray(new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } });
    }

    void Print2DArray(int[,] arr)
    {
        // Display the array elements.
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                Debug.Log($"Element({i},{j})={arr[i, j]}");
            }
        }
    }

    void TestArrays14()
    {
        // 암시적으로 형식화된 배열
        var a = new[] { 1, 10, 100, 1000 }; // int[]
        var b = new[] { "hello", null, "world" }; // string[]

        // single-dimension jagged array
        var c = new[]
        {
            new[]{1,2,3,4},
            new[]{5,6,7,8}
        };

        // jagged array of strings
        var d = new[]
        {
            new[]{"Luca", "Mads", "Luke", "Dinesh"},
            new[]{"Karen", "Suma", "Frances"}
        };

        // 개체 이니셜라이저의 암시적으로 형식화된 배열
        var contacts = new[]
        {
            new {
                Name = " Eugene Zabokritski",
                PhoneNumbers = new[] { "206-555-0108", "425-555-0001" }
            },
            new {
                Name = " Hanying Feng",
                PhoneNumbers = new[] { "650-555-0199" }
            }
        };
    }
}
