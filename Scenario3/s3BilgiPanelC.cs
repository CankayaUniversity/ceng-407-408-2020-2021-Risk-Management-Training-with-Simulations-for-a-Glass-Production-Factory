using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class s3BilgiPanelC : MonoBehaviour
{
    private TextMeshProUGUI infoText;
    private bool triggerred;
    private int flag = 0;



    public int olasılıkNumarası = 0;

    bool finished;
    void Start()
    {
        infoText = GameObject.Find("Canvas/Panel2/Text").GetComponent<TextMeshProUGUI>();
        infoText.fontSize = 40f;
        infoText.text = "3. Senaryoya Hoşgeldiniz !\nBu senaryoda büyük ve küçük camları kendi depolama alanlarına yerleştireceğiz.";
        triggerred = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (olasılıkNumarası == 1)//yanlıs camı yanlıs yere koyarsa
        {
            infoText.text = "Bu camı boyutu uygun olan bölüme koyduğundan emin ol!";
            triggerred = true;
            olasılıkNumarası = 0;
        }
        if (olasılıkNumarası == 2)//cam kırılırsa
        {
            infoText.text = "Cam kırıldı!\n Yaralanma olmaması için temizlik görevlileri çağrılması gerekiyor!";
            triggerred = true;
            olasılıkNumarası = 0;
        }
        if (olasılıkNumarası == 4)//temizlik aşamasında
        {
            infoText.text = "Kırılan Cam Temizleniyor!";
            triggerred = true;
            flag = 4;
            olasılıkNumarası = 0;
        }
        if (olasılıkNumarası == 3)//temizlikçiler gittikten sonra
        {
            infoText.text = "Tebrikler!\nBu senaryoyu başarılı bir şekilde tamamlayarak camların yerleştirilme düzeni ve cam kırılması durumunda alınacak önlemler senaryosu başarıyla tamamlandı!";
            triggerred = true;
            flag = 3;
            olasılıkNumarası = 0;
        }




        if (triggerred == true)
        { //yukardakilerden biri olduysa

            StartCoroutine(WaitBeforeShow());
            finished = true;
            triggerred = false;
        }
    }

    /*public void gecti()
    {

        infoText.text = "Tebrikler !\n Bütün törpüsüz camları başarılı bir şekilde sonraki aşama için törpülediniz. ";
        flag = 2;
        StartCoroutine(WaitBeforeShow());


    }*/


    IEnumerator WaitBeforeShow()
    {
        float wait = 10f;
        this.gameObject.GetComponent<Image>().color = new Color32(255, 135, 0, 120);
        infoText.gameObject.SetActive(true);
        if (flag == 4)
        {
            wait = 15f;
            flag = 0;
        }
        yield return new WaitForSeconds(wait);
        this.gameObject.GetComponent<Image>().color = new Color32(0, 0, 0, 0);
        infoText.gameObject.SetActive(false);
        if (flag == 3) SceneManager.LoadScene("BitisMenu");
        //if (flag == 3) SceneManager.LoadScene("Scenerio1");
    }
}
