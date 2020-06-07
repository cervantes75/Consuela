using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class CreateElement : MonoBehaviour
{
    public GameObject sampleObject;
    public Transform ButtonContainer;
    public bool instantiateInWorldSpace = false;

    void Start()
    {
        Vector3 localScale = sampleObject.transform.localScale;

    }
    public void AddObject()
    {
        GameObject go = new GameObject();

      
        if (go != null)
        {
            go = Instantiate(sampleObject, Vector3.zero, Quaternion.identity);
        }
        else
        {
          go = Instantiate(sampleObject, Vector3.zero, Quaternion.identity);
        }

        go.transform.SetParent(ButtonContainer, false);
        go.transform.position = transform.position;

    }
}
