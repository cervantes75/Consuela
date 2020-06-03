using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyNstuff : MonoBehaviour
{
    [SerializeField]
    GameObject object2destroy;

    public void DestroyObject()
    {
        Destroy(object2destroy);
    }
}
