using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed;//Variavel determina velocidade doo Player	
	public Text contText;

	private Rigidbody rb;
	private int cont; //Contador,conta quantidade de cubos capturados

	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		//gameObject.tag = "CubeA";
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
			contText.text = "Vazio";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeA")){
			other.gameObject.SetActive(false);
			contText.text = "A";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeB")){
			other.gameObject.SetActive(false);
			contText.text = "B";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeC")){
			other.gameObject.SetActive(false);
			contText.text = "C";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeD")){
			other.gameObject.SetActive(false);
			contText.text = "D";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeE")){
			other.gameObject.SetActive(false);
			contText.text = "E";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeF")){
			other.gameObject.SetActive(false);
			contText.text = "F";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeG")){
			other.gameObject.SetActive(false);
			contText.text = "G";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeH")){
			other.gameObject.SetActive(false);
			contText.text = "H";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeI")){
			other.gameObject.SetActive(false);
			contText.text = "I";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeJ")){
			other.gameObject.SetActive(false);
			contText.text = "J";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeK")){
			other.gameObject.SetActive(false);
			contText.text = "K";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeL")){
			other.gameObject.SetActive(false);
			contText.text = "L";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeM")){
			other.gameObject.SetActive(false);
			contText.text = "M";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeN")){
			other.gameObject.SetActive(false);
			contText.text = "N";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeO")){
			other.gameObject.SetActive(false);
			contText.text = "O";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeP")){
			other.gameObject.SetActive(false);
			contText.text = "P";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeQ")){
			other.gameObject.SetActive(false);
			contText.text = "Q";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeR")){
			other.gameObject.SetActive(false);
			contText.text = "R";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeS")){
			other.gameObject.SetActive(false);
			contText.text = "S";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeT")){
			other.gameObject.SetActive(false);
			contText.text = "T";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeU")){
			other.gameObject.SetActive(false);
			contText.text = "U";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeV")){
			other.gameObject.SetActive(false);
			contText.text = "V";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeW")){
			other.gameObject.SetActive(false);
			contText.text = "W";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeX")){
			other.gameObject.SetActive(false);
			contText.text = "X";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeY")){
			other.gameObject.SetActive(false);
			contText.text = "Y";
			cont ++;
			Debug.Log (cont);
		}
		if (other.gameObject.CompareTag("CubeZ")){
			other.gameObject.SetActive(false);
			contText.text = "Z";
			cont ++;
			Debug.Log (cont);
		}

		if (cont >= 5){
			Debug.Log ("VOCE VENCEU");

		}

//		switch (gameObject.CompareTag) {
//			case "CubeA":
//				cont ++;
//				other.gameObject.SetActive(false);
//				contText.text = "A";
//				break;
//		}

	}
}