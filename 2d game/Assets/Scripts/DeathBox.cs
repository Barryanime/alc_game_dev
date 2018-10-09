using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathBox : MonoBehaviour {
	void OnTriggerEnter2D (Rigidbody2D other){

		if (other.name == "PC")
		{
			Debug.Log("Player Enters Death Zone");
			Destroy(other);

		}
	}


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
