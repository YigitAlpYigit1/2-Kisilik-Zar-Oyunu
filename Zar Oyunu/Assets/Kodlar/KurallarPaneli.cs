using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KurallarPaneli : MonoBehaviour
{
    [SerializeField]
    GameObject panel;

    bool a = false;
    public void Basildi()
    {
        if (a == false)
        {
            panel.SetActive(true);
            a = true;
        }
        else
        {
            panel.SetActive(false);
            a = false;
        }
    }
}
