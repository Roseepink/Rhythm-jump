using UnityEngine;
using System.Collections;

public class back_spawn : MonoBehaviour {

	public GameObject circle;
	public GameObject circle2;
	public float circlerate =0.1f;
	public float circlerate2 =0.1f;

	// Use this for initialization
	void Start () {

		InvokeRepeating("Circle",1f,circlerate);
		InvokeRepeating("Circle",1.5f,circlerate2);
	}



	public void Circle(){

		GameObject.Instantiate(circle,new Vector3(transform.position.x,transform.position.y,transform.position.z),Quaternion.identity);
	}
}
