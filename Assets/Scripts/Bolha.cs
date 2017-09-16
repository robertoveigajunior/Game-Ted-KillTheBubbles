using UnityEngine;
using System.Collections;

public class Bolha : MonoBehaviour {
	public float velocidadeMinima, velocidadeMaxima;
	public GameObject explosaoPrefab;

	float tamanhoMinimo = 0.5f;
	float tamanhoMaximo = 1.5f;

	int vida;
	float tamanho;
	float velocidade;
	Rigidbody2D rb;
	// Use this for initialization
	void Start () {
		// Acesso ao componente Rigidbody2D
		rb = GetComponent<Rigidbody2D> ();

		// Atribui micro gravidade
		rb.gravityScale = 0.0f;

		// Define o tamanho do asteroide
		tamanho = Random.Range(tamanhoMinimo, tamanhoMaximo);

		// Velocidade
		velocidade = Random.Range(velocidadeMinima, velocidadeMaxima);

		// Atribui pontos de vida ao asteroide
		if (tamanho < 0.5) {
			vida = 1;
		} else if (tamanho < 1.5) {
			vida = 1; 
		} else {
			vida = 1;
		}

		// Aplica escala ao objeto
		transform.localScale = new Vector3(tamanho, tamanho, tamanho);
	}


	void Update () {
		// Move o asteroide
		transform.Translate (Vector2.down * velocidade * Time.deltaTime);
	}
		

}