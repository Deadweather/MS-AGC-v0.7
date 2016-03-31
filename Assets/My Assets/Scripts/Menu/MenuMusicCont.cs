using UnityEngine;
using System.Collections;

public class MenuMusicCont : MonoBehaviour {

    public AudioSource music;
    public AudioClip currentClip;
    public AudioClip musicIntro;
    public AudioClip musicLoop;

    private float musict;

	// Use this for initialization
	void Start () {
        music = GetComponent<AudioSource>();

        currentClip = musicIntro;

        music.clip = currentClip;
        music.Play();

        musict = music.clip.length;

        StartCoroutine(playLoop());
	}

    IEnumerator playLoop()
    {
        yield return new WaitForSeconds(musict);

        currentClip = musicLoop;
        music.clip = currentClip;

        music.Play();

        musict = music.clip.length;

        StartCoroutine(playLoop());
    }
}
