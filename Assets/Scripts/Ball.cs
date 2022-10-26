using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    private int strokeCount;
    [SerializeField] private GameObject putter;

    private void Start()
    {
        strokeCount = 0;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject == putter)
        {
            strokeCount += 1;
            Debug.Log(strokeCount);
        }
    }

    public int StrokeCount => strokeCount;
    
}
