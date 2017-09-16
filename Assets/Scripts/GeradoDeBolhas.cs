using UnityEngine;
using System.Collections;

public class GeradoDeBolhas : MonoBehaviour {
	public GameObject bolha;
	public float limiteEsquerdo, limiteDireito, limiteFrente, limiteTras;
	public float altura;
	public float tempo;

	void Start () {
		StartCoroutine(GeradorDeInimigos());
	}
	
	void Update () {
		
	}

	IEnumerator GeradorDeInimigos()
	{
		Criar();
		yield return new WaitForSeconds(tempo);
		StartCoroutine(GeradorDeInimigos());
	}

	void Criar()
	{

		// Sorteia as Coordeadas em x e z
		int xPos = Random.Range( (int)limiteEsquerdo, (int)limiteDireito);
		int zPos = Random.Range((int)limiteFrente, (int)limiteTras);

		//Montado a coordeada para surgir o inimigo
		Vector3 posicao = new Vector3(xPos, altura, zPos);

		// Insere o inimigo no jogo
		Instantiate(bolha, posicao, bolha.transform.rotation);

	}
}
