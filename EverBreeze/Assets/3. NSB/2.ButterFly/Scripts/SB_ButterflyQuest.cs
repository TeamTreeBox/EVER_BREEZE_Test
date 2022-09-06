using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Newtonsoft.Json.Bson;

public class SB_ButterflyQuest : MonoBehaviour
{
    public GameObject[] Inbutterfly;
    public int touchCount=0;


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {   
       


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ButterFly" && other.GetComponent<ButterflyAI>().catchpossible == true && other.GetComponent<ButterflyAI>().rest == true)
        {

            if (touchCount < Inbutterfly.Length)
            {
                Inbutterfly[touchCount].SetActive(true);
            }



        }


    }
}
