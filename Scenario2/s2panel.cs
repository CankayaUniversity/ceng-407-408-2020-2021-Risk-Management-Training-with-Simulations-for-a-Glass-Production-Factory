using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class s2panel : MonoBehaviour
{
    private TextMeshProUGUI infoText;
    private bool triggerred = false;

    public int camSayısı = 6;
    private void Start()
    {
        infoText = GameObject.Find("Canvas/Panel/Text").GetComponent<TextMeshProUGUI>();

    }


    void Update()
    {


        infoText.text = " Törpulenen Cam Sayısı : " + (6 - camSayısı) + "/6";

        /*
        if (triggerred == true)
        { //yukardakilerden biri olduysa
            StartCoroutine(WaitBeforeShow());
            triggerred = false;
        }*/
    }
    /*

    IEnumerator WaitBeforeShow()
    {
        this.gameObject.GetComponent<Image>().color = new Color32(0, 210, 0, 125);
        infoText.gameObject.SetActive(true);
        yield return new WaitForSeconds(5f);
        infoText.gameObject.SetActive(false);
        this.gameObject.GetComponent<Image>().color = new Color32(0, 0, 0, 125);
    }*/
}
