using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingMenu : MonoBehaviour {

	public AudioMixer audioMixer;
	public Slider Volume;
	public AudioSource myMusic;

	// Use to change value
	public void SetVolume (float volume) {
		audioMixer.SetFloat ("volume", volume);
	}
}
