//Autor: Thiago Nicola Cajuela Garcia
/*
Script que mante a camera em seu lugar restringindo os movimentos para que nao rode com a esfera
 */
using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {
	
	public GameObject player;	
	private Vector3 offset;
	
	void Start ()
	{
		offset = transform.position - player.transform.position;
	}
	
	void LateUpdate ()
	{
		transform.position = player.transform.position + offset;
	}
}