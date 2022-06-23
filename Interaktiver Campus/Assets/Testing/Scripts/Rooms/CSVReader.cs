using System.Linq.Expressions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Linq;

public class CSVReader : MonoBehaviour
{

    public TextAsset RaumlisteCSV;

    [System.Serializable]

    public class Raum
    {
        public string Bezeichnung;
        public string Gebäude;
        public string Kapazität;
        public string Fakultät;
         public string Typ;
    }

    [System.Serializable]

    public class Raumliste
    {
        public Raum[] räume;
    }

    public Raumliste myRaumliste = new Raumliste();

    public GameObject InputField;

    public List<string> rooms = new List<string>();
    
    // Start is called before the first frame update
    void Start()
    {
        ReadCSVFile();
    }

    // Update is called once per frame
    void ReadCSVFile()
    {
    
       string[] data = RaumlisteCSV.text.Split(new String[] {",","\n",";"}, StringSplitOptions.None);
       
       //data = data.Skip(1).ToArray();
       
       int size = data.Length / 4 -1;

       myRaumliste.räume = new Raum[size];

       //foreach ( var x in data) Debug.Log(x);

       for(int i = 0; i < size; i++)
       {
           myRaumliste.räume[i] = new Raum();
           myRaumliste.räume[i].Bezeichnung = data[4* (i+1)];
           myRaumliste.räume[i].Gebäude = data[4* (i+1)].Substring(0,2);
           myRaumliste.räume[i].Kapazität = data[4* (i+1) +1];
           myRaumliste.räume[i].Fakultät = data[4* (i+1) +2];
           myRaumliste.räume[i].Typ = data[4* (i+1) +3];
       }

        for(int i = 0; i < size; i++)
        {
            rooms.Add(myRaumliste.räume[i].Bezeichnung);
        }

        foreach ( var x in rooms)
        {
            Debug.Log(x.ToString());
        }

    }

    public void GetInput()
    {

        var Input = InputField.GetComponent<InputField>();

        

        //foreach ( var x in myRaumliste.räume) Debug.Log(x);


    }




}
