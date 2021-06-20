using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camkiranController : MonoBehaviour
{
    public GameObject temizlikci1;
    public GameObject temizlikci2;
    public GameObject bPanel;
    public GameObject butonPanel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "kirilanCam")
        {
            bPanel.GetComponent<s3BilgiPanelC>().olasılıkNumarası = 2;
            butonPanel.SetActive(true);
        }
    }

    
    public void temizlikciCagir()
    {
        temizlikci1.SetActive(true);
        temizlikci2.SetActive(true);
        butonPanel.SetActive(false);
    }
}
