using UnityEngine;
using System.Collections;

public class CreateOnDestroy : MonoBehaviour {

	
	public bool  killed = false;
	public GameObject[] prefab;
	//public AudioClip diesfx;


	public void  Kill (){
		
		if (killed) return;
		
		killed = true;

		//AudioSource.PlayClipAtPoint(diesfx, gameObject.transform.position);
		
		foreach(var p in prefab) {
			GameObject ins= GameObject.Instantiate(p,transform.position,Random.rotation) as GameObject;
			if (ins.GetComponent<Rigidbody>()) {
				ins.GetComponent<Rigidbody>().velocity =  Random.onUnitSphere*8 + Vector3.up;	
				//audio.PlayOneShot(sfx,1.0f);
				ins.GetComponent<Rigidbody>().AddTorque(Random.onUnitSphere * 1,ForceMode.Impulse);
				Destroy(ins,2);
			}
		}
		
	}
	
}