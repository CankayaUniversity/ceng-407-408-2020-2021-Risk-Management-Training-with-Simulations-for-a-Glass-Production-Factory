using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class girisButtonController : MonoBehaviour
{

    private GameObject panel;
    private GameObject panel1;

    public GameObject clickSoundObj;
    public AudioClip clickSound;
    static AudioSource audioSrc;

    public GameObject lefthand;
    public GameObject righthand;





    private void Start()
    {
        
        audioSrc = clickSoundObj.GetComponent<AudioSource>();
        panel = GameObject.FindGameObjectWithTag("Panel");
        panel1 = GameObject.FindGameObjectWithTag("Panel1");
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag.Equals("tag1"))
        {
            panel.gameObject.GetComponent<panelConroller>().isEntered = true;
            this.gameObject.GetComponent<Renderer>().material.color = Color.green;
            audioSrc.PlayOneShot(clickSound);

            panel1.GetComponent<bilgilendirmePanelController>().olasılıkNumarası = 1;

            lefthand.GetComponent<BoxCollider>().isTrigger = true;
            righthand.GetComponent<BoxCollider>().isTrigger = true;

        }
    }
    
}
