using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kaskController : MonoBehaviour
{

    private GameObject panel;

    private void Start()
    {
        panel = GameObject.FindGameObjectWithTag("Panel");
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("char_head"))
        {
            Destroy(this.gameObject);
            panel.GetComponent<panelConroller>().isHelmet = true;
        }
    }
}
