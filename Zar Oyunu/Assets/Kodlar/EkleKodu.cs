using System;
using UnityEngine;
using UnityEngine.UI;

public class EkleKodu : MonoBehaviour
{
    [SerializeField]
    GameObject[] zar = new GameObject[6];

    [SerializeField]
    GameObject ekle;

    [SerializeField]
    GameObject ekle2;

    public Sprite[] resim = new Sprite[6];
    public Sprite[] resim2 = new Sprite[6];
    System.Random rastgele = new System.Random();

    [SerializeField]
    GameObject[] kapanacaklar = new GameObject[3];

    [SerializeField]
    GameObject[] aktif = new GameObject[8];

    Color color = new Color();
    Color color2 = new Color();

    int bir = 0;
    int iki = 0;
    int uc = 0;
    int dort = 0;
    int bes = 0;
    int alti = 0;

    int atananBir = 0;
    int atananIki = 0;
    int atananUc = 0;
    int atananDort = 0;
    int atananBes = 0;
    int atananAlti = 0;

    public void Basildi()
    {
        SayiKontrol();
        Hesaplama();
        AtananSayiKontrol();
    }
    void SayiKontrol()
    {
        string htmlValue = "#A2D9A9";
        ColorUtility.TryParseHtmlString(htmlValue, out color);

        for (int k = 0; k < 6; k++)
        {
            if (zar[k].GetComponent<Image>().color == color)
            {
                for (int i = 1; i <= 6; i++)
                {
                    if (Convert.ToInt32(zar[k].GetComponentInChildren<Text>().text) == i)
                    {

                        if (i == 1)
                            bir++;
                        else if (i == 2)
                            iki++;
                        else if (i == 3)
                            uc++;
                        else if (i == 4)
                            dort++;
                        else if (i == 5)
                            bes++;
                        else
                            alti++;

                    }
                    string htmlValue2 = "#A2D9A8";
                    ColorUtility.TryParseHtmlString(htmlValue2, out color2);
                    zar[k].GetComponent<Image>().color = color2;

                    zar[k].GetComponent<Button>().interactable = false;
                }
            }
        }
    }
    void Hesaplama()
    {
        int tut = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);

        int sayac = bir + iki + uc + dort + bes + alti;

        if (sayac == 6)
        {
            if (bir == 6 || iki == 6 || uc == 6 || dort == 6 || bes == 6 || alti == 6)
            {
                for (int i = 1; i < 7; i++)
                {
                    if (i == 1 && bir == 6)
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 4000;
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                    else if ((i == 2 && iki == 6) || (i == 3 && uc == 6) || (i == 4 && dort == 6) || (i == 6 && alti == 6))
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + (i * 400);
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                    else if (i == 5 && bes == 6)
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 3000;
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                }
            }
            else if (bir == 1 && iki == 1 && uc == 1 && dort == 1 && bes == 1 && alti == 1)
            {
                int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                a = a + 3500;
                ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
            }
            else if (bir == 3)
            {
                for (int i = 2; i < 7; i++)
                {
                    if ((i == 2 && iki == 3) || (i == 3 && uc == 3) || (i == 4 && dort == 3) || (i == 6 && alti == 3))
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 1000 + (i * 100);
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                    else if (i == 5 && bes == 3)
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 1750;
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                }
            }
            else if (bes == 3)
            {
                for (int i = 2; i < 7; i++)
                {
                    if ((i == 2 && iki == 3) || (i == 3 && uc == 3) || (i == 4 && dort == 3) || (i == 6 && alti == 3))
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 750 + (i * 100);
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                }
            }
            else if (iki == 3)
            {
                for (int i = 3; i < 7; i++)
                {
                    if ((i == 3 && uc == 3) || (i == 4 && dort == 3) || (i == 6 && alti == 3))
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 200 + (i * 100);
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                }
            }
            else if (uc == 3)
            {
                for (int i = 4; i < 7; i++)
                {
                    if ((i == 4 && dort == 3) || (i == 6 && alti == 3))
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 300 + (i * 100);
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                }
            }
            else if (dort == 3 && alti == 3)
            {
                int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                a = a + 1000;
                ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
            }
            else if (bir == 2)
            {
                if (iki == 1 && uc == 1 && dort == 1 && bes == 1)
                {
                    int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                    a = a + 2350;
                    ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                }
                else if (bes == 1)
                {
                    for (int i = 2; i < 7; i++)
                    {
                        if ((i == 2 && iki == 3) || (i == 3 && uc == 3) || (i == 4 && dort == 3) || (i == 6 && alti == 3))
                        {
                            int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                            a = a + 250 + (i * 100);
                            ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                        }
                    }
                }
                else
                {
                    for (int i = 2; i < 7; i++)
                    {
                        if ((i == 2 && iki == 4) || (i == 3 && uc == 4) || (i == 4 && dort == 4) || (i == 6 && alti == 4))
                        {
                            int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                            a = a + 200 + (i * 150);
                            ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                        }
                        else if (i == 5 && bes == 4)
                        {
                            int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                            a = a + 1400;
                            ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                        }
                    }
                }
            }
            else if (bes == 2)
            {
                if (iki == 1 && uc == 1 && dort == 1 && bir == 1)
                {
                    int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                    a = a + 2300;
                    ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                }
                else if (iki == 1 && uc == 1 && dort == 1 && alti == 1)
                {
                    int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                    a = a + 2300;
                    ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                }
                else if (bir == 1)
                {
                    for (int i = 2; i < 7; i++)
                    {
                        if ((i == 2 && iki == 3) || (i == 3 && uc == 3) || (i == 4 && dort == 3) || (i == 6 && alti == 3))
                        {
                            int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                            a = a + 200 + (i * 100);
                            ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                        }
                    }
                }
                else
                {
                    for (int i = 1; i < 7; i++)
                    {
                        if ((i == 2 && iki == 4) || (i == 3 && uc == 4) || (i == 4 && dort == 4) || (i == 6 && alti == 4))
                        {
                            int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                            a = a + 100 + (i * 150);
                            ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                        }
                        else if (i == 1 && bir == 4)
                        {
                            int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                            a = a + 1600;
                            ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                        }
                    }
                }
            }
            else if (bir == 1)
            {
                for (int i = 2; i < 7; i++)
                {
                    if ((i == 2 && iki == 5) || (i == 3 && uc == 5) || (i == 4 && dort == 5) || (i == 6 && alti == 5))
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 100 + (i * 225);
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                    else if(bes==1)
                    {
                        if ((i == 2 && iki == 4) || (i == 3 && uc == 4) || (i == 4 && dort == 4) || (i == 6 && alti == 4))
                        {
                            int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                            a = a + 150 + (i * 150);
                            ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                        }
                    }
                    else if (i == 5 && bes == 5)
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 2100;
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                }
            }
            else if (bes == 1)
            {
                for (int i = 1; i < 7; i++)
                {
                    if ((i == 2 && iki == 5) || (i == 3 && uc == 5) || (i == 4 && dort == 5) || (i == 6 && alti == 5))
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 50 + (i * 225);
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                    else if (i == 1 && bir == 5)
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 2550;
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                }
            }
        }

