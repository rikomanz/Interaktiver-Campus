
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class ChangeCMTarget : MonoBehaviour
{
    Cinemachine.CinemachineFreeLook c_VirtualCamera;
    
    [SerializeField] Transform Basetarget;

    Vector3 Baseposition;

    private float lerp = 0 , duration = 1;
 
    void Awake()
    {
       c_VirtualCamera = GetComponent<Cinemachine.CinemachineFreeLook>();
    }

    void Start()
    {
        Baseposition = Basetarget.position;
    }
    
    public void ChangeCameraTarget(Transform positionToMoveTo)
    {
        StartCoroutine(LerpPosition(positionToMoveTo.position, 1));
    }
    public IEnumerator LerpPosition(Vector3 targetPosition, float duration)
    {
        float time = 0;
        Vector3 startPosition = Basetarget.transform.position;
        while (time < duration)
        {
            c_VirtualCamera.m_LookAt.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            c_VirtualCamera.m_Follow.position = Vector3.Lerp(startPosition, targetPosition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        //transform.position = targetPosition;
    }

    //public void ChangeCameraTarget(Transform target)
    //{
        //c_VirtualCamera.m_LookAt = target.transform;
        //c_VirtualCamera.m_Follow = target.transform;


        
        //lerp += Time.deltaTime / duration;
        //c_VirtualCamera.m_LookAt.position =  Vector3.Lerp(Basetarget.position, target.position, lerp);

            

    //}

    public void ResetCameraTarget()
    {
        //c_VirtualCamera.m_LookAt.position = Baseposition;
        //c_VirtualCamera.m_Follow.position = Baseposition;

        Debug.Log("reset cams");
        Debug.Log(Basetarget.position);

        StartCoroutine(LerpPositionReset(Basetarget.position, 1));
    }
    public IEnumerator LerpPositionReset(Vector3 targetPosition, float duration)
    {
        float time = 0;
        Vector3 startPosition = c_VirtualCamera.m_LookAt.position;
        while (time < duration)
        {
            c_VirtualCamera.m_LookAt.position = Vector3.Lerp(startPosition, Baseposition, time / duration);
            c_VirtualCamera.m_Follow.position = Vector3.Lerp(startPosition, Baseposition, time / duration);
            time += Time.deltaTime;
            yield return null;
        }
        transform.position = targetPosition;
        
    }

    public void Update()
    {
       
    }
}
