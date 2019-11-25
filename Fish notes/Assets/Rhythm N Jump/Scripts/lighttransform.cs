using UnityEngine;
using System.Collections;

public class lighttransform : MonoBehaviour {

	//public Color[] colors;

	// Use this for initialization
	/*
	void OnGameStart()
	{
		Debug.Log ("AA");
		this.gameObject.GetComponent<Light>().Color = colors[ UnityEngine.Random.Range(0,colors.Length)];
	}
*/
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		Light l = this.gameObject.GetComponent<Light>();
		Color c = new Color();
		if(addscore.score<=10){
			c.r=0.19f;
			c.g=0.6f;
			c.b=0.92f;
			l.color =c;
		}
		else if(addscore.score>10&&addscore.score<=30){
			c.r = 1; 
			c.g = 0.9f;
			c.b = 0.09f; 
			l.color = c; 
		}

		else if(addscore.score>30&&addscore.score<=60){
		
			c.r = 0.06f; 
			c.g = 0.81f;
			c.b = 0.17f; 
			l.color = c; 
		}
		else if(addscore.score>60&&addscore.score<=100){
			c.r = 1; 
			c.g = 0.12f;
			c.b = 0.37f; 
			l.color = c; 
		}
		else{
			c.r=0.19f;
			c.g=0.6f;
			c.b=0.92f;
			l.color =c;
		}

	}
}
