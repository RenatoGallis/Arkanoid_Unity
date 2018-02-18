using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bolinha : MonoBehaviour {

	public float forca_bolinha;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().AddForce (new Vector2 (forca_bolinha, forca_bolinha));
	}
	
	// Update is called once per frame
	void Update () {}

	void OnCollisionEnter2D(Collision2D c){

		if(c.gameObject.tag == "Blocos"){
			PrincipalScript.qtd_pontos++;
			Destroy (c.gameObject);

			if (PrincipalScript.qtd_pontos == 6) {
				SceneManager.LoadScene ("Start");
			}

		}
		if(c.gameObject.tag == "chao"){

			PrincipalScript.qtd_vidas--;
			if(PrincipalScript.qtd_vidas <= 0 ){
				SceneManager.LoadScene ("Start");
			}else {
				GetComponent<Rigidbody2D> ().position = new Vector2 (0.0f, 0.0f);
			}
		}
	}
}
