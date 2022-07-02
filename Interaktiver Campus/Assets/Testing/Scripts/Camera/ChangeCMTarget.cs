using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ChangeCMTarget : MonoBehaviour
{
    Cinemachine.CinemachineFreeLook c_VirtualCamera;
    
    [SerializeField] Transform Basetarget;
 
    void Awake()
    {
       c_VirtualCamera = GetComponent<Cinemachine.CinemachineFreeLook>();
    }
    public void ChangeCameraTarget(Transform target)
    {
        c_VirtualCamera.m_LookAt = target.transform;
        c_VirtualCamera.m_Follow = target.transform;

    }

    public void ResetCameraTarget()
    {
        c_VirtualCamera.m_LookAt = Basetarget.transform;
        c_VirtualCamera.m_Follow = Basetarget.transform;
    }
}
