using UnityEngine;
using System.Collections;

public class cubedestroy : MonoBehaviour {


	private int mbest;



	// Use this for initialization
	void Start () {
		
		mbest=GameManager.best;
	
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision)
	{
		if (collision.transform.tag == "red") {
			collision.gameObject.GetComponent<CreateOnDestroy>().Kill();
			gameObject.GetComponent<CreateOnDestroy>().Kill();
		
						
			SoundManger.Instance.PlayColliderSound();


			Destroy (collision.gameObject);

		    Destroy (gameObject);




			showmenu.Instance.showMenu();

			savePreference();

		



		} else if (collision.transform.tag == "wall") {
		
			Destroy (gameObject);
		}
	}

	public void savePreference(){
		if(addscore.score>mbest){
			PlayerPrefs.SetInt("Best Score",addscore.score);
		}else{
			PlayerPrefs.SetInt("Best Score",mbest);
		}
	}



}
