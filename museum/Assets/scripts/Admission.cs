using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Admission : MonoBehaviour 
{
    //Create a reference to the admissionPrefab, admissionCollected, AudoClip.*keyCollected should be static variable*
	public GameObject admissionPoof;
	public AudioClip clip;
	public static bool admissionCollected;

	void Update()
	{
		

	}

	public void OnAdmissionClicked()
	{
		//Once admission has been clicked.  Set admissionCollected = true
		admissionCollected = true;

		// Instatiate the admissionpoof Prefab where this admission is located 
		Instantiate(admissionPoof, transform.position, Quaternion.Euler (-90, 0, 0));

		//Play audio once the key is collected
		AudioSource.PlayClipAtPoint(clip, transform.position);

		//Destroy the key when clicked		
		Destroy (gameObject);

			}
}

