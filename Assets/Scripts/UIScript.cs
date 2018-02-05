using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIScript : MonoBehaviour {

	public Text input_pontos;
	public Text input_vidas;

	
	// Update is called once per frame
	void Update () {
		input_pontos.text = PrincipalScript.qtd_pontos.ToString ();
		input_vidas.text = PrincipalScript.qtd_vidas.ToString ();
	}
}
