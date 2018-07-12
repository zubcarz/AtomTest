using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
[RequireComponent(typeof(Farmer))]
public class FarmerAI : MonoBehaviour {

    public Transform goal;
    UnityEngine.AI.NavMeshAgent agent;
    Farmer character;

    // Use this for initialization
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
        character = GetComponent<Farmer>();
        agent.updatePosition = false;
        agent.updateRotation = false;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        agent.destination = goal.transform.position;

        Vector3 worldDeltaPosition = agent.nextPosition - transform.position;

        float turnSpeed = Vector3.Dot(Vector3.up, Vector3.Cross(transform.forward, worldDeltaPosition));
        character.SetTurnSpeed(turnSpeed);

        float forwardSpeed = Vector3.Dot(transform.forward, worldDeltaPosition);
        character.SetForwardSpeed(forwardSpeed);
        print(forwardSpeed);

        if (agent.isOnOffMeshLink)
        {
            agent.CompleteOffMeshLink();
        }
    }
}
