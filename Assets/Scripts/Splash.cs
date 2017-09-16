using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour {

	public string cena;

	// Use this for initialization
	void Start () {
		Screen.orientation = ScreenOrientation.Portrait;
	}

	// Update is called once per frame
	void Update () {
		if (Input.touchCount > 0 || Input.GetButtonDown("Fire1")) {
			SceneManager.LoadScene (cena);
			Principal.pontos = 0;
			Principal.vidas = 5;
		}
	}
}
