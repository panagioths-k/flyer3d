using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraHandler : MonoBehaviour {

    Camera mainCamera;                //Main Camera of the scene
    public float forwardZspeed;
    Vector3 speedVector;

    // Use this for initialization
    void Start () {

     //   Debug.Log("Started");
        mainCamera = Camera.main;     //get Main Camera
        speedVector = new Vector3(0f, 0f, forwardZspeed);
    }
	
	// Update is called once per frame
	void Update () {

     //   Debug.Log("Updating...");
        mainCamera.transform.position += speedVector;

    }
}
