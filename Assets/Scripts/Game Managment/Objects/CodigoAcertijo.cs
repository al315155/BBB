using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodigoAcertijo : MonoBehaviour {

	private BombManager bomb;

	public Canvas acertijo;
	public Button volver;
	public InputField entrada;

	void Start () {
		bomb = GameObject.Find ("Bomb").GetComponent<BombManager> ();
		volver.GetComponent<Button> ();
		volver.onClick.AddListener (OnClick);
		entrada.onEndEdit.AddListener (delegate {
			OnEndEdit (entrada);
		});
	}

	void OnClick(){
		acertijo.gameObject.SetActive (false);
	}

	void OnEndEdit(InputField ent){
		if (ent.text == "piojo") {
			bomb.GetComponent<Level02> ().firstStep = true;
			acertijo.gameObject.SetActive (false);
		}
	}
}
