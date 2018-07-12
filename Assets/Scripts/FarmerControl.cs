using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Farmer))]
public class FarmerControl : MonoBehaviour {

    Farmer farmer;

    // Use this for initialization
    void Start()
    {
        farmer = GetComponent<Farmer>();
    }

    void FixedUpdate()
    {
        if (!farmer.isEnemy)
        {
            float verticalInput = Input.GetAxis("Vertical");
            float horizontalInput = Input.GetAxis("Horizontal");

            farmer.SetForwardSpeed(verticalInput);
            farmer.SetTurnSpeed(horizontalInput);
        }
    }
}
