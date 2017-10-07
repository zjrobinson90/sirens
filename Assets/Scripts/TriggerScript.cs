﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {

    public Transform prefab;
    public Material[] material;
    Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
    }

    void OnTriggerEnter (Collider other)
    {
        rend.sharedMaterial = material[1];
        for (int i = 0; i < 5; i++)
        {
            Instantiate(prefab, new Vector3((i*2F) - 2, 1, -6), Quaternion.identity);
        }
    }

    void OnTriggerStay (Collider other)
    {
    }
    void OnTriggerExit (Collider other)
    {
        rend.sharedMaterial = material[0];
    }

}