        else if (sayac == 5)
        {
            if (bir == 5 || iki == 5 || uc == 5 || dort == 5 || bes == 5 || alti == 5)
            {
                for (int i = 1; i < 7; i++)
                {
                    if (i == 1 && bir == 5)
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 2500;
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                    else if (i == 5 && bes == 5)
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 2000;
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                    else if ((i == 2 && iki == 5) || (i == 3 && uc == 5) || (i == 4 && dort == 5) || (i == 6 && alti == 5))
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + (i * 225);
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                }
            }
            else if (bir == 1 && iki == 1 && uc == 1 && dort == 1 && bes == 1)
            {
                int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                a = a + 2250;
                ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
            }
            else if (iki == 1 && uc == 1 && dort == 1 && bes == 1 && alti == 1)
            {
                int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                a = a + 2250;
                ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
            }
            else if (bir == 2)
            {
                for (int i = 2; i < 7; i++)
                {
                    if ((i == 2 && iki == 3) || (i == 3 && uc == 3) || (i == 4 && dort == 3) || (i == 6 && alti == 3))
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 200 + (i * 100);
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                    else if (i == 5 && bes == 3)
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 950;
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                }
            }
            else if (bes == 2)
            {
                for (int i = 1; i < 7; i++)
                {
                    if ((i == 2 && iki == 3) || (i == 3 && uc == 3) || (i == 4 && dort == 3) || (i == 6 && alti == 3))
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 100 + (i * 100);
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                    else if (i == 1 && bir == 3)
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 1100;
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                }
            }
            else if (bir == 1)
            {
                for (int i = 2; i < 7; i++)
                {
                    if ((i == 2 && iki == 4) || (i == 3 && uc == 4) || (i == 4 && dort == 4) || (i == 6 && alti == 4))
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 100 + (i * 150);
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                    else if(((i == 2 && iki == 3) || (i == 3 && uc == 3) || (i == 4 && dort == 3) || (i == 6 && alti == 3))&& bes==1)
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 150 + (i*100);
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                    else if (i == 5 && bes == 4)
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 1250;
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                }
            }
            else if (bes == 1)
            {
                for (int i = 1; i < 7; i++)
                {
                    if ((i == 2 && iki == 4) || (i == 3 && uc == 4) || (i == 4 && dort == 4) || (i == 6 && alti == 4))
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 50 + (i * 150);
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                    else if (i == 1 && bir == 4)
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 1550;
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                }
            }
        }

