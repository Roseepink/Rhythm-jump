using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class changescorecolor : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		Text l = this.gameObject.GetComponent<Text>();
		Color c = new Color();
		if(addscore.score<=10){
			c.r=0.3f;
			c.g=0.7f;
			c.b=0.93f;
			c.a=1f; 
			l.color =c;
		}
		else if(addscore.score>10&&addscore.score<=30){
			c.r = 1f; 
			c.g = 0.9f;
			c.b = 0.09f; 
			c.a=1f;
			l.color = c; 
		}
		
		else if(addscore.score>30&&addscore.score<=60){
			
			c.r = 0.06f; 
			c.g = 0.81f;
			c.b = 0.17f; 
			c.a =1f;
			l.color = c; 
		}
		else if(addscore.score>60&&addscore.score<=100){
			c.r = 1; 
			c.g = 0.12f;
			c.b = 0.37f; 
			c.a =1f;
			l.color = c; 
		}
		else{
			c.r=0.19f;
			c.g=0.6f;
			c.b=0.92f;
			c.a =1f;
			l.color =c;
		}

	}
}
