using UnityEngine;
using System.Collections;

public class collisionenter : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerExit(Collider other){
		if(other.tag=="bigone"||other.tag =="red"){
			other.gameObject.layer=9;
		}
	}

}
