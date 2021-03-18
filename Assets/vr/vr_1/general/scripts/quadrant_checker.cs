using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quadrant_checker: MonoBehaviour
{

    [SerializeField]
    private Transform cameraTransform;
    private float rotation;
    [SerializeField]
    private int currentQuadrant;
    private int quadrantSize = 90;

    void Update(){
        CalculateQuadrant();
    }

    private void CalculateQuadrant(){
        rotation = cameraTransform.eulerAngles.y;
        currentQuadrant = (int) ((rotation / quadrantSize) + 1);
    }

    public int GetCurrentQuadrant(){
        if (GetComponent<player_controller>().CheckIntroFinished()){
            CalculateQuadrant();
            return currentQuadrant;
        }
        return 0;
    }
}
