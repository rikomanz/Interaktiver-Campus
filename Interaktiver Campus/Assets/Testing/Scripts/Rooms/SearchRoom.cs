using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SearchRoom : MonoBehaviour
{
    // Start is called before the first frame update
    
    public GameObject InputField;

    public string[] rooms;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void GetInput()
    {
        var Input = InputField.GetComponent<InputField>();

        Debug.Log(Input.text);

       

        var groundValue  = GameObject.Find("Raumliste").GetComponent<CSVReader>().myRaumliste.räume;




        Debug.Log(groundValue);

    

    }
}
