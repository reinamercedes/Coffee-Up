using UnityEngine;
using System.Collections;

public class changesize : MonoBehaviour {
	public GameObject imagen;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void cambiartamaño(){
		imagen.transform.localScale = new Vector2 (2f, 2f);
	}
}
