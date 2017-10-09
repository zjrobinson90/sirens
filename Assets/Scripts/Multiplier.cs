using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Multiplier : MonoBehaviour {

    public Transform prefab;
    public void hotDogs()
    {
        for (int i = 0; i < 10; i++)
        {
            Instantiate(prefab, transform.position, transform.rotation);
        }
    }
}
