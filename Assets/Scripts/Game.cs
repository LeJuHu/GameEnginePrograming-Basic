using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{
    void Start()
    {
        string str = "Happy";
        int num = 123;
        string message = str + num;

        Debug.Log(message);
    }
}
