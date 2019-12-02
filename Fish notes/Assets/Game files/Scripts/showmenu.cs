using UnityEngine;
using System.Collections;


public class showmenu : Singleton<showmenu> {



	

	public GameObject menuboard;


	public bool ismenushow=false;
	public Color[] colors;


	void Start(){

		Application.targetFrameRate = 60;

	


		OnGameStart();

	}



	public void showMenu()
	{
		if (!ismenushow) {
		   ismenushow = true;
			Gameover ();
				}
	}

	void OnGameStart()
	{
		//to change background color RANDOMLY
		Camera.main.backgroundColor  = colors[ UnityEngine.Random.Range(0,colors.Length)];
	}


	IEnumerator  PrepareAD (){
		


			
		menuboard.SetActive (true);
	    yield return new WaitForSeconds (1.5f);
	
		//show your AD here
				
	}
	
	public void  Gameover (){
		
		
		StartCoroutine(PrepareAD());
	}





	


}
