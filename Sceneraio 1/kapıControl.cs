using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kapıControl : MonoBehaviour
{


    public GameObject door1,door2;

    bool playerIsHere;
    bool opening;

    private double open1 = -0.162;
    private double close1 = 0.438;

    private double open2 = 1.621;
    private double close2 = 1.065;


    // Start is called before the first frame update
    void Start()
    {
        playerIsHere = false;
        opening = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (playerIsHere)
        {
            Debug.Log("girdik");
            if (door1.transform.position.z > open1)
            {
                door1.transform.Translate(0f, 0f, -0.5f * Time.deltaTime);
            }
            if (door2.transform.position.z < open2)
            {
                door2.transform.Translate(0f, 0f, +0.5f * Time.deltaTime);
            }
        }
        else
        {
       
            if (door1.transform.position.z < close1)
            {
                Debug.Log("kapa"+ door1.transform.position.z);
                door1.transform.Translate(0f, 0f, +0.5f * Time.deltaTime);
            }
            if (door2.transform.position.z > close2)
            {
                door2.transform.Translate(0f, 0f, -0.5f * Time.deltaTime);
            }
        }

    }

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "char_head")
        {
            playerIsHere = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.tag == "char_head")
        {
            playerIsHere = false;
        }
    }



}
