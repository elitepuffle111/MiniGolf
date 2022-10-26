using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Putter : MonoBehaviour
{
    [SerializeField]
    private Transform head;

    [SerializeField] private Transform ball;

    [SerializeField] private float speed = 2;
    private Vector3 putterVelocity;
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 normal = (collision.transform.position - head.position).normalized;
        float putterSpeed = putterVelocity.magnitude;
        Debug.Log(putterSpeed);
        collision.gameObject.GetComponent<Rigidbody>().AddForce(normal * speed /* * putterSpeed */, ForceMode.VelocityChange);
    }

    private void Update()
    {
        putterVelocity = (transform.position - ball.position)/Time.deltaTime;
    }
}
