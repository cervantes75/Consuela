using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeItAppear : MonoBehaviour
{
    public GameObject MyPrefab;
    public Transform newPosition;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            Instantiate(MyPrefab, newPosition.position, Quaternion.identity);
        }
    }
}
