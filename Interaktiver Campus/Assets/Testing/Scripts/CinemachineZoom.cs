using UnityEngine;
 
public class CinemachineZoom : MonoBehaviour
{
    public CinemachineCameraOffset playerzoomcam;
    public float scrollSensitivity = 3;
    public float lerpSpeed = 10;
    public float minDistance = 10;
    public float maxDistance = 30;
    float targetDistance;
 
    void SetTargetDistance(float value)
    {
        targetDistance = Mathf.Clamp(value, minDistance, maxDistance);
    }
 
    void Update()
    {
        if (Input.GetAxis("Mouse ScrollWheel") > 0f)
        {
            SetTargetDistance(targetDistance - scrollSensitivity);
        }
        else if (Input.GetAxis("Mouse ScrollWheel") < 0f)
        {
            SetTargetDistance(targetDistance + scrollSensitivity);
        }
 
        playerzoomcam.m_Offset.z = Mathf.Lerp(
            playerzoomcam.m_Offset.z, -targetDistance, Time.deltaTime * lerpSpeed);
    }
}
 
 