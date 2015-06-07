//Autor Thiago Nicola Cajuela Garcia
/*Script que gera as letras de A a Z para adcionar nos cubos de forma randomica
criando assim apenas um Prefab cubo, que ira receber delegate forma randomica as texturas de 
letras*/
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
		case "Vazio":
			GetComponent<Renderer>().material.mainTexture = vazio;
			gameObject.tag = "Vazio";
			break;
		case "A":
			GetComponent<Renderer>().material.mainTexture = letraA;
			gameObject.tag = "CubeA";
			break;
		case "B":
			GetComponent<Renderer>().material.mainTexture = letraB;
			gameObject.tag = "CubeB";
			break;
		case "C":
			GetComponent<Renderer>().material.mainTexture = letraC;
			gameObject.tag = "CubeC";
			break;
		case "D":
			GetComponent<Renderer>().material.mainTexture = letraD;
			gameObject.tag = "CubeD";
			break;
		case "E":
			GetComponent<Renderer>().material.mainTexture = letraE;
			gameObject.tag = "CubeE";
			break;
		case "F":
			GetComponent<Renderer>().material.mainTexture = letraF;
			gameObject.tag = "CubeF";
			break;
		case "G":
			GetComponent<Renderer>().material.mainTexture = letraG;
			gameObject.tag = "CubeG";
			break;
		case "H":
			GetComponent<Renderer>().material.mainTexture = letraH;
			gameObject.tag = "CubeH";
			break;
		case "I":
			GetComponent<Renderer>().material.mainTexture = letraI;
			gameObject.tag = "CubeI";
			break;
		case "J":
			GetComponent<Renderer>().material.mainTexture = letraJ;
			gameObject.tag = "CubeJ";
			break;
		case "K":
			GetComponent<Renderer>().material.mainTexture = letraK;
			gameObject.tag = "CubeK";
			break;
		case "L":
			GetComponent<Renderer>().material.mainTexture = letraL;
			gameObject.tag = "CubeL";
			break;
		case "M":
			GetComponent<Renderer>().material.mainTexture = letraM;
			gameObject.tag = "CubeM";
			break;
		case "N":
			GetComponent<Renderer>().material.mainTexture = letraN;
			gameObject.tag = "CubeN";
			break;
		case "O":
			GetComponent<Renderer>().material.mainTexture = letraO;
			gameObject.tag = "CubeO";
			break;
		case "P":
			GetComponent<Renderer>().material.mainTexture = letraP;
			gameObject.tag = "CubeP";
			break;
		case "Q":
			GetComponent<Renderer>().material.mainTexture = letraQ;
			gameObject.tag = "CubeQ";
			break;
		case "R":
			GetComponent<Renderer>().material.mainTexture = letraR;
			gameObject.tag = "CubeR";
			break;
		case "S":
			GetComponent<Renderer>().material.mainTexture = letraS;
			gameObject.tag = "CubeS";
			break;
		case "T":
			GetComponent<Renderer>().material.mainTexture = letraT;
			gameObject.tag = "CubeT";
			break;
		case "U":
			GetComponent<Renderer>().material.mainTexture = letraU;
			gameObject.tag = "CubeU";
			break;
		case "V":
			GetComponent<Renderer>().material.mainTexture = letraV;
			gameObject.tag = "CubeV";
			break;
		case "W":
			GetComponent<Renderer>().material.mainTexture = letraW;
			gameObject.tag = "CubeW";
			break;
		case "X":
			GetComponent<Renderer>().material.mainTexture = letraX;
			gameObject.tag = "CubeX";
			break;
		case "Y":
			GetComponent<Renderer>().material.mainTexture = letraY;
			gameObject.tag = "CubeY";
			break;
		case "Z":
			GetComponent<Renderer>().material.mainTexture = letraZ;
			gameObject.tag = "CubeZ";
			break;
		}	
	}	
	// Update is called once per frame
	void Update () {
	
	}
}
