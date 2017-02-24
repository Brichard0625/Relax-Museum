using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChange : MonoBehaviour {
	public float timer = 0.0f;
	public GameObject gameObject;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= 2.0f)//change the float value here to change how long it takes to switch.
		{
			// pick a random color
			Color newColor = new Color( Random.value, Random.value, Random.value, 1.0f );
			// apply it on current object's material
			gameObject.GetComponent<Renderer>().material.color=newColor;
			timer = 0;
		}

		
		
	}
}
