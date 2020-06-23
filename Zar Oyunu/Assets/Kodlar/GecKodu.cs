using System;
using System.Collections;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.UI;

public class GecKodu : MonoBehaviour
{
    [SerializeField]
    GameObject[] aktif = new GameObject[8];

    [SerializeField]
    GameObject[] kapat = new GameObject[9];

    [SerializeField]
    GameObject ekle;
    
   [SerializeField]
    GameObject ekle2;

    [SerializeField]
    GameObject skor;

    [SerializeField]
    GameObject[] Son = new GameObject[3];

    public Sprite[] resim = new Sprite[6];
    public Sprite[] resim2 = new Sprite[6];

    Color color = new Color();

    int atananBir = 0;
    int atananIki = 0;
    int atananUc = 0;
    int atananDort = 0;
    int atananBes = 0;
    int atananAlti = 0;

    int rastgele = 0;

    Stopwatch sw = new Stopwatch();

    public void Basildi()
    {
        StartCoroutine(Atama());
    }
    IEnumerator Atama()
    {
        sw.Start();
        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
        a = a + Convert.ToInt32(skor.GetComponentInChildren<Text>().text);
        skor.GetComponentInChildren<Text>().text = Convert.ToString(a);
        ekle.GetComponentInChildren<Text>().text = Convert.ToString(0);
        ekle2.GetComponentInChildren<Text>().text = Convert.ToString(0);

        if (a >= 6000)
        {
            for (int i = 0; i < 3; i++)
            {
                if (i < 2)
                    Son[i].SetActive(true);
                else
                {
                    yield return new WaitForSeconds(3);
                    Son[i].SetActive(true);
                }
            }
        }

        else
        {
            for (int i = 0; i < 9; i++)
            {
                kapat[i].GetComponent<Button>().interactable = false;
            }

            for (int i = 0; i < 8; i++)
            {
                aktif[i].GetComponent<Button>().interactable = true;

                if (i > 1)
                {
                    Color color = new Color();
                    string htmlValue = "#FFFFFF";
                    ColorUtility.TryParseHtmlString(htmlValue, out color);
                    aktif[i].GetComponent<Image>().color = color;

                    rastgele = Convert.ToInt32(sw.Elapsed.TotalMilliseconds * 10000) % 60;

                    int sayi = 0;

                    if (rastgele < 10)
                        sayi = 0;
                    else if (rastgele < 20)
                        sayi = 1;
                    else if (rastgele < 30)
                        sayi = 2;
                    else if (rastgele < 40)
                        sayi = 3;
                    else if (rastgele < 50)
                        sayi = 4;
                    else
                        sayi = 5;

                    aktif[i].GetComponent<Image>().overrideSprite = resim[sayi];
                    aktif[i].GetComponentInChildren<Text>().text = Convert.ToString(sayi + 1);

                }
            }
            AtananSayiKontrol();
        }
        sw.Stop();
    }
    void AtananSayiKontrol()
    {
        string htmlValue = "#FFFFFF";
        ColorUtility.TryParseHtmlString(htmlValue, out color);

        for (int k = 2; k < 8; k++)
        {
            for (int i = 1; i < 7; i++)
            {
                if (aktif[k].GetComponentInChildren<Text>().text == Convert.ToString(i))
                {
                    if (i == 1)
                        atananBir++;
                    else if (i == 2)
                        atananIki++;
                    else if (i == 3)
                        atananUc++;
                    else if (i == 4)
                        atananDort++;
                    else if (i == 5)
                        atananBes++;
                    else
                        atananAlti++;
                }
            }
        }

        if (atananBir < 1 && atananIki < 3 && atananUc < 3 && atananDort < 3 && atananBes < 1 && atananAlti < 3)
        {
            for (int i = 0; i < 8; i++)
            {
                aktif[i].GetComponent<Button>().interactable = false;
            }

            kapat[0].GetComponent<Button>().interactable = false;
            
            for (int i = 1; i < 9; i++)
            {
                kapat[i].GetComponent<Button>().interactable = true;

                if (i > 2)
                {
                    kapat[i].GetComponent<Image>().color = color;

                    rastgele = Convert.ToInt32(sw.Elapsed.TotalMilliseconds * 10000) % 60;
                    int sayi = 0;

                    if (rastgele < 10)
                        sayi = 0;
                    else if (rastgele < 20)
                        sayi = 1;
                    else if (rastgele < 30)
                        sayi = 2;
                    else if (rastgele < 40)
                        sayi = 3;
                    else if (rastgele < 50)
                        sayi = 4;
                    else
                        sayi = 5;

                    kapat[i].GetComponent<Image>().overrideSprite = resim2[sayi];
                    kapat[i].GetComponentInChildren<Text>().text = Convert.ToString(sayi + 1);
                }
            }

            ekle.GetComponentInChildren<Text>().text = Convert.ToString(0);
            ekle2.GetComponentInChildren<Text>().text = "İFLAS";
        }

        atananAlti = atananBes = atananDort = atananUc = atananIki = atananBir = 0;
    }
}
