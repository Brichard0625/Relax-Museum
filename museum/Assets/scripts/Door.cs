using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
    // Create a reference for a locked door and AudioClip. 
	public bool locked;
	public AudioClip clip;

	void Start(){
		//Set door locked=true upon start of the museum
		locked = true;

		//since admissionCollected is static set to false upon start of Museum
		Admission.admissionCollected = false;

	}

		void Update() {
		// Set door to "not(!)locked and animate door to move down along the y-axis
		if (!locked) {
			if (transform.position.y < 6.481) {
				transform.Translate (0, 1.35f* Time.deltaTime, 0, Space.World);
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

