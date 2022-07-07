using System.Dynamic;
using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfopointHover : MonoBehaviour
{

    public Color imgColor = new Color ();

    public Color HoverColor = new Color ();
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    public void Hover()
    {
        gameObject.transform.GetChild(0).GetComponent<Image>().color = HoverColor;

        //Debug.Log("Detected Hover");
    }

    public void ClearHover()
    {
        gameObject.transform.GetChild(0).GetComponent<Image>().color = imgColor;
    }
}
