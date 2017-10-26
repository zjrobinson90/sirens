using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  //its a must to access new UI in script


public class TextCreate : MonoBehaviour {

	public Text Hotdog_Text; // assign it from inspector
	void Start(){		
		GameObject dinger = GameObject.Find("Dinger");
        TriggerScript triggerScript = dinger.GetComponent<TriggerScript>();
		Hotdog_Text.text = triggerScript.hotdogNum.ToString();
	}
	
	// Update is called once per frame
	void Update () {
		GameObject dinger = GameObject.Find("Dinger");
        TriggerScript triggerScript = dinger.GetComponent<TriggerScript>();
		Hotdog_Text.text = triggerScript.hotdogNum.ToString();
	}
}
