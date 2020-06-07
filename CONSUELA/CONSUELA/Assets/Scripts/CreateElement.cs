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
        GameObject go = Instantiate(sampleObject, Vector3.zero, Quaternion.identity) as GameObject;
        go.transform.SetParent(ButtonContainer, false);
        if (go.scene.IsValid())
        {
            go.transform.position = transform.position + new Vector3(0, 200, 0);
        }
        else
        {
            go.transform.position = transform.position;
        }
       
       
        
    }
}
