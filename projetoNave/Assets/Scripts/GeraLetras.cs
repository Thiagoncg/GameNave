//Autor Thiago Nicola Cajuela Garcia
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class GeraLetras : MonoBehaviour {
	//DETERMINA AS IMAGENS NAS LETRAS
	public Texture2D vazio;
	public Texture2D letraA;
	public Texture2D letraB;
	public Texture2D letraC;
	public Texture2D letraD;
	public Texture2D letraE;
	public Texture2D letraF;
	public Texture2D letraG;
	public Texture2D letraH;
	public Texture2D letraI;
	public Texture2D letraJ;
	public Texture2D letraK;
	public Texture2D letraL;
	public Texture2D letraM;
	public Texture2D letraN;
	public Texture2D letraO;
	public Texture2D letraP;
	public Texture2D letraQ;
	public Texture2D letraR;
	public Texture2D letraS;
	public Texture2D letraT;
	public Texture2D letraU;
	public Texture2D letraV;
	public Texture2D letraW;
	public Texture2D letraX;
	public Texture2D letraY;
	public Texture2D letraZ;



	//CRIA O VETOR DE LETRAS PARA SER SORTEADA
	string[] letrasVetor = {"Vazio","A","B","C","D","E","F","G","H","I","J","K","L","M","N","O","P","Q","R","S","T","U","V","W","X","Y","Z"};

	public string letra = "";
	//Text text;


	// Use this for initialization
	public void Start () {
		//VERIFICA O TAMANHO DO VETOR DE LETRAS E CAPTURA A QUANTIDADE DE LETRAS E JOGA EM (quantLetras)
		int quantLetras = letrasVetor.Length;

		//FAZ O SORTEIRO DE 0 A quantLetras e JOGA A POSIÇAO SORTEADA EM NFRASES
		//int numeroPosition = UnityEngine.Random.Range (0, quantLetras);
		int numeroPosition = Random.Range (0, quantLetras);
		
		letra = letrasVetor [numeroPosition];

		//Debug.Log ("QUANTIDADE DE LETRAS = "+quantLetras);
		//Debug.Log ("LETRA ESCOLHIDA " + numeroPosition);
		//Debug.Log ("A LETRA ESCOLHIDA FOI " + letra);
		//gameObject.tag = "CubeA";


	switch (letra) {		
		case "vazio":
			GetComponent<Renderer>().material.mainTexture = vazio;
			break;
		case "A":
			GetComponent<Renderer>().material.mainTexture = letraA;
			gameObject.tag = "CubeA";
			break;
		case "B":
			GetComponent<Renderer>().material.mainTexture = letraB;
			break;
		case "C":
			GetComponent<Renderer>().material.mainTexture = letraC;
			break;
		case "D":
			GetComponent<Renderer>().material.mainTexture = letraD;
			break;
		case "E":
			GetComponent<Renderer>().material.mainTexture = letraE;
			break;
		case "F":
			GetComponent<Renderer>().material.mainTexture = letraF;
			break;
		case "G":
			GetComponent<Renderer>().material.mainTexture = letraG;
			break;
		case "H":
			GetComponent<Renderer>().material.mainTexture = letraH;
			break;
		case "I":
			GetComponent<Renderer>().material.mainTexture = letraI;
			break;
		case "J":
			GetComponent<Renderer>().material.mainTexture = letraJ;
			break;
		case "K":
			GetComponent<Renderer>().material.mainTexture = letraK;
			break;
		case "L":
			GetComponent<Renderer>().material.mainTexture = letraL;
			break;
		case "M":
			GetComponent<Renderer>().material.mainTexture = letraM;
			break;
		case "N":
			GetComponent<Renderer>().material.mainTexture = letraN;
			break;
		case "O":
			GetComponent<Renderer>().material.mainTexture = letraO;
			break;
		case "P":
			GetComponent<Renderer>().material.mainTexture = letraP;
			break;
		case "Q":
			GetComponent<Renderer>().material.mainTexture = letraQ;
			break;
		case "R":
			GetComponent<Renderer>().material.mainTexture = letraR;
			break;
		case "S":
			GetComponent<Renderer>().material.mainTexture = letraS;
			break;
		case "T":
			GetComponent<Renderer>().material.mainTexture = letraT;
			break;
		case "U":
			GetComponent<Renderer>().material.mainTexture = letraU;
			break;
		case "V":
			GetComponent<Renderer>().material.mainTexture = letraV;
			break;
		case "W":
			GetComponent<Renderer>().material.mainTexture = letraW;
			break;
		case "X":
			GetComponent<Renderer>().material.mainTexture = letraX;
			break;
		case "Y":
			GetComponent<Renderer>().material.mainTexture = letraY;
			break;
		case "Z":
			GetComponent<Renderer>().material.mainTexture = letraZ;
			break;
		}	
	}
		/* Desa forma esta dando certo
		if (letra == "A"){
			GetComponent<Renderer>().material.mainTexture = letraA;
			gameObject.tag = "CubeA";
		}
		*/
	
	// Update is called once per frame
	void Update () {
	
	}
}
