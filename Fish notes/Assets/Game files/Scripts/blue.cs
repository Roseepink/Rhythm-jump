using UnityEngine;
using System.Collections;

public class blue : MonoBehaviour {

	private float speed =5;
	private bool isleft=false;



	// Use this for initialization
	void Start () {

	

		if (transform.position.x < -3)
			isleft=true;
		else
			isleft=false;
	
	}
	
	// Update is called once per frame
	void Update () {
	

		if (isleft) {
						transform.Translate (Vector3.right * Time.deltaTime * speed);
				}
		else
			transform.Translate(Vector3.left*Time.deltaTime*speed);
		


	}

	public void setSpeed(float sp)
	{
		speed=speed*sp;
	}

}


