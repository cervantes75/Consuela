using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textCreate : MonoBehaviour
{
    public GameObject sampleObject;
    public Transform ButtonContainer;
    public bool instantiateInWorldSpace = false;
    List<GameObject> noteList;

    void Start()
    {
        Vector3 localScale = sampleObject.transform.localScale;
        noteList = new List<GameObject>();

    }
    public void AddObject()
    {
        var Y = (noteList.Count * -18);
        GameObject go = Instantiate(sampleObject, new Vector3(0, Y, 0), Quaternion.identity);
        go.transform.SetParent(this.transform, false);
        noteList.Add(go);

    }
}
