using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject pinPrefab;

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            SpawnPin();
        }
        if (Input.GetButtonDown("Fire1"))
        {
            SpawnPin();
        }
        if (Input.GetButtonDown("Button 0"))
        {
            SpawnPin();
        }
    }

    void SpawnPin()
    {
        Instantiate(pinPrefab, transform.position, transform.rotation);
    }
}
