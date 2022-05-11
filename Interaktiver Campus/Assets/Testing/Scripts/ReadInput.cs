using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReadInput : MonoBehaviour
{
    private string input;

    public string [] rooms;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ReadStringInput( string s)
    {
        input = s;
        //Debug.Log(input);

        foreach (string x in rooms)
        {
            if (x.Equals (input))
            {
                Debug.Log(input);
            }
        }
    }

}
