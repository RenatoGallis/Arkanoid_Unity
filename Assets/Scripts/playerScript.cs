using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour {
	public float velocidade;
	public float limite_direito;
	public float limite_esquerdo;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		Movimentacao ();
		
	}

	void Movimentacao(){
		float move_x = Input.GetAxisRaw ("Horizontal");

		GetComponent<Rigidbody2D> ().velocity = Vector2.right * move_x * velocidade;

		if(transform.position.x < limite_esquerdo || transform.position.y < limite_direito){

			transform.position = new Vector2 (transform.position.x, transform.position.y);
		}
	}
}
