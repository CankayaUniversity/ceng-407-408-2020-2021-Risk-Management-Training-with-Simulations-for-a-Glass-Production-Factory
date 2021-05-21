using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class glovesControl : MonoBehaviour
{

    public GameObject leftHand;
    public GameObject rightHand;

    public Material gloves_Material;


    private GameObject panel;
    private void Start()
    {
        panel = GameObject.FindGameObjectWithTag("Panel");
    }

    public  void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("char_rightHand"))
         {
             rightHand.GetComponent<SkinnedMeshRenderer>().material = gloves_Material;
             Destroy(this.gameObject);
             panel.GetComponent<panelConroller>().isHelmet = true;
        }
         if(other.tag.Equals("char_leftHand"))
         {
             leftHand.GetComponent<SkinnedMeshRenderer>().material = gloves_Material;
             Destroy(this.gameObject);
             panel.GetComponent<panelConroller>().isHelmet = true;
        }
        
    }
}
