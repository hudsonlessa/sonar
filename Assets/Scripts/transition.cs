using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class transition : MonoBehaviour {

	[SerializeField]
	GameObject rectangle;
	Animator RectangleAnim;

	float contador = 2f;
	bool diminuircontador = false;

	AudioSource pop;

	// Use this for initialization
	void Start () {

		RectangleAnim = rectangle.GetComponent<Animator> ();
		pop = GetComponent<AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {

		if (diminuircontador) {
		
			contador -= Time.deltaTime;
		}

		if (contador <= 0)
			SceneManager.LoadScene (2);

	}

	public void OnClick()
	{
		diminuircontador = true;
		RectangleAnim.SetBool ("start", true);
		pop.Play ();
	}
}
