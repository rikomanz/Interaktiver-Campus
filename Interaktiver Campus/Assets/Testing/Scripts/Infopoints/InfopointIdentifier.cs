using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfopointIdentifier : MonoBehaviour
{
    // Start is called before the first frame update

    public int InfopointIndex;

    public Material[] Labels = new Material[4];

    public Material[] Colors = new Material[4];

    void Start()
    {
        gameObject.transform.Find("Infopoint_Label").GetComponent<Renderer>().material = Labels[InfopointIndex];
        gameObject.transform.Find("Infopoint_Label_01").GetComponent<Renderer>().material = Labels[InfopointIndex];

        gameObject.transform.Find("Infopoint_Mesh").GetComponent<Renderer>().material = Colors[InfopointIndex];



        if (InfopointIndex == 0)
        {
            gameObject.tag = "Infopoint Entrance";
        }
        else if (InfopointIndex == 1)
        {
            gameObject.tag = "Infopoint Parking";
        }
        else if (InfopointIndex == 2)
        {
            gameObject.tag = "Infopoint WC";
        }
        else if (InfopointIndex == 3)
        {
            gameObject.tag = "Infopoint Bus stop";
        }

        //transform.GetChild(0).gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
