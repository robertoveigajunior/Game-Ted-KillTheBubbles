using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Vida : MonoBehaviour {

	public Text v;
	public string cena;

	void Start () {

	}

	void Update () {
		v.text = Principal.vidas.ToString();	
		if (Principal.vidas == 0) {
			SceneManager.LoadScene (cena);
		}
	}
}
