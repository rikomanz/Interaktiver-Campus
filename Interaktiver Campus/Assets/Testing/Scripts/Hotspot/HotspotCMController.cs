using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class HotspotCMController : MonoBehaviour
{

    public GameObject[] hotspots;

    public GameObject[] panels;

    public Animator animator;

    public GameObject InfoPanel;

    public GameObject InfoTextBackground;

    public Button Parent;

    public GameObject BreadCrumb;

    public SearchForRoom SFR;


    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void UpdateCameraTarget()
    {
        ChangeCMTarget[] cams = FindObjectsOfType<ChangeCMTarget>();
                
        foreach ( ChangeCMTarget cam in cams)
        {
            cam.ResetCameraTarget();
        }
    }

    // Check if panel needs to be disabled
    void Update()
    {
        if(!InfoPanel.activeSelf)
        {
            for(int i = 0; i < panels.Length; i++)
         {
             panels[i].SetActive(false);
         }

         InfoPanel.GetComponent<Toggle>().isOn = false;
        }
    }


    // Enable Background Label
    public void ShowInfoTextBackground()
    {
         
        if(!InfoTextBackground.activeSelf)
        {
            InfoTextBackground.SetActive(true);
        }
        else
        {
            InfoTextBackground.SetActive(false);
        }
    }

    // Set Cinemachine Camera Index
    public void SetCMIndex(int index)
    {

       // Debug.Log(animator.GetInteger("AnimationIndex"));
        var aniIndex = animator.GetInteger("AnimationIndex");

        
     
     if(aniIndex == 0)
     {
         animator.SetInteger("AnimationIndex", index);
     }
     else
     {
         animator.SetInteger("AnimationIndex", 0);
     }
        
    //Debug.Log(animator.GetInteger("AnimationIndex"));

    if(!InfoPanel.activeSelf)
    {
        InfoPanel.SetActive(true);
    }
    else
    {
        InfoPanel.SetActive(false);
    }

    //ShowInfoText();

    setBLDName();
    
    //Debug.Log(animator.GetInteger("AnimationIndex"));

    if(!SFR.RoomActive)
    {
        GameObject[] rooms = GameObject.FindGameObjectsWithTag("Room");

        foreach(GameObject room in rooms)
        {
            room.transform.GetChild(0).gameObject.SetActive(false);
        }


        if(GameObject.Find("ButtonChild"))
        {
            GameObject.Find("ButtonChild").gameObject.SetActive(false);
        }
        
    }

    UpdateCameraTarget();

    }

    // Activate BLD Info Text & Background
    public void ShowInfoText()
    {

        ShowInfoTextBackground();
        
        var aniIndex = animator.GetInteger("AnimationIndex");

        if(!panels[aniIndex].activeSelf && InfoTextBackground.activeSelf)
        {
            for(int i = 0; i < panels.Length; i++)

            {
                panels[i].SetActive(false);
            }
            
            panels[aniIndex].SetActive(true);
        }
        else
        {
            panels[aniIndex].SetActive(false);
        }
    }


    // Set Building name for breadcrumb

    void setBLDName()
    {

        var aniIndex = animator.GetInteger("AnimationIndex");

        if(aniIndex > 0)
        {
            BreadCrumb.SetActive(true);

            Parent.gameObject.SetActive(true);

            Debug.Log(Parent.GetComponentInChildren<TextMeshProUGUI>().text);

            Parent.GetComponentInChildren<TextMeshProUGUI>().text += panels[aniIndex].name.Substring(7,2);

        }
        else
        {
            BreadCrumb.SetActive(false);

            Parent.gameObject.SetActive(false);
        }

    }

    public void resetCM()
    {

        GameObject.Find("HS Toggle Group").GetComponent<ToggleGroup>().SetAllTogglesOff();  

        for(int i = 0; i < panels.Length; i++)

        {
            panels[i].SetActive(false);

        }


        BreadCrumb.SetActive(false);   

        Parent.gameObject.SetActive(false);

        if(GameObject.Find("ButtonChild"))
        
        {
            GameObject.Find("ButtonChild").SetActive(false);
        }

        animator.SetInteger("AnimationIndex", 0);

        UpdateCameraTarget();
    }
    

    
}
