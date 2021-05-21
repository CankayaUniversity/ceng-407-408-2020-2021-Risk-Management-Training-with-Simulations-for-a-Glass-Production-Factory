using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class panelConroller : MonoBehaviour
{
    private TextMeshProUGUI infoText;


    public bool isEntered = false;
    public int isBothGloves = 0;
    public bool isHelmet = false;

    private bool triggerred = false;
    private void Start()
    {
        infoText = GameObject.Find("Canvas/Panel/Text").GetComponent<TextMeshProUGUI>();
        infoText.text = "Fabrikaya Giriş Yapıldı ";
        triggerred=true;
    }

    // Update is called once per frame
    void Update()
    {
        if (isEntered){ //girişteki aletten kart basıldıysa
            infoText.text = "Kart Basıldı ";
            triggerred = true;
            isEntered = false;
        }
        if (isBothGloves==2){ //2 eldiven de giyildiyse
            infoText.text = "Eldivenler Giyildi ";
            triggerred = true;
            isBothGloves = 0;
        }
        if (isHelmet){ // Kask giyildiyse
            infoText.text = "Kask Giyildi";
            triggerred = true;
            isHelmet = false;
        }
        if (triggerred==true){ //yukardakilerden biri olduysa
            StartCoroutine(WaitBeforeShow());
            triggerred = false;
        }
    }

    IEnumerator WaitBeforeShow()
    {
        this.gameObject.GetComponent<Image>().color = new Color32(0, 210, 0, 125);
        infoText.gameObject.SetActive(true);
        yield return new WaitForSeconds(5f);
        infoText.gameObject.SetActive(false);
        this.gameObject.GetComponent<Image>().color = new Color32(0,0,0,125);
    }
}
