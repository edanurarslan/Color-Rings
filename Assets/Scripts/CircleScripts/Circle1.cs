using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle1 : MonoBehaviour {


    void Start()
    {
        Debug.Log("Circle1");
        iTween.MoveTo(base.gameObject, iTween.Hash(new object[]
        {
            "y",
            0,
            "easetype",
            iTween.EaseType.easeInCirc,
            "time",
            0.2,
            "OnComplete",
            "RotateCircle"
        }));
        //Debug.Log("Circle1 2");
    }

    void RotateCircle()
    {
        print("The Itween anim is done");
    }

    void Update () {
       // Debug.Log("Circle1 3");
       transform.Rotate(Vector3.up * Time.deltaTime * BallHandler.rotationSpeed);
    }
}