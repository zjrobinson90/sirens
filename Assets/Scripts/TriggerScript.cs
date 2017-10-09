using System.Collections;
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
        for (int i = 0; i < 5; i++)
        {
            //Instantiate(prefab, new Vector3((i*2F) - 5, 1.2F, -7), Quaternion.identity);
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }

    void OnTriggerStay (Collider other)
    {
        rend.sharedMaterial = material[1];
    }
    void OnTriggerExit (Collider other)
    {
        rend.sharedMaterial = material[0];
    }

}
