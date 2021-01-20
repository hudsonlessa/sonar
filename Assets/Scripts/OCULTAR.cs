using UnityEngine;
using System.Collections;

public class OCULTAR : MonoBehaviour {

	[SerializeField]
	MeshRenderer obj;

    bool ativado = true;

    [SerializeField]
	GameObject canvas;
	
    // Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (obj.enabled == true)

			canvas.SetActive (true);
		 else
			canvas.SetActive (false);
	}
}
