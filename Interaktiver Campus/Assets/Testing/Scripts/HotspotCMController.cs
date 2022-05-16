using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotspotCMController : MonoBehaviour
{

    public GameObject[] hotspots;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
        
    }
}
