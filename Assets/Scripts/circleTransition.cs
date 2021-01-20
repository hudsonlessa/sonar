using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class circleTransition : MonoBehaviour {


	Animator anim;
	public bool play = true;

	float contador = 50;
	bool diminuircontador = false;


	AudioSource pop;

	// Use this for initialization
	void Start () {
		
		anim = GetComponent<Animator> ();
		pop = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (diminuircontador) {
			contador--;
		}

		if (contador <= 0) {
			SceneManager.LoadScene (1);

		}
	}

	public void OnMouseDown()
	{
		anim.SetBool ("start", true);
		diminuircontador = true;
		pop.Play ();
	}
}
