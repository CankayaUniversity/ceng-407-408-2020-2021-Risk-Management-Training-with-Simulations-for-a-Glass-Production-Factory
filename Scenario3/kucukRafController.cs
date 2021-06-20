using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kucukRafController : MonoBehaviour
{
    public GameObject yesilPanel;
    public GameObject bPanel;
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.tag.Equals("kucukCam"))
        {
            //panel çıksın
            //bu bölmeye küçük cam ölçülerinde cam koyunuz
            if (!other.gameObject.tag.Equals("Untagged"))
            {
                Debug.Log("kücük cam koy");
                bPanel.GetComponent<s3BilgiPanelC>().olasılıkNumarası = 1;
            }
        }
        else
        {
            yesilPanel.GetComponent<s3panelController>().kücükcamSayısı++;
            other.gameObject.tag = "Untagged";
        }
    }
}
