using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class spawnObjectUnder : MonoBehaviour
{
    public GameObject obj2Spawn;
    public Sprite[] objSprite;
    public Transform parent;

    public void SummonThee()
    {
        obj2Spawn.transform.SetParent(null);
        GameObject newObject = Instantiate(obj2Spawn);

    }
}
