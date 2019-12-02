using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class addscore : MonoBehaviour {
	public Text scoreboard;
	public static int score;

	void Start () {

		score=0;
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter(Collider other){

			if(other.tag=="bigone"){

				score++;

				scoreboard.text=score.ToString();
				
			}
	

	}

}
