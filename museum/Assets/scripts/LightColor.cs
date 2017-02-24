using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightColor : MonoBehaviour {
	public float timer = 0.0f;
	public Light lt;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= 2.0f)//change the float value here to change how long it takes to switch.
		{
			// pick a random color
			lt.color = new Color( Random.value, Random.value, Random.value, 1.0f );
			// apply it on current object's material
			lt.GetComponent<Light>();
			timer = 0;
		}



	}
}
	
