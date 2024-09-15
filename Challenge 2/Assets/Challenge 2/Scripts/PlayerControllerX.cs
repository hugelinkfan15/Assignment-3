using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    public float cooldown = 1.0f;

    public float passedTime;

    // Update is called once per frame
    void Update()
    {
        passedTime += Time.deltaTime;
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space) && cooldown<passedTime)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            passedTime = 0.0f;

        }
    }
}
