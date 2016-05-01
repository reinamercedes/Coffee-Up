using UnityEngine;
using System.Collections;

public class rotate : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.GetComponent<SpriteRenderer> ().sprite=Resources.Load("pattern11",typeof(Sprite)) as Sprite;
	}
}
