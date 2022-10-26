using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Hole : MonoBehaviour
{
    [SerializeField] private GameObject resultUI;
    private string[] results = { "Hole in One", "Birdie", "Par", "Bogey","Double Bogey", "Triple Bogey" };
    private int par;
    [SerializeField]
    private Ball ball;

    private void Start()
    {
        resultUI.SetActive(false);
    }
    //showcases results when ball lands into hole.
    private void OnTriggerEnter(Collider other)
    {
        if (ball.StrokeCount == 1)
        {
            resultUI.GetComponent<TextMeshPro>().text = results[0];
        }
        else if (ball.StrokeCount - par + 2 < 6)
        {
            resultUI.GetComponent<TextMeshPro>().text = results[ball.StrokeCount - par + 2];
        }
        else
        {
            resultUI.GetComponent<TextMeshPro>().text = ball.StrokeCount.ToString();
        }
        if (other.gameObject.GetComponent<Ball>() == true)
            resultUI.SetActive(true);
    }

    public int Par => par;
}
