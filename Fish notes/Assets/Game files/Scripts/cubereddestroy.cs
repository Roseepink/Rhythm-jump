using UnityEngine;
using System.Collections;

public class cubereddestroy : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		//Destroy (gameObject, 2);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter(Collision collision)
	{
		if(collision.transform.tag=="wall")
			Destroy (gameObject);
		
	}
}