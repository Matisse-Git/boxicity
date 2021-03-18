using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npc_controller : MonoBehaviour
{
    //npc importing
    public GameObject adam;
    public GameObject brian;
    public GameObject fatima;
    public GameObject ian;
    public GameObject marie;
    public GameObject remy;
    public GameObject jean;
    public GameObject james;
    

    //script objects
    private quadrant_checker qc;


    void Start()
    {
        qc = GetComponent<quadrant_checker>();
    }

    // Update is called once per frame
    void Update()
    {
        StartInteractionAnimation(1, brian);
    }

    void StartInteractionAnimation(int quadrant, GameObject npc){
        if (qc.GetCurrentQuadrant() == quadrant){
            npc.GetComponent<Animator>().SetBool("interactionInit", true);
        }
    }
}
