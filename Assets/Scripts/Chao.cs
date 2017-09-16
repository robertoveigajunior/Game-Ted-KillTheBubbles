using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chao : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Principal.vidas = 5;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "bolha")
		{
			Principal.vidas--;
			Destroy (other.gameObject);
		}
	}
}
