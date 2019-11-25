using UnityEngine;
using System.Collections;

public class buttonevent : MonoBehaviour {

	public jump targetObject;

	public void Clicked()
	{



		if(targetObject!=null)
		targetObject.Jump ();
	}

}
