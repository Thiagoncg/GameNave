//Autor: Thiago nicola Cajuela Garcia
/*
 * script que mostra a direçao das letras que devem se coletadas
 */
using UnityEngine;
using System.Collections;

public class ApontaLetra : MonoBehaviour {
	public Transform letraA;

	public GameObject cuboQAponta;	
	private Vector3 mantemPosition;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (letraA);	
	}
}

//Lembrar de criar um scripting chamado mostra direçao
//seta que aponta abstract ddireçao da palavra correta.
