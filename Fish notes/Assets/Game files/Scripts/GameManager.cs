using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameManager : MonoBehaviour {

	public GameObject left;
	public GameObject right;
	public GameObject cubeprefabred;
	public GameObject cubeprefabblue;
	public GameObject secondcubered;
	public GameObject secondcubeblue;
	public GameObject thirdcubered;
	public GameObject thirdcubeblue;
	public GameObject forthcubered;
	public GameObject forthcubeblue;
	private GameObject bulletleft;
	private GameObject bulletright;

	private float timepadding=0;

	public buttonevent rightButton;
	public buttonevent leftButton;
	public static int best;

	public Text bestscoreboard;


	// Use this for initialization
	void Start () {
		best=PlayerPrefs.GetInt("Best Score",0);
	

	}
	
	// Update is called once per frame
	void Update () {

		if(best>=addscore.score){
			bestscoreboard.text="Best:"+best.ToString();
		}else{
			bestscoreboard.text="Best:"+addscore.score.ToString();
		}


		if(!showmenu.Instance.ismenushow){
			timepadding+=Time.deltaTime;
			
			if (timepadding >= 2f) {
				timepadding=0;
			
				if(Random.Range(0,2)==1)//random between 0 and 2
				{
					if(addscore.score<=10){
						bulletleft= (GameObject)Instantiate (cubeprefabred, left.transform.position, Quaternion.identity) as GameObject;
						bulletright= (GameObject)Instantiate (cubeprefabblue, right.transform.position, Quaternion.identity) as GameObject;}
					else if(addscore.score>10&&addscore.score<=30){
						bulletleft= (GameObject)Instantiate (secondcubered, left.transform.position, Quaternion.identity) as GameObject;
						bulletright= (GameObject)Instantiate (secondcubeblue, right.transform.position, Quaternion.identity) as GameObject;}
					else if(addscore.score>30&&addscore.score<=60){
						bulletleft= (GameObject)Instantiate (thirdcubered, left.transform.position, Quaternion.identity) as GameObject;
						bulletright= (GameObject)Instantiate (thirdcubeblue, right.transform.position, Quaternion.identity) as GameObject;}
					else if(addscore.score>60&&addscore.score<=100){
						bulletleft= (GameObject)Instantiate (forthcubered, left.transform.position, Quaternion.identity) as GameObject;
						bulletright= (GameObject)Instantiate (forthcubeblue, right.transform.position, Quaternion.identity) as GameObject;}
					else {
						bulletleft= (GameObject)Instantiate (cubeprefabred, left.transform.position, Quaternion.identity) as GameObject;
						bulletright= (GameObject)Instantiate (cubeprefabblue, right.transform.position, Quaternion.identity) as GameObject;}
				


					 if(addscore.score>5)
					{
						bulletright.GetComponent<blue>().setSpeed(1.1f);
						bulletleft.GetComponent<red>().setSpeed(1.1f);
					}else if(addscore.score>10)
					{
						bulletright.GetComponent<blue>().setSpeed(1.15f);
						bulletleft.GetComponent<red>().setSpeed(1.15f);

					}
					else if(addscore.score>20)
					{
						bulletright.GetComponent<blue>().setSpeed(1.18f);
						bulletleft.GetComponent<red>().setSpeed(1.18f);
						
					}
					else if(addscore.score>30)
					{
						bulletright.GetComponent<blue>().setSpeed(1.3f);
						bulletleft.GetComponent<red>().setSpeed(1.3f);
						
					}
					else if(addscore.score>40)
					{
						bulletright.GetComponent<blue>().setSpeed(1.4f);
						bulletleft.GetComponent<red>().setSpeed(1.4f);
						
					}
					else if(addscore.score>50)
					{
						bulletright.GetComponent<blue>().setSpeed(1.5f);
						bulletleft.GetComponent<red>().setSpeed(1.5f);
						
					}
					else if(addscore.score>60)
					{
						bulletright.GetComponent<blue>().setSpeed(1.8f);
						bulletleft.GetComponent<red>().setSpeed(1.8f);
						
					}
					else if(addscore.score>70)
					{
						bulletright.GetComponent<blue>().setSpeed(1.9f);
						bulletleft.GetComponent<red>().setSpeed(1.9f);
						
					}
					else if(addscore.score>80)
					{
						bulletright.GetComponent<blue>().setSpeed(2f);
						bulletleft.GetComponent<red>().setSpeed(2f);
						
					}
					else if(addscore.score>100)
					{
						bulletright.GetComponent<blue>().setSpeed(2.5f);
						bulletleft.GetComponent<red>().setSpeed(2.5f);
						
					}
				}
				else{
					if(addscore.score<=10){
					    bulletright=(GameObject)Instantiate (cubeprefabred, right.transform.position, Quaternion.identity)as GameObject;
						bulletleft=(GameObject)	Instantiate (cubeprefabblue, left.transform.position, Quaternion.identity)as GameObject;}
				    else if(addscore.score>10&&addscore.score<=30){
						bulletright=(GameObject)Instantiate (secondcubered, right.transform.position, Quaternion.identity)as GameObject;
						bulletleft=(GameObject)	Instantiate (secondcubeblue, left.transform.position, Quaternion.identity)as GameObject;
					}
					else if(addscore.score>30&&addscore.score<=60){
						bulletright=(GameObject)Instantiate (thirdcubered, right.transform.position, Quaternion.identity)as GameObject;
						bulletleft=(GameObject)	Instantiate (thirdcubeblue, left.transform.position, Quaternion.identity)as GameObject;
					}
					else if(addscore.score>60&&addscore.score<=100){
						bulletright=(GameObject)Instantiate (forthcubered, right.transform.position, Quaternion.identity)as GameObject;
						bulletleft=(GameObject)	Instantiate (forthcubeblue, left.transform.position, Quaternion.identity)as GameObject;
					}
					else {
						bulletright=(GameObject)Instantiate (cubeprefabred, right.transform.position, Quaternion.identity)as GameObject;
						bulletleft=(GameObject)	Instantiate (cubeprefabblue, left.transform.position, Quaternion.identity)as GameObject;
					}
				
				

					if(addscore.score>=5)
					{
						bulletright.GetComponent<red>().setSpeed(1.1f);
						bulletleft.GetComponent<blue>().setSpeed(1.1f);
					}else if(addscore.score>10)
					{
						bulletright.GetComponent<blue>().setSpeed(1.15f);
						bulletleft.GetComponent<red>().setSpeed(1.15f);
					}
					else if(addscore.score>20)
					{
						bulletright.GetComponent<blue>().setSpeed(1.18f);
						bulletleft.GetComponent<red>().setSpeed(1.18f);
						
					}
					else if(addscore.score>30)
					{
						bulletright.GetComponent<blue>().setSpeed(1.3f);
						bulletleft.GetComponent<red>().setSpeed(1.3f);
						
					}
					else if(addscore.score>40)
					{
						bulletright.GetComponent<blue>().setSpeed(1.4f);
						bulletleft.GetComponent<red>().setSpeed(1.4f);
						
					}
					else if(addscore.score>50)
					{
						bulletright.GetComponent<blue>().setSpeed(1.5f);
						bulletleft.GetComponent<red>().setSpeed(1.5f);
						
					}
					else if(addscore.score>60)
					{
						bulletright.GetComponent<blue>().setSpeed(1.8f);
						bulletleft.GetComponent<red>().setSpeed(1.8f);
						
					}
					else if(addscore.score>70)
					{
						bulletright.GetComponent<blue>().setSpeed(1.9f);
						bulletleft.GetComponent<red>().setSpeed(1.9f);
						
					}
					else if(addscore.score>80)
					{
						bulletright.GetComponent<blue>().setSpeed(2f);
						bulletleft.GetComponent<red>().setSpeed(2f);
						
					}
					else if(addscore.score>100)
					{
						bulletright.GetComponent<blue>().setSpeed(2.5f);
						bulletleft.GetComponent<red>().setSpeed(2.5f);
						
					}

				}


				rightButton.targetObject=bulletright.GetComponent<jump>();
				leftButton.targetObject=bulletleft.GetComponent<jump>();

			
			}
		}
	}


}
