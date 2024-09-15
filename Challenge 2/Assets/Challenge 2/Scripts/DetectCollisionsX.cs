using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{
    DisplayScore displayScore;
    void Start()
    {
        displayScore = GameObject.FindGameObjectWithTag("DisplayScore").GetComponent<DisplayScore>();
    }

    private void OnTriggerEnter(Collider other)
    {
        displayScore.score++;
        Destroy(gameObject);
    }
}
