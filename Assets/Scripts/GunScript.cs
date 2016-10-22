using UnityEngine;
using System.Collections;

public class GunScript : MonoBehaviour {

    // Use this for initialization

    private AudioSource audio;

	void Start () {
        EventManager.pressedShoot += PlaySound;
        audio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
	
	}

    void PlaySound()
    {
        audio.Play();
    }
}
