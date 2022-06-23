using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchForRoom : MonoBehaviour
{

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void checkRoom()
    {
        var Input = GameObject.Find("InputField").GetComponent<InputField>();

        GameObject[] rooms = GameObject.FindGameObjectsWithTag("Room");

    
        foreach(GameObject room in rooms)
        {

            var test = room.GetComponent<RoomInfo>().RoomID;

                if (Input.text == test)
            {
               room.transform.GetChild(0).gameObject.SetActive(true);
            }

            else 
            {
               room.transform.GetChild(0).gameObject.SetActive(false);
            }
        }



    }
}
