using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    [SerializeField] private GameObject resultUI;

    private void Start()
    {
        resultUI.SetActive(false);
    }

    private void OnTriggerEnter(Collider other)
    {
        resultUI.SetActive(true);
    }
}
