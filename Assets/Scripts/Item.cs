using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Item : MonoBehaviour {

    public float SpeedRotation = 1f;
    public UnityEvent addScore;

    void Update()
    {
        transform.Rotate(Time.deltaTime * SpeedRotation, Time.deltaTime * SpeedRotation, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            addScore.Invoke();
            Destroy(transform.gameObject, 0.5f);
        }   
    }
}
