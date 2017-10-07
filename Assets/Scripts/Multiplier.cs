using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiplier : MonoBehaviour {

    public Transform prefab;
	void Start () {
        for (int i = 0; i < 50; i++)
        {
            Instantiate(prefab, new Vector3(0, i * 0.5F, 0), Quaternion.identity);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
