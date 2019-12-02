using UnityEngine;
using System.Collections;

public class SoundManger : Singleton<SoundManger> {

	public AudioSource ColliderSound;

	public AudioClip colliderClip;

	public void PlayColliderSound()
	{
		ColliderSound.clip=colliderClip;
		ColliderSound.Play();
	}

}
