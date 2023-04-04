using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    public TextMeshProUGUI mesaj1;
    public bool sirakimde;
    public GameObject[] butonlar;

    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < butonlar.Length; i++)
        {
            butonlar[i].GetComponentInChildren<TextMeshProUGUI>().text = " ";
        }
        //sirakimde = false;

    }
    public void kontrol()
    {
        // Kazanma kombinasyonları
        int[,] kazanmaKombinasyonlari = new int[,]
        {
        {0,1,2}, {3,4,5}, {6,7,8}, // Yatay kombinasyonlar
        {0,3,6}, {1,4,7}, {2,5,8}, // Dikey kombinasyonlar
        {0,4,8}, {2,4,6} // Çapraz kombinasyonlar
        };

        // Oyuncuların sembolleri
        string[] semboller = new string[] { "X", "O" };

        // Her bir oyuncunun sembolü için
        for (int i = 0; i < semboller.Length; i++)
        {
            // Kazanma kombinasyonlarını kontrol et
            for (int j = 0; j < kazanmaKombinasyonlari.GetLength(0); j++)
            {
                // Eğer bu kombinasyon oyuncunun sembolü ile dolu ise
                if (butonlar[kazanmaKombinasyonlari[j, 0]].GetComponentInChildren<TextMeshProUGUI>().text == semboller[i] &&
                    butonlar[kazanmaKombinasyonlari[j, 1]].GetComponentInChildren<TextMeshProUGUI>().text == semboller[i] &&
                    butonlar[kazanmaKombinasyonlari[j, 2]].GetComponentInChildren<TextMeshProUGUI>().text == semboller[i])
                {
                    // Kazananı belirle
                    string kazanan = (i == 0) ? "1" : "2";
                    mesaj1.text = kazanan + " Kazandı";
                    return; // Fonksiyondan çık
                }
            }
        }
    }

   /* public void kontrol1()
    {
        if (butonlar[0].GetComponentInChildren<TextMeshProUGUI>().text == "X" &&
        butonlar[1].GetComponentInChildren<TextMeshProUGUI>().text == "X" &&
        butonlar[2].GetComponentInChildren<TextMeshProUGUI>().text == "X"
        )
        {
            mesaj1.text = "1 Kazandı";


        }
        else if (butonlar[0].GetComponentInChildren<TextMeshProUGUI>().text == "X" &&
        butonlar[4].GetComponentInChildren<TextMeshProUGUI>().text == "X" &&
        butonlar[8].GetComponentInChildren<TextMeshProUGUI>().text == "X"
        )
        {
            mesaj1.text = "1 Kazandı";


        }
        else if (butonlar[0].GetComponentInChildren<TextMeshProUGUI>().text == "X" &&
        butonlar[3].GetComponentInChildren<TextMeshProUGUI>().text == "X" &&
        butonlar[6].GetComponentInChildren<TextMeshProUGUI>().text == "X"
        )
        {
            mesaj1.text = "1 Kazandı";

        }
        else if (butonlar[1].GetComponentInChildren<TextMeshProUGUI>().text == "X" &&
        butonlar[4].GetComponentInChildren<TextMeshProUGUI>().text == "X" &&
        butonlar[7].GetComponentInChildren<TextMeshProUGUI>().text == "X"
        )
        {
            mesaj1.text = "1 Kazandı";


        }
        else if (butonlar[2].GetComponentInChildren<TextMeshProUGUI>().text == "X" &&
        butonlar[5].GetComponentInChildren<TextMeshProUGUI>().text == "X" &&
        butonlar[8].GetComponentInChildren<TextMeshProUGUI>().text == "X"
        )
        {
            mesaj1.text = "1 Kazandı";


        }
        else if (butonlar[2].GetComponentInChildren<TextMeshProUGUI>().text == "X" &&
        butonlar[4].GetComponentInChildren<TextMeshProUGUI>().text == "X" &&
        butonlar[6].GetComponentInChildren<TextMeshProUGUI>().text == "X"
        )
        {
            mesaj1.text = "1 Kazandı";


        }
        else if (butonlar[3].GetComponentInChildren<TextMeshProUGUI>().text == "X" &&
        butonlar[4].GetComponentInChildren<TextMeshProUGUI>().text == "X" &&
        butonlar[5].GetComponentInChildren<TextMeshProUGUI>().text == "X"
        )
        {
            mesaj1.text = "1 Kazandı";


        }
        else if (butonlar[6].GetComponentInChildren<TextMeshProUGUI>().text == "X" &&
        butonlar[7].GetComponentInChildren<TextMeshProUGUI>().text == "X" &&
        butonlar[8].GetComponentInChildren<TextMeshProUGUI>().text == "X"
        )
        {
            mesaj1.text = "1 Kazandı";


        }
        // o kazanma



        else if (butonlar[0].GetComponentInChildren<TextMeshProUGUI>().text == "O" &&
        butonlar[1].GetComponentInChildren<TextMeshProUGUI>().text == "O" &&
        butonlar[2].GetComponentInChildren<TextMeshProUGUI>().text == "O"
        )
        {
            mesaj1.text = "2 Kazandı";


        }
        else if (butonlar[0].GetComponentInChildren<TextMeshProUGUI>().text == "O" &&
        butonlar[4].GetComponentInChildren<TextMeshProUGUI>().text == "O" &&
        butonlar[8].GetComponentInChildren<TextMeshProUGUI>().text == "O"
        )
        {
            mesaj1.text = "2 Kazandı";


        }
        else if (butonlar[0].GetComponentInChildren<TextMeshProUGUI>().text == "O" &&
        butonlar[3].GetComponentInChildren<TextMeshProUGUI>().text == "O" &&
        butonlar[6].GetComponentInChildren<TextMeshProUGUI>().text == "O"
        )
        {
            mesaj1.text = "2 Kazandı";

        }
        else if (butonlar[1].GetComponentInChildren<TextMeshProUGUI>().text == "O" &&
        butonlar[4].GetComponentInChildren<TextMeshProUGUI>().text == "O" &&
        butonlar[7].GetComponentInChildren<TextMeshProUGUI>().text == "O"
        )
        {
            mesaj1.text = "2 Kazandı";


        }
        else if (butonlar[2].GetComponentInChildren<TextMeshProUGUI>().text == "O" &&
        butonlar[5].GetComponentInChildren<TextMeshProUGUI>().text == "O" &&
        butonlar[8].GetComponentInChildren<TextMeshProUGUI>().text == "O"
        )
        {
            mesaj1.text = "2 Kazandı";


        }
        else if (butonlar[2].GetComponentInChildren<TextMeshProUGUI>().text == "O" &&
        butonlar[4].GetComponentInChildren<TextMeshProUGUI>().text == "O" &&
        butonlar[6].GetComponentInChildren<TextMeshProUGUI>().text == "O"
        )
        {
            mesaj1.text = "2 Kazandı";


        }
        else if (butonlar[3].GetComponentInChildren<TextMeshProUGUI>().text == "O" &&
       butonlar[4].GetComponentInChildren<TextMeshProUGUI>().text == "O" &&
       butonlar[5].GetComponentInChildren<TextMeshProUGUI>().text == "O"
       )
        {
            mesaj1.text = "2 Kazandı";


        }
        else if (butonlar[6].GetComponentInChildren<TextMeshProUGUI>().text == "O" &&
        butonlar[7].GetComponentInChildren<TextMeshProUGUI>().text == "O" &&
        butonlar[8].GetComponentInChildren<TextMeshProUGUI>().text == "O"
        )
        {
            mesaj1.text = "2 Kazandı";


        }
    } */
}


