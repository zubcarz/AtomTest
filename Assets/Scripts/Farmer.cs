using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
[RequireComponent(typeof(Rigidbody))]
public class Farmer : MonoBehaviour {

    Animator playerAnimator;
    Rigidbody rb;

    public float forwardSpeed = 1f;
    public float turnSpeed = 1f;
    public bool isEnemy = false;

    // Use this for initialization
    void Awake()
    {
        playerAnimator = GetComponent<Animator>();
        playerAnimator.applyRootMotion = true;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        playerAnimator.applyRootMotion = Grounded();
        playerAnimator.SetBool("grounded", Grounded());
    }

    public bool Grounded()
    {
        return Mathf.Abs(Vector3.Dot(rb.velocity, Vector3.up)) < 0.01;
    }
        

    public void SetTurnSpeed(float speed)
    {
        playerAnimator.SetFloat("turnSpeed", speed);
        transform.Rotate(0, Time.deltaTime * turnSpeed * speed, 0);
    }

    public void SetTurnToAngle(float angle)
    {

    }

    public void SetForwardSpeed(float speed)
    {

        if (isEnemy)
        {
            playerAnimator.SetFloat("forwardSpeed", 0.4f);
        }
        else
        {
            playerAnimator.SetFloat("forwardSpeed", speed);
        }

       
        rb.velocity += transform.forward * forwardSpeed * ((speed > 0)? speed : 0);
    }
}
