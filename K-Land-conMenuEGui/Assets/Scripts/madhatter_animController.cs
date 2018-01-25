using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class madhatter_animController : MonoBehaviour {

	public Animator anim;

	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();	
	}
	
	// Update is called once per frame
	void Update () {

		// se si sceglie di avviare l'animazione con la pressione di un tasto 
		if (Input.GetKeyDown ("1")) {
			anim.Play ("madhatter_animation"); 
			// il nome madhatter_animation corrisponde allo stato dell'animator
		}

		// per fermare l'animazione cliccare un altro tasto 
		// cercare di modificare questa parte in modo automatico senza i tasti
//		if (Input.GetKeyDown ("2")) {
//			anim.Play ("fermo"); 
//		}

		// fare in modo che quando l'animazione sia finita che non faccia il loop:
		//risolto togliendo il loop dal pannello dell'animazione
	}
}
