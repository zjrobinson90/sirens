using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour {

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
    }

    void OnTriggerStay (Collider other)
    {
    }
    void OnTriggerExit (Collider other)
    {
        rend.sharedMaterial = material[0];
    }

}
