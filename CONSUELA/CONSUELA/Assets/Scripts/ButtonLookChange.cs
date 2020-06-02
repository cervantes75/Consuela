using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonLookChange : MonoBehaviour
{
    public Sprite OffSprite;
    public Sprite OnSprite;
    public Button but;
    public void ChangeImage()
    {
        if (but.GetComponent<Image>().sprite == OnSprite)
            but.GetComponent<Image>().sprite = OffSprite;
        else
        {
            but.GetComponent<Image>().sprite = OnSprite;
        }
    }
}
