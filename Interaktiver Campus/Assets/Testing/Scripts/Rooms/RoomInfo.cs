 using System.Net.Mime;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;
using UnityEngine.Localization.Components;
public class RoomInfo : MonoBehaviour
{
    // Start is called before the first frame update

    public string RoomID;

    //public string RoomType;

    //public string Capacity;

    private bool roombool = false;

    private Canvas RoomInfos;
    
    

    public string Raumtyp;

    public string Kapazität;

    private Transform Info;

    



    
 
    

    void Start()
    {
        RoomInfos = gameObject.transform.GetChild(0).transform.GetChild(0).GetComponent<Canvas>();

        // Set Roominfos
        Info = gameObject.transform.GetChild(0).GetChild(0).GetChild(0);

        Info.Find("Raumname").GetComponent<TextMeshProUGUI>().text = RoomID;

        Info.Find("Typ").GetComponent<LocalizeStringEvent>().StringReference.SetReference("RoomInformation", Raumtyp.ToString());

        Info.Find("Kapa").GetComponent<TextMeshProUGUI>().text = Kapazität;

        Info.Find("Stockwerk").GetComponent<TextMeshProUGUI>().text = RoomID.Substring(3,1);



    }

    // Show Roominfos when room is active
    IEnumerator ExampleCroutine()
    {
        //Debug.Log("start");

        RoomInfos.enabled = false;

        yield return new WaitForSeconds(1);

        //Debug.Log("end");
        RoomInfos.enabled = true;

    }
    void Update()
    {
        if(gameObject.transform.GetChild(0).gameObject.activeSelf && roombool == false)
        {
            StartCoroutine(ExampleCroutine());

            roombool = true;
        }
        else if(!gameObject.transform.GetChild(0).gameObject.activeSelf && roombool)
        {
            roombool = false;
        }
    }
    
    


}
