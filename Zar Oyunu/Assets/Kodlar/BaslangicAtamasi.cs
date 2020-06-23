using System;
using UnityEngine;
using UnityEngine.UI;

public class BaslangicAtamasi : MonoBehaviour
{
    [SerializeField]
    GameObject[] kapanacaklar = new GameObject[10];

    [SerializeField]
    GameObject[] zarAtama = new GameObject[12];

    public Sprite[] resim = new Sprite[6];
    public Sprite[] resim2 = new Sprite[6];

    System.Random rastgele = new System.Random();

    void Start()
    {
        Screen.SetResolution(450, 800, false);
        ilkAtama();
        Kapatma();
    }
    
    void Kapatma()
    {
        for(int i=0;i<10;i++)
        {
            kapanacaklar[i].GetComponent<Button>().interactable = false;
        }
    }

    void ilkAtama()
    {
        for (int i = 0; i < 12; i++)
        {
            int sayi = rastgele.Next(0, 6);
            if (i<6)
            {
                zarAtama[i].GetComponent<Image>().overrideSprite = resim[sayi];
                zarAtama[i].GetComponentInChildren<Text>().text = Convert.ToString(sayi + 1);
            }
            else
            {
                zarAtama[i].GetComponent<Image>().overrideSprite = resim2[sayi];
                zarAtama[i].GetComponentInChildren<Text>().text = Convert.ToString(sayi + 1);
            }

            zarAtama[0].GetComponent<Image>().overrideSprite = resim[0];
            zarAtama[0].GetComponentInChildren<Text>().text = Convert.ToString(1);
            zarAtama[6].GetComponent<Image>().overrideSprite = resim2[0];
            zarAtama[6].GetComponentInChildren<Text>().text = Convert.ToString(1);
        }
    }
}
