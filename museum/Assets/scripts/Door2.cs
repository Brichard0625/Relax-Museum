using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour 
{
	// Create a reference for a locked door and AudioClip 
	public bool locked;
	public AudioClip clip;

	void Start(){
		//Set door locked=true upon start of the museum
		locked = true;

		//since admissionCollected is static set to false upon start of museum
		Admission.admissionCollected = false;

	}

	void Update() {
		// Set door to "not(!)locked and animate door to move up along the y-axis
		if (!locked) {
			if (transform.position.x < 0) {
				transform.Translate (0, -2.61f*Time.deltaTime, 0, Space.World);
			}
		}
	}


	public void unlock(){
		// Reference the admissionCollected from the admission.cs and if admission is collected set locked to false.
		if (Admission.admissionCollected) {
			locked = false;

			//Play audio when door is unlocked
			AudioSource.PlayClipAtPoint(clip, transform.position);
		}

	}
}

