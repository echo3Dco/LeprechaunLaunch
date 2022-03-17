using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchLeprechaun : MonoBehaviour
{

    [SerializeField]
    private Rigidbody leprechaun;

    [SerializeField]
    private float launchSpeed;


    private Touch tapToThrow;
    private Vector3 startingPosition;
    private Quaternion startingRotation;

    // Starting point for the leprechaun
    void Start()
    {
        startingPosition = leprechaun.transform.position;
        startingRotation = leprechaun.transform.rotation;
    }

    void Update()
    {
        //To play on your Android device, comment out this Input. Hit "Space" bar to fire.
         if (Input.GetKeyDown(KeyCode.Space))
        
        // To play on keyboard, comment out this Input. 
        //if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            leprechaun.AddForce(-leprechaun.transform.right * launchSpeed, ForceMode.VelocityChange);
            print("Shooting the shot");
        }
    }

    // On trigger collision, reset leprechaun to starting point
    void OnTriggerEnter(Collider other)
    {
        leprechaun.transform.position = startingPosition;
        leprechaun.transform.rotation = startingRotation;

        leprechaun.velocity = Vector3.zero;
        print("Trigger activated");
    }
}