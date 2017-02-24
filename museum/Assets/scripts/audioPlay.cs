using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlay : MonoBehaviour {
	public AudioClip clip;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	//Play Audio associated with object 	
	public void playAudio(){
	AudioSource.PlayClipAtPoint(clip, transform.position);


	}

}
