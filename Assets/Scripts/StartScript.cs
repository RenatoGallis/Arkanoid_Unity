using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Return) || Input.touchCount == 2 ){
			PrincipalScript.qtd_vidas = 5;
			PrincipalScript.qtd_pontos = 0;
			SceneManager.LoadScene ("Game");
			
		}
		
	}
}
