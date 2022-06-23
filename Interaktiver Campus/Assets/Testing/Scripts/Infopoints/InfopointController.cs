using System.Net.Sockets;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfopointController : MonoBehaviour
{

    public GameObject[] Points;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void activateInfopoint(string Tag)
    {
        Points = GameObject.FindGameObjectsWithTag(Tag);

        

        foreach (GameObject go in Points)
        {
        
            bool off = go.GetComponent<Animator>().GetBool("OFF");

            if (go.GetComponent<Animator>().GetBool("OFF") == true)
            {
                go.GetComponent<Animator>().SetBool("OFF", false);
            }
            else if (go.GetComponent<Animator>().GetBool("OFF") == false)
            {
                go.GetComponent<Animator>().SetBool("OFF", true);
            }
            
        }
    }
}
