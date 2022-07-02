using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Breadcrump : MonoBehaviour
{

    public Button Child;

    // Start is called before the first frame update
    void Start()
    {
        foreach (Transform child in transform)

        {
            child.GetChild(0).gameObject.SetActive(false);
        }
    }

    void UpdateCameraTarget()
    {
        ChangeCMTarget[] cams = FindObjectsOfType<ChangeCMTarget>();
                
        foreach ( ChangeCMTarget cam in cams)
        {
            cam.ResetCameraTarget();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DeactivateRoom()
    {
        foreach (Transform child in transform)

        {
            child.GetChild(0).gameObject.SetActive(false);
        }


        Child.gameObject.SetActive(false);

        UpdateCameraTarget();
    }
}
