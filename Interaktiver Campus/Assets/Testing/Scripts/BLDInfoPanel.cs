using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BLDInfoPanel : MonoBehaviour
{
    public Animator animator;

    public GameObject[] panels;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var aniIndex = animator.GetInteger("AnimationIndex");

        panels[1].SetActive(true);

    }
}
