using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class bilgilendirmePanelController : MonoBehaviour
{
    private TextMeshProUGUI infoText;
    private GameObject panel;
    private bool triggerred = false;

    public int olasılıkNumarası = 0;
    int flag=-1;
    void Start()
    {
        infoText = GameObject.Find("Canvas/Panel (1)/Text").GetComponent<TextMeshProUGUI>();
        infoText.fontSize = 50f;
        infoText.text = "Simülasyona Hoşgeldiniz !\n İlk senaryoya başlamak için bulundugunuz odadaki butona basınız.";
        triggerred = true;

    }

    void Update()
    {
        basKocum();
        //Debug.Log(triggerred + " ve " + olasılıkNumarası);
    }

    private void basKocum()
    {
        
       
        if (olasılıkNumarası == 1 && triggerred == false)//butona bastıktan sınraki text
        {
            //Debug.Log(olasılıkNumarası);
            olasılıkNumarası = -1;
            triggerred = true;

            infoText.fontSize = 35f;
            infoText.text = "1. senaryoyu başarılı bir şekilde tamamlayabilmek için koruyucu ekipmanlarınızı giymiş olmalısınız.\n Kapıya dogru ilerleyin ve fabrikaya giriş yapın";

        }
        else if (olasılıkNumarası == 2 && triggerred == false)//eldiven kask giyip bitirdi
        {
            //Debug.Log(olasılıkNumarası);
            flag = 2;
            olasılıkNumarası = -1;
            triggerred = true;
            infoText.fontSize = 35f;
            infoText.text = "Tebrikler! \n İlk senaryoyu başarılı bir şekilde tamamladınız. ";

          
        }
        else if (olasılıkNumarası == 3 && triggerred == false) //eldiven kask giymedi
        {
            //Debug.Log(olasılıkNumarası);
            flag = 3;
            olasılıkNumarası = -1;
            triggerred = true;
            infoText.fontSize = 30f;
            infoText.text = "İlk senaryoyu başarılı bir şekilde tamamlayamadınız.\n Bilgilendirme: \n 1. Ellerinizi keskin kenarlardan, yüksek sıcaklıklardan, zararlı kimyasallardan ve diğer tehlikelerden korumak için koruycu eldivenler kullanmalısınız. \n 2. Baretler başı, vurmalara karşı, yukarıdan düşen objelere karşı, düşme sonucunda vurmalara karşı korur.  ";
        }
        else
        { /*Debug.Log(olasılıkNumarası + "else'deyiz");*/ }

        if (triggerred == true)
        { //yukardakilerden biri olduysa

            StartCoroutine(WaitBeforeShow());
            
            triggerred = false;
        }
        
    }

    

    IEnumerator WaitBeforeShow()
    {
        this.gameObject.GetComponent<Image>().color = new Color32(255, 135, 0, 170);
        infoText.gameObject.SetActive(true);
        yield return new WaitForSeconds(10f);
        this.gameObject.GetComponent<Image>().color = new Color32(0, 0, 0, 0);
        infoText.gameObject.SetActive(false);
        if (flag == 2) SceneManager.LoadScene("Scenerio2");
        if (flag == 3) SceneManager.LoadScene("Scenerio1");
    }


}
