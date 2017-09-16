using UnityEngine;
using System.Collections;


public class PersonagemScript : MonoBehaviour {
	Vector2 cliqueAtual;
	Vector3 cliqueInicial;
	Vector3 cliqueFinal;
	public GameObject personagem;
	float direcao_x;
	float direcao_y;
	public float velocidade;

	void Start () {
		
	}

	void Update () {
		Movimento ();
	}

	void Movimento(){
		if (Input.GetMouseButtonDown (0))
		{
			cliqueInicial = Input.mousePosition;
		}

		if (Input.GetMouseButtonUp(0)) 
		{

			cliqueFinal = Input.mousePosition;
			direcao_x = cliqueFinal.x - cliqueInicial.x;

			if (direcao_x > 0) {
				transform.eulerAngles = new Vector2 (0, 0);
			}  else if (direcao_x < 0) {
				transform.eulerAngles = new Vector2 (0, 180);
			}
			transform.Translate (Vector3.right * velocidade * Time.deltaTime);

		}
		// Verificando o posicionamento do player dentro dos limites da câmera.
		var distancez = (transform.position - Camera.main.transform.position).z;
		var leftBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, distancez)).x;
		var rightBorder = Camera.main.ViewportToWorldPoint (new Vector3 (1, 0, distancez)).x;
		var topBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0, 0, distancez)).y;
		var bottomBorder = Camera.main.ViewportToWorldPoint (new Vector3 (0, 1, distancez)).y;
		transform.position = new Vector3 (
			Mathf.Clamp (transform.position.x, leftBorder, rightBorder),
			Mathf.Clamp (transform.position.y, topBorder, bottomBorder),
			transform.position.z
		);

	}
	void OnTriggerEnter2D(Collider2D other){
		if(other.gameObject.tag == "bolha")
		{
			Principal.pontos++;
			Destroy (other.gameObject);
		}
	}

}
