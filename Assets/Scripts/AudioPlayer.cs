using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
	public static AudioPlayer instance;
	public float repeatableWait;
	public AudioClip[] anuncios;

	void Awake() {
		if (AudioPlayer.instance) Destroy(this);
		AudioPlayer.instance=this;
		StartCoroutine(instance.PlayRepeatableAnnouncement(1));
	}

	IEnumerator PlayRepeatableAnnouncement(int id) {
		AudioSource[] audios = GetComponents<AudioSource>();
		yield return new WaitForSeconds(repeatableWait+audios[id].clip.length);
		if (!StationAlarm.instance.alarmOn) {
			audios[id].clip = anuncios[Random.Range(0, anuncios.Length)];
			instance.PlayAudio(id, 0);
			StartCoroutine(instance.PlayRepeatableAnnouncement(id));
		}
	}

	public void PlayAudio(int id, float delay) {
		AudioSource[] audios = GetComponents<AudioSource>();
		audios[id].PlayDelayed(delay);
	}
}
