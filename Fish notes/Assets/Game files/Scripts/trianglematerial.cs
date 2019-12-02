using UnityEngine;
using System.Collections;

public class trianglematerial : MonoBehaviour {


	public Material [] texture;

	// Use this for initialization
	void Start () {

		//Debug.Log(texture.Length);
		GetComponent<Renderer>().material=texture[Random.Range(0,texture.Length)];

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
