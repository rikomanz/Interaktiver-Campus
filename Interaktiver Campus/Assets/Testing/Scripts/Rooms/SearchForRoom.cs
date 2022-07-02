using System;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SearchForRoom : MonoBehaviour
{

    public Button Child;

    public bool RoomActive;

    public HotspotCMController CMC;

    int[ ] Buildings = { 0, 70, 51, 92, 65, 50, 87, 53, 54 };

    public GameObject [] HotspotLabels;
 




    
    // Start is called before the first frame update
    void Start()
    {
       // Debug.Log(Buildings[2]);
    }


    

    // Update is called once per frame
    public void checkRoom()
    {
        var Input = GameObject.Find("InputField").GetComponent<InputField>();

        GameObject[] rooms = GameObject.FindGameObjectsWithTag("Room");

        Child.gameObject.SetActive(false);

        RoomActive = true;

        foreach(GameObject room in rooms)
        {

            string id = room.GetComponent<RoomInfo>().RoomID;


            // Check if room exists
            if (Input.text == id)

            {
                
                // Activate Room
                room.transform.GetChild(0).gameObject.SetActive(true);

                // Show Breadcrumb Child with RoomID
                Child.gameObject.SetActive(true);
                
                Child.GetComponentInChildren<TextMeshProUGUI>().text +=  Input.text;

                Debug.Log(room.transform.GetChild(0).name);

                Debug.Log(Child.gameObject.activeSelf);

                // Convert RoomID in AnimationIndex for HotspotCMController
                int positionInArray = System.Array.IndexOf(Buildings, int.Parse(id.Substring(0,2)));

                HotspotLabels[positionInArray - 1].gameObject.GetComponent<Toggle>().isOn = true;

                if (positionInArray != GameObject.Find("CM StateDrivenCamera1").GetComponent<Animator>().GetInteger("AnimationIndex"))
                {
                    CMC.SetCMIndex(positionInArray);
                }

                // Sets the room as the active target for the camera
                ChangeCMTarget[] cams = FindObjectsOfType<ChangeCMTarget>();
                
                foreach ( ChangeCMTarget cam in cams)
                {
                    cam.ChangeCameraTarget(room.transform);
                }
    

            }

            else
            {
                // Deactivate other rooms
                room.transform.GetChild(0).gameObject.SetActive(false);
            }
        }


        


        RoomActive = false;
    }
}
