using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using Newtonsoft.Json.Bson;

public class SB_ButterflyQuest : MonoBehaviour
{
    public GameObject[] Inbutterfly;
    public int touchCount=0;
    public GameObject capA;
    public GameObject capB;

    // Start is called before the first frame update
    void Start()
    {
        capB.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
           if (touchCount == 3)
        {
            capA.SetActive(false);
            capB.SetActive(true);
        }


    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "ButterFly"  && other.GetComponent<ButterflyAI>().rest == true)
        {

            if (touchCount < Inbutterfly.Length)
            {
                Inbutterfly[touchCount].SetActive(true);
            }
        


        }


    }
}
