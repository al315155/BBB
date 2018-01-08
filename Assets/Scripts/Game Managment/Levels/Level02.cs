using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level02 : MonoBehaviour {

	private BombManager bomb;

	// First Condition
	public GameObject winkFace;
	public bool firstStep;

	void Start () {
		bomb = GameObject.Find ("Bomb").GetComponent<BombManager> ();

		firstStep = false;
	}
	
	void Update () {
		bool click = Input.GetMouseButtonDown (0);
		if (bomb.CursorName.Equals ("None") && !firstStep && click) {
			IsFacedClicked ();	
		}
	}

	private void IsFacedClicked(){
		RaycastHit ray;
		if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out ray)){
			Debug.Log (ray.collider.transform.parent.name);
			if (ray.collider.transform.parent.name.Equals("NormalBox")){
				winkFace.GetComponentInChildren<CodigoAcertijo> ().acertijo.gameObject.SetActive(true);
			}
		}		
	}

	public void AppearScrewdriver(){
		
	}

	private void IsLvlOvercomed(){
		if (firstStep) {
			
		}
	}
}
