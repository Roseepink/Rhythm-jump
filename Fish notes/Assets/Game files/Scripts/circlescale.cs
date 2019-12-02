using UnityEngine;
using System.Collections;

public class circlescale : MonoBehaviour {


	// Use this for initialization
	void Start () {
	

	}
	
	// Update is called once per frame
	void Update () {

		StartCoroutine ("ScaleObject");


		if(this.transform.localScale.x>=4){
			Destroy(gameObject);
		}

		SpriteRenderer l = this.gameObject.GetComponent<SpriteRenderer>();
		Color c = new Color();
		if(addscore.score<=10){
			c.r=0.3f;
			c.g=0.7f;
			c.b=0.93f;
			c.a=0.2f; 
			l.color =c;
		}
		else if(addscore.score>10&&addscore.score<=30){
			c.r = 1f; 
			c.g = 0.9f;
			c.b = 0.09f; 
			c.a=0.2f;
			l.color = c; 
		}
		
		else if(addscore.score>30&&addscore.score<=60){
			
			c.r = 0.06f; 
			c.g = 0.81f;
			c.b = 0.17f; 
			c.a =0.2f;
			l.color = c; 
		}
		else if(addscore.score>60&&addscore.score<=100){
			c.r = 1; 
			c.g = 0.12f;
			c.b = 0.37f; 
			c.a =0.2f;
			l.color = c; 
		}
		else{
			c.r=0.19f;
			c.g=0.6f;
			c.b=0.92f;
			c.a =0.2f;
			l.color =c;
		}
	}


	IEnumerator ScaleObject()
	{
		float scaleDuration = 1;                                //animation duration in seconds
		Vector3 actualScale = transform.localScale;             // scale of the object at the begining of the animation
		Vector3 targetScale = new Vector3 (4f,4f,4f);     // scale of the object at the end of the animation

		for(float t = 0; t < 1; t += Time.deltaTime / scaleDuration )
		{
			transform.localScale = Vector3.Lerp(actualScale ,targetScale ,t);
			yield return null;
		}
	}
}
