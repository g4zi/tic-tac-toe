using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class butonlar : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI mesaj;
    public NewBehaviourScript newBehaviourScript;

    private void Start()
    {

        mesaj.text = "1. Oyuncu";

    }
    public void tiklama()
    {
        if (this.gameObject.GetComponentInChildren<TextMeshProUGUI>().text == " ")
            if (newBehaviourScript.sirakimde == false)
            {
                newBehaviourScript.sirakimde = true;
                this.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = "X";
                mesaj.text = "2. Oyuncu";
                gameObject.GetComponent<Image>().color=Color.red;
                newBehaviourScript.kontrol();

            }
            else if (newBehaviourScript.sirakimde == true)
            {
                newBehaviourScript.sirakimde = false;
                this.gameObject.GetComponentInChildren<TextMeshProUGUI>().text = "O";
                mesaj.text = "1. Oyuncu";
                gameObject.GetComponent<Image>().color=Color.green;
                 newBehaviourScript.kontrol();

            }
    }
    
}
