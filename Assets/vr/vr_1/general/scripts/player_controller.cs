using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_controller : MonoBehaviour
{
    
    private Animator animator;

    private Vector3 defaultPos = new Vector3(0.309f, 0.51f, 63.128f);
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {

    }

    public bool CheckIntroFinished(){
        return animator.GetCurrentAnimatorStateInfo(0).IsName("done_walking");
    }
}
