using UnityEngine;
using System.Collections;

    public class jump : MonoBehaviour {
	private int count=0;
	// Use this for initialization
	void Start () {
	


	}
	
	// Update is called once per frame
	void Update () {
	
	
			
		}



	void OnCollisionEnter(Collision collision )
	{
		count = 0;
	}

	public void Jump()
	{
		

	if (gameObject != null&&count==0) {


		

			gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0,400,0));
			count++;	
		}

	}


}
