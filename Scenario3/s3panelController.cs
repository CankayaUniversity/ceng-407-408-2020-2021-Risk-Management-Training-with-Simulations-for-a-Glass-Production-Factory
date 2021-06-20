using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class s3panelController : MonoBehaviour
{
    private TextMeshProUGUI infoText;
    private bool triggerred = false;

    public GameObject bPanel;
    public int kücükcamSayısı = 0;
    public int büyükcamSayısı = 0;
    private void Start()
    {
        infoText = GameObject.Find("Canvas/Panel/Text").GetComponent<TextMeshProUGUI>();

    }


    void Update()
    {


        infoText.text = " Yerleştirilen Büyük Cam Sayısı : " + (büyükcamSayısı) + "/3"+"\n"
                        + " Yerleştirilen Küçük Cam Sayısı : " + (kücükcamSayısı) + " / 3"+"\n";

        if (bPanel.GetComponent<s3BilgiPanelC>().olasılıkNumarası == 2) this.gameObject.SetActive(false);

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
