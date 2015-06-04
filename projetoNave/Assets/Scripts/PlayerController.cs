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
		gameObject.tag = "CubeA";
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
		if (other.gameObject.CompareTag ("Coletaveis")) //Se tag for igual "letraA" cont.text = "A"
		{
			other.gameObject.SetActive(false);//Faz objetos com tag coletaveis desaparecer
			cont ++;

			Debug.Log("Objeto colidiu");
			Debug.Log(cont);
			contText.text = "Count: " + cont.ToString ();
		}

	}
}