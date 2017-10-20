using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSound : MonoBehaviour {

	public AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter (Collider other)
    {
        audio.Play();
    }
	void OnTriggerStay (Collider other)
    {
		//Do nothing
	}
    void OnTriggerExit (Collider other)
    {
		//Do nothing
	}
}