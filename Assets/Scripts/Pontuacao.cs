using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pontuacao : MonoBehaviour {
	public Text p;

	void Start () {
	
	}

	void Update () {
		p.text = Principal.pontos.ToString();	
	}
}
