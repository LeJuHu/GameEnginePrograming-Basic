using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleFormation : MonoBehaviour
{
    public GameObject cubePrefab; // 큐브 프리팹
    public int numCubes = 10; // 생성할 큐브 개수
    public float radius = 5.0f; // 원의 반지름

    // Start is called before the first frame update
    void Start()
    {
        // 큐브 오브젝트들을 원 모양으로 배치
        for (int i = 0; i < numCubes; i++)
        {
            float angle = i * Mathf.PI * 2 / numCubes;
            Vector3 pos = new Vector3(Mathf.Cos(angle), 0, Mathf.Sin(angle)) * radius;
            GameObject cube = Instantiate(cubePrefab, pos, Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}