using UnityEngine;
using Cinemachine;
using System;

public class CameraPrototypeController : MonoBehaviour
{

    [Range(-1,2)]
    public int mouseButtonIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        CinemachineCore.GetInputAxis = GetAxisCustom;
    }

    // Update is called once per frame
    private float GetAxisCustom(string axisName)
    {
        if (mouseButtonIndex ==-1 || Input.GetMouseButton(mouseButtonIndex))
        {
            return Input.GetAxis(axisName);
        }
        else
        {
            return 0;
        }
    }
}
