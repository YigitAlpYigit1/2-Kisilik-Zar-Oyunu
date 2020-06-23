using System;
using UnityEngine;
using UnityEngine.UI;

public class TekrarKodu : MonoBehaviour
{
    [SerializeField]
    GameObject[] zar = new GameObject[6];

    [SerializeField]
    GameObject kapat;

    [SerializeField]
    GameObject eklenecek;

    [SerializeField]
    GameObject eklenecek2;

    [SerializeField]
    GameObject[] kapanacaklar = new GameObject[2];

    [SerializeField]
    GameObject[] aktif = new GameObject[8];

    Color color = new Color();
    Color color2 = new Color();

    System.Random rastgele = new System.Random();

    public Sprite[] resim = new Sprite[6];
    public Sprite[] resim2 = new Sprite[6];

    int atananBir = 0;
    int atananIki = 0;
    int atananUc = 0;
    int atananDort = 0;
    int atananBes = 0;
    int atananAlti = 0;

    int atananBir2 = 0;
    int atananIki2 = 0;
    int atananUc2 = 0;
    int atananDort2 = 0;
    int atananBes2 = 0;
    int atananAlti2 = 0;

    public void Basildi()
    {
        string htmlValue = "#FFFFFF";
        ColorUtility.TryParseHtmlString(htmlValue, out color);

        string htmlValue2 = "#A2D9A9";
        ColorUtility.TryParseHtmlString(htmlValue2, out color2);

        if (zar[0].GetComponent<Button>().interactable == false &&
            zar[1].GetComponent<Button>().interactable == false &&
            zar[2].GetComponent<Button>().interactable == false &&
            zar[3].GetComponent<Button>().interactable == false &&
            zar[4].GetComponent<Button>().interactable == false &&
            zar[5].GetComponent<Button>().interactable == false)
        {
            for (int k = 0; k < 6; k++)
            {
                zar[k].GetComponent<Button>().interactable = true;
                zar[k].GetComponent<Image>().color = color;
                int sayi = rastgele.Next(0, 6);

                zar[k].GetComponent<Image>().overrideSprite = resim[sayi];
                zar[k].GetComponentInChildren<Text>().text = Convert.ToString(sayi + 1);

            }
        }

        else
        {
            for (int k = 0; k < 6; k++)
            {
                if (zar[k].GetComponent<Image>().color == color || zar[k].GetComponent<Image>().color == color2)
                {
                    zar[k].GetComponent<Image>().color = color;

                    int sayi = rastgele.Next(0, 6);

                    zar[k].GetComponent<Image>().overrideSprite = resim[sayi];
                    zar[k].GetComponentInChildren<Text>().text = Convert.ToString(sayi + 1);
                }
            }
        }

        AtananSayiKontrol();
        kapat.GetComponent<Button>().interactable = false;
    }

    void AtananSayiKontrol()
    {
        for (int k = 0; k < 6; k++)
        {
            if (zar[k].GetComponent<Button>().interactable == true)
            {
                for (int i = 1; i < 7; i++)
                {
                    if (zar[k].GetComponentInChildren<Text>().text == Convert.ToString(i))
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
        }

        if (atananBir < 1 && atananIki < 3 && atananUc < 3 && atananDort < 3 && atananBes < 1 && atananAlti < 3)
        {
            for (int i = 0; i < 6; i++)
            {
                zar[i].GetComponent<Button>().interactable = false;
            }

            for (int i = 0; i < 2; i++)
            {
                kapanacaklar[i].GetComponent<Button>().interactable = false;
            }

            for (int i = 0; i < 8; i++)
            {
                aktif[i].GetComponent<Button>().interactable = true;

                if (i > 1)
                {
                    aktif[i].GetComponent<Image>().color = color;

                    int sayi = rastgele.Next(0, 6);
                    aktif[i].GetComponent<Image>().overrideSprite = resim2[sayi];
                    aktif[i].GetComponentInChildren<Text>().text = Convert.ToString(sayi + 1);

                }
            }

            //for (int i = 0; i < 8; i++)
            //{
            //    aktif[i].GetComponent<Button>().interactable = true;
            //    if (i > 1)
            //    {
            //        aktif[i].GetComponent<Image>().color = color;
            //    }
            //}
            //aktif[2].GetComponent<Image>().overrideSprite = resim2[1];
            //aktif[3].GetComponent<Image>().overrideSprite = resim2[1];
            //aktif[4].GetComponent<Image>().overrideSprite = resim2[2];
            //aktif[5].GetComponent<Image>().overrideSprite = resim2[2];
            //aktif[6].GetComponent<Image>().overrideSprite = resim2[3];
            //aktif[7].GetComponent<Image>().overrideSprite = resim2[3];

            //aktif[2].GetComponentInChildren<Text>().text = Convert.ToString(2);
            //aktif[3].GetComponentInChildren<Text>().text = Convert.ToString(2);
            //aktif[4].GetComponentInChildren<Text>().text = Convert.ToString(3);
            //aktif[5].GetComponentInChildren<Text>().text = Convert.ToString(3);
            //aktif[6].GetComponentInChildren<Text>().text = Convert.ToString(4);
            //aktif[7].GetComponentInChildren<Text>().text = Convert.ToString(4);

            eklenecek.GetComponentInChildren<Text>().text = "İFLAS";
            eklenecek2.GetComponentInChildren<Text>().text = Convert.ToString(0);

            ikinciAtananKontrol();
        }

        atananAlti = atananBes = atananDort = atananUc = atananIki = atananBir = 0;
    }

    void ikinciAtananKontrol()
    {
        for (int k = 2; k < 8; k++)
        {
            if (aktif[k].GetComponent<Button>().interactable == true)
            {
                for (int i = 1; i < 7; i++)
                {
                    if (aktif[k].GetComponentInChildren<Text>().text == Convert.ToString(i))
                    {
                        if (i == 1)
                            atananBir2++;
                        else if (i == 2)
                            atananIki2++;
                        else if (i == 3)
                            atananUc2++;
                        else if (i == 4)
                            atananDort2++;
                        else if (i == 5)
                            atananBes2++;
                        else
                            atananAlti2++;
                    }
                }
            }
        }

        if (atananBir2 < 1 && atananIki2 < 3 && atananUc2 < 3 && atananDort2 < 3 && atananBes2 < 1 && atananAlti2 < 3)
        {
            for (int i = 0; i < 8; i++)
            {
                aktif[i].GetComponent<Button>().interactable = false;
            }

            for (int i = 0; i < 2; i++)
            {
                kapanacaklar[i].GetComponent<Button>().interactable = true;
            }

            zar[0].GetComponent<Button>().interactable = true;
            zar[0].GetComponent<Image>().color = color;
            zar[0].GetComponent<Image>().overrideSprite = resim[0];
            zar[0].GetComponentInChildren<Text>().text = Convert.ToString(1);

            for (int i = 1; i < 6; i++)
            {
                zar[i].GetComponent<Button>().interactable = true;

                zar[i].GetComponent<Image>().color = color;

                int sayi = rastgele.Next(0, 6);
                zar[i].GetComponent<Image>().overrideSprite = resim[sayi];
                zar[i].GetComponentInChildren<Text>().text = Convert.ToString(sayi + 1);

            }
            eklenecek2.GetComponentInChildren<Text>().text = "İFLAS";
            eklenecek.GetComponentInChildren<Text>().text = Convert.ToString(0);
        }
        atananAlti2 = atananBes2 = atananDort2 = atananUc2 = atananIki2 = atananBir2 = 0;
    }
}

