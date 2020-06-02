using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MakeItAppear : MonoBehaviour
{
    public GameObject MyPrefab;
    public Transform ButtonContainer;
    public void Abracadabra()
    {
       
            GameObject go = (Instantiate(MyPrefab)) as GameObject;
            go.transform.SetParent(ButtonContainer);

        
    }
}
