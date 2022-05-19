using System.Reflection;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HotspotCMController : MonoBehaviour
{

    public GameObject[] hotspots;

    public GameObject[] panels;

    public Animator animator;

    public GameObject InfoPanel;
    
    // Start is called before the first frame update
    void Start()
    {

    }


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


    public void SetCMIndex(int index)
    {

        var aniIndex = animator.GetInteger("AnimationIndex");
     
     if(aniIndex == 0)
     {
         animator.SetInteger("AnimationIndex", index);
     }
     else
     {
         animator.SetInteger("AnimationIndex", 0);
     }
        

    if(!InfoPanel.activeSelf)
    {
        InfoPanel.SetActive(true);
    }
    else
    {
        InfoPanel.SetActive(false);
    }

    }


    public void ShowInfoText()
    {
        var aniIndex = animator.GetInteger("AnimationIndex");

        if(!panels[aniIndex].activeSelf)
        {
            panels[aniIndex].SetActive(true);
        }
        else
        {
            panels[aniIndex].SetActive(false);
        }
    }
}
