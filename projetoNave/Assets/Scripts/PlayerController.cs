//Autor; Thiago Nicola Cajuela Garcia
/*
 * script que controla o controle, coleta os cubos e identifica qual foi o cubo coletado e joga o valor no gui text
 */
using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed;//Variavel determina velocidade doo Player	
	public Text contText;
	public AudioSource audio;
	
	private Rigidbody rb;
	private int cont; //Contador,conta quantidade de cubos capturados



	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		audio = GetComponent<AudioSource>();
		cont = 0;

	}


	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce (movement * speed);
	}



	void OnTriggerEnter(Collider other) 
	{
//		if (other.gameObject.CompareTag ("Coletaveis")) //Se tag for igual "letraA" cont.text = "A"
//		{
//			other.gameObject.SetActive(false);//Faz objetos com tag coletaveis desaparecer
//			cont ++;
//			Debug.Log("Objeto colidiu");
//			Debug.Log(cont);
//			contText.text = "Count: " + cont.ToString ();
//		}

		if (other.gameObject.CompareTag("Vazio")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "Vazio";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeA")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "A";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeB")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "B";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeC")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "C";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeD")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "D";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeE")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "E";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeF")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "F";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeG")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "G";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeH")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "H";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeI")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "I";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeJ")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "J";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeK")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "K";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeL")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "L";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeM")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "M";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeN")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "N";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeO")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "O";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeP")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "P";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeQ")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "Q";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeR")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "R";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeS")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "S";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeT")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "T";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeU")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "U";
			cont ++;

			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeV")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "V";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeW")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "W";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeX")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "X";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeY")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "Y";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeZ")){
			other.gameObject.SetActive(false);
			contText.text = contText.text + "Z";
			cont ++;
			audio.Play();
			Debug.Log (cont);
		}

		if (cont >= 5){
			Debug.Log ("VOCE VENCEU");

		}

//		switch (gameObject.tag) {
//			case "CubeA":
//				cont ++;
//				other.gameObject.SetActive(false);
//				contText.text = "A";
//				break;
//		}

	}
}