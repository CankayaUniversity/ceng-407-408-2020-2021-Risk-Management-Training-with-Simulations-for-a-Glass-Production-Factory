using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class temizlikciKaybol : MonoBehaviour
{
    public GameObject bPanel;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "temizlikci")
        {
            bPanel.GetComponent<s3BilgiPanelC>().olasılıkNumarası = 3;
            other.gameObject.SetActive(false);
        }
    }
}
