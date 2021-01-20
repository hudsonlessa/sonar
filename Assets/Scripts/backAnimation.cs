using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backAnimation : MonoBehaviour {


	[SerializeField]
	GameObject circle;
	Animator circleAnimator;


	float contador = 1.0f;
	bool diminuircontador = false;

	AudioSource pop;

	// Use this for initialization
	void Start () {

		circleAnimator = circle.GetComponent<Animator> ();
		pop = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (diminuircontador) {
			contador -= Time.deltaTime;
		}

		if (contador <= 0) {

			SceneManager.LoadScene (0);
		}

	}

	public void OnClick()
	{
		circleAnimator.SetBool ("start", true);
		diminuircontador = true;
		pop.Play ();
	}
}
