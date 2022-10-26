using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Putter : MonoBehaviour
{
    [SerializeField]
    private Transform head;

    [SerializeField] private int speed = 2;
    private void OnCollisionEnter(Collision collision)
    {
        Vector3 normal = (collision.transform.position - head.position).normalized;
        collision.gameObject.GetComponent<Rigidbody>().AddForce(normal * speed, ForceMode.Impulse);
    }
}
