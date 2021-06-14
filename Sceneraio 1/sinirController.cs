using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sinirController : MonoBehaviour
{


    private GameObject panel;
    private GameObject panel1;

    private void Start()
    {
        panel = GameObject.FindGameObjectWithTag("Panel");
        panel1 = GameObject.FindGameObjectWithTag("Panel1");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "char_head")
        {
            if(panel.GetComponent<panelConroller>().taskNumber==3) //3 taskı'da yaptıysa
            {
                panel1.GetComponent<bilgilendirmePanelController>().olasılıkNumarası = 2;
            }
            else
            {
                panel1.GetComponent<bilgilendirmePanelController>().olasılıkNumarası = 3;
            }
        }
    }


}