        else if (sayac == 4)
        {
            if (bir == 4 || iki == 4 || uc == 4 || dort == 4 || bes == 4 || alti == 4)
            {
                for (int i = 1; i < 7; i++)
                {
                    if (i == 1 && bir == 4)
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 1500;
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                    else if (i == 5 && bes == 4)
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 1200;
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                    else if ((i == 2 && iki == 4) || (i == 3 && uc == 4) || (i == 4 && dort == 4) || (i == 6 && alti == 4))
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + (i * 150);
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                }
            }
            else if (bir == 1)
            {
                for (int i = 2; i < 7; i++)
                {
                    if ((i == 2 && iki == 3) || (i == 3 && uc == 3) || (i == 4 && dort == 3) || (i == 6 && alti == 3))
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 100 + (i * 100);
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                    else if (i == 5 && bes == 3)
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 850;
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                }
            }
            else if (bes == 1)
            {
                for (int i = 1; i < 7; i++)
                {
                    if ((i == 2 && iki == 3) || (i == 3 && uc == 3) || (i == 4 && dort == 3) || (i == 6 && alti == 3))
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 50 + (i * 100);
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                    else if (i == 1 && bir == 3)
                    {
                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + 1050;
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                }
            }
            else if (bir == 2 && bes == 2)
            {
                int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                a = a + 300;
                ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
            }
        }

        else if (sayac == 3)
        {
            if (bir == 3)
            {
                int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                a = a + 1000;
                ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
            }
            else if (bes == 3)
            {
                int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                a = a + 750;
                ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
            }
            else if (bir == 1 && bes == 2)
            {
                int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                a = a + 200;
                ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
            }
            else if (bir == 2 && bes == 1)
            {
                int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                a = a + 250;
                ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
            }
            else if (iki == 3 || uc == 3 || dort == 3 || alti == 3)
            {
                for (int i = 2; i < 7; i++)
                {
                    if ((i == 2 && iki == 3) || (i == 3 && uc == 3) || (i == 4 && dort == 3) || (i == 6 && alti == 3))
                    {

                        int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                        a = a + (i * 100);
                        ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
                    }
                }
            }
        }

        else if (sayac == 2)
        {
            if (bir == 2)
            {
                int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                a = a + 200;
                ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
            }
            else if (bes == 2)
            {
                int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                a = a + 100;
                ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
            }
            else if (bir == 1 && bes == 1)
            {
                int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                a = a + 150;
                ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
            }
        }

        else if (sayac == 1)
        {
            if (bir == 1)
            {
                int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                a = a + 100;
                ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
            }
            else if (bes == 1)
            {
                int a = Convert.ToInt32(ekle.GetComponentInChildren<Text>().text);
                a = a + 50;
                ekle.GetComponentInChildren<Text>().text = Convert.ToString(a);
            }
        }

        if (tut == Convert.ToInt32(ekle.GetComponentInChildren<Text>().text))
        {
            Gecersiz();
        }

        if (ekle.GetComponentInChildren<Text>().text != Convert.ToString("İFLAS"))
            kapanacaklar[0].GetComponent<Button>().interactable = true;

        sayac = 0;
        bir = iki = uc = dort = bes = alti = 0;

    }
    void Gecersiz()
    {
        ekle.GetComponentInChildren<Text>().text = "İFLAS";
        ekle2.GetComponentInChildren<Text>().text = Convert.ToString(0);
        for (int i = 0; i < 3; i++)
        {
            kapanacaklar[i].GetComponent<Button>().interactable = false;
        }
        for (int i = 0; i < 6; i++)
        {
            zar[i].GetComponent<Button>().interactable = false;
        }
        for (int i = 0; i < 8; i++)
        {
            if (i > 1)
            {
                Color color3 = new Color();
                string htmlValue = "#FFFFFF";
                ColorUtility.TryParseHtmlString(htmlValue, out color3);
                aktif[i].GetComponent<Image>().color = color3;

                int sayi = rastgele.Next(0, 6);

                aktif[i].GetComponent<Image>().overrideSprite = resim2[sayi];
                aktif[i].GetComponentInChildren<Text>().text = Convert.ToString(sayi + 1);

            }
            aktif[i].GetComponent<Button>().interactable = true;
        }
    }
    void AtananSayiKontrol()
    {
        if (aktif[1].GetComponent<Button>().interactable != false)
        {
            Color color3 = new Color();
            string htmlValue = "#FFFFFF";
            ColorUtility.TryParseHtmlString(htmlValue, out color3);

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
                        else if (i == 6)
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

                kapanacaklar[0].GetComponent<Button>().interactable = false;
                kapanacaklar[1].GetComponent<Button>().interactable = true;
                kapanacaklar[2].GetComponent<Button>().interactable = true;

                zar[0].GetComponent<Button>().interactable = true;
                zar[0].GetComponent<Image>().color = color3;
                zar[0].GetComponent<Image>().overrideSprite = resim[0];
                zar[0].GetComponentInChildren<Text>().text = Convert.ToString(0 + 1);

                for (int i = 1; i < 6; i++)
                {
                    zar[i].GetComponent<Button>().interactable = true;
                    zar[i].GetComponent<Image>().color = color3;

                    int sayi = rastgele.Next(0, 6);
                    zar[i].GetComponent<Image>().overrideSprite = resim[sayi];
                    zar[i].GetComponentInChildren<Text>().text = Convert.ToString(sayi + 1);
                }

                ekle.GetComponentInChildren<Text>().text = Convert.ToString(0);
                ekle2.GetComponentInChildren<Text>().text = "İFLAS";
            }
        }
        atananAlti = atananBes = atananDort = atananUc = atananIki = atananBir = 0;
    }
}
