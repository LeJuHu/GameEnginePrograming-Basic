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
        // �迭 ����
        int[] array = new int[5];
        string[] stringArray = new string[6];

        // �迭 �ʱ�ȭ
        int[] array1 = new int[] { 1, 3, 5, 7, 9 };
        string[] weekDays = new string[] { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        // �Ͻ������� ����ȭ�� �迭
        int[] array2 = { 1, 3, 5, 7, 9 };
        string[] weekDays2 = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };
        // �迭 ������ ������ �ʰ� ������ �� ������ �� ������ �� �迭�� �Ҵ��� ���� new �����ڸ� ����ؾ� �մϴ�.
        int[] array3;
        array3 = new int[] { 1, 3, 5, 7, 9 };   // OK
        //array3 = {1, 3, 5, 7, 9};   // Error

        // �� ���� �� ���� ���� �迭
        SomeType[] array4 = new SomeType[10];
        // �� ���� ����� SomeType�� �� �������� �Ǵ� ���� ���������� ���� �޶����ϴ�.
        // �� ������ ��� �� ���� ���� SomeType ������ 10�� ����� �迭�� ����ϴ�.
        // SomeType�� ���� ������ ��� �� ���� ���� null ������ �ʱ�ȭ�� 10�� ����� �迭�� ����ϴ�.
        // �� �ν��Ͻ� ��ο��� ��Ұ� ��� ���Ŀ� ���� �⺻������ �ʱ�ȭ�˴ϴ�. 
    }

    void TestArrays03()
    {
        // �ε����� ����Ͽ� �迭�� �����͸� �˻��� �� �ֽ��ϴ�.
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
        // ������ �迭 ����    
        int[,] array = new int[4, 2];
        int[,,] array1 = new int[4, 2, 3];

        // ������ �迭 �ʱ�ȭ
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
        // ������ �������� �ʰ� �迭�� �ʱ�ȭ
        int[,] array4 = { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };

        // �ʱ�ȭ���� �ʰ� �迭 ������ �����ϵ��� ������ ��� new �����ڸ� ����Ͽ� ������ �迭�� �Ҵ�
        int[,] array5;
        array5 = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };   // OK
        //array5 = {{1,2}, {3,4}, {5,6}, {7,8}};   // Error

        // �迭 ��� �Ҵ�
        array5[2, 1] = 25;
        // Ư�� �迭 ����� ���� ������ elementValue ������ �Ҵ�
        int elementValue = array5[2, 1];
        // �迭 ��Ҹ� �⺻ ������ �ʱ�ȭ
        int[,] array6 = new int[10, 10];
    }

    void TestArrays07()
    {
        //  ���� ������ 1���� �迭(���� �迭)�� 3���� �����ϴ� 1���� �迭�� ����
        int[][] jaggedArray = new int[3][];

        // �ʱ�ȭ
        jaggedArray[0] = new int[5];
        jaggedArray[1] = new int[4];
        jaggedArray[2] = new int[2];
        // �̴ϼȶ������� ����Ͽ� �ʱ�ȭ �� �Ҵ�
        jaggedArray[0] = new int[] { 1, 3, 5, 7, 9 };
        jaggedArray[1] = new int[] { 0, 2, 4, 6 };
        jaggedArray[2] = new int[] { 11, 22 };
        // ���� �� �迭�� �ʱ�ȭ
        int[][] jaggedArray2 = new int[][]
        {
            new int[] { 1, 3, 5, 7, 9 },
            new int[] { 0, 2, 4, 6 },
            new int[] { 11, 22 }
        };
        // ��� ����
        // ��ҿ� ���� �⺻ �ʱ�ȭ�� �����Ƿ� ��� �ʱ�ȭ���� new �����ڸ� ������ �� �����ϴ�.
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

        // ���� �迭�� ������ �迭�� �Բ� ����� �� �ֽ��ϴ�.
        int[][,] jaggedArray4 = new int[3][,]
        {
            new int[,] { {1,3}, {5,7} },
            new int[,] { {0,2}, {4,6}, {8,10} },
            new int[,] { {11,22}, {99,88}, {0,9} }
        };

        // ���� ��ҿ� �׼���
        //Debug.Log($"{jaggedArray4[0][1, 0]}");
        Debug.Log(string.Format("{0}", jaggedArray4[0][1, 0]));
        // �迭 ���� ��ȯ
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
        // 1���� �迭�� ��� foreach ���� �ε��� 0���� �����ϰ�
        // �ε��� Length - 1�� ������ �þ�� �ε��� ������ ��Ҹ� ó���մϴ�.
        int[] numbers = { 4, 5, 6, 1, 2, 3, -2, -1, 0 };
        foreach (int i in numbers)
        {
            Debug.Log(i);
        }
        // Output: 4 5 6 1 2 3 -2 -1 0

        // ������ �迭�� ��� ��Ҵ� ���� ������ ������ �ε����� ���� ������ ����,
        // ���� ���� ������ �ε���, �״��� ���� ������ �ε����� �����ϴ� ������� Ʈ�������˴ϴ�.
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
        //  �� �迭�� �ʱ�ȭ�ϰ� ����
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
        // �� �迭�� �ʱ�ȭ�ϰ� ����
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
        // �Ͻ������� ����ȭ�� �迭
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

        // ��ü �̴ϼȶ������� �Ͻ������� ����ȭ�� �迭
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
