using UnityEngine;
using System.Collections;

public class RotateCube : MonoBehaviour {
	public float velocidade_x;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		Transform.Rotate (new Vector3 (10, 40, 50) * Time.deltaTime);
		transform.Rotate (new Vector3 (velocidade_x, 50, 30) * Time.deltaTime);
	
	}
}
