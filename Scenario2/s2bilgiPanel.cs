using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class s2bilgiPanel : MonoBehaviour
{
    private TextMeshProUGUI infoText;
    public GameObject panelAna;
    private bool triggerred = false;
    private int flag = 0;



    public int olasılıkNumarası = 0;

    bool finished;
    void Start()
    {
        infoText = GameObject.Find("Canvas/Panel2/Text").GetComponent<TextMeshProUGUI>();
        infoText.fontSize = 40f;
        infoText.text = "2. Senaryoya Hoşgeldiniz !\n Bu senaryoda törpüsüz cam için ne yapılması gerektigini öğrenecegiz. Çevresi Kırmızı olan camlar törpüsüz demektir. Onları makinenin turuncu ışıklı tarafına yerleştir ve 5 sn bekle.";
        triggerred = true;

    }

    // Update is called once per frame
    void Update()
    {

        if (panelAna.GetComponent<s2panel>().camSayısı == 0) gecti();

        if (olasılıkNumarası == 1)//zaten zımparalı olan camı koyarsa
        {
            infoText.text = "Bu cam zaten zımparalı. Çevresi kırmızı olan camların zımparalanması gerekiyor!";
            triggerred = true;
            olasılıkNumarası = 0;
        }
 


        if (triggerred == true)
        { //yukardakilerden biri olduysa

            StartCoroutine(WaitBeforeShow());
            finished = true;
            triggerred = false;
        }
    }

    public void gecti()
    {

        infoText.text = "Tebrikler !\n Bütün törpüsüz camları başarılı bir şekilde sonraki aşama için törpülediniz. ";
        flag = 2;
        StartCoroutine(WaitBeforeShow());
       

    }


    IEnumerator WaitBeforeShow()
    {
        this.gameObject.GetComponent<Image>().color = new Color32(255, 135, 0, 120);
        infoText.gameObject.SetActive(true);
        yield return new WaitForSeconds(10f);
        this.gameObject.GetComponent<Image>().color = new Color32(0, 0, 0, 0);
        infoText.gameObject.SetActive(false);
        if (flag == 2) SceneManager.LoadScene("Scenerio3");
        //if (flag == 3) SceneManager.LoadScene("Scenerio1");
    }

}
