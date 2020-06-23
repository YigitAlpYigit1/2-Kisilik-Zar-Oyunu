using System;
using UnityEngine;
using UnityEngine.UI;
public class TekrarOynamaKodu : MonoBehaviour
{
    [SerializeField]
    GameObject[] kapanacaklar = new GameObject[14];

    [SerializeField]
    GameObject[] aktif = new GameObject[2];

    [SerializeField]
    GameObject[] zarAtama = new GameObject[12];

    [SerializeField]
    GameObject[] skorSifirla = new GameObject[2];

    public Sprite[] resim = new Sprite[6];
    public Sprite[] resim2 = new Sprite[6];

    System.Random rastgele = new System.Random();

    Color color = new Color();

    public void Basildi()
    {
        ilkAtama();
        Kapatma();
    }
    void Kapatma()
    {
        for (int i = 0; i < 14; i++)
        {
            if (i < 10)
                kapanacaklar[i].GetComponent<Button>().interactable = false;
            else
                kapanacaklar[i].SetActive(false);
        }
    }
    void ilkAtama()
    {
        for(int i=0;i<2;i++)
        {
            aktif[i].GetComponent<Button>().interactable = true;
            skorSifirla[i].GetComponentInChildren<Text>().text = Convert.ToString(0);
        }

        for (int i = 0; i < 12; i++)
        {
            string htmlValue = "#FFFFFF";
            ColorUtility.TryParseHtmlString(htmlValue, out color);

            zarAtama[i].GetComponent<Image>().color = color;

            int sayi = rastgele.Next(0, 6);
            if (i < 6)
            {
                zarAtama[i].GetComponent<Button>().interactable = true;
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

