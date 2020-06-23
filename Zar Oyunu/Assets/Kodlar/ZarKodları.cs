using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ZarKodları : MonoBehaviour
{
    [SerializeField]
    GameObject zar;

    Color color = new Color();

    public void Basildi()
    {
        string htmlValue = "#A2D9A9";
        ColorUtility.TryParseHtmlString(htmlValue, out color);

        if(zar.GetComponent<Image>().color != color)
            zar.GetComponent<Image>().color = color;
        else
        {
            string htmlValue2 = "#FFFFFF";
            ColorUtility.TryParseHtmlString(htmlValue2, out color);
            zar.GetComponent<Image>().color = color;
        }
    }
}
