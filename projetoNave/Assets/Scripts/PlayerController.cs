using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour {
	
	public float speed;//Variavel determina velocidade doo Player	
	private Rigidbody rb;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody>();
		gameObject.tag = "CubeA";


	}
	
	void FixedUpdate ()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce (movement * speed);
	}
	//Faz objetos com tag coletaveis desaparecer
	void OnTriggerEnter(Collider other) 
	{
		if (other.gameObject.CompareTag ("Coletaveis")) 
		{
			other.gameObject.SetActive(false);
			//Destroy(other.gameObject);
			Debug.Log("Objeto colidiu");
		}

	}
}