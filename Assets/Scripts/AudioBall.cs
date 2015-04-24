using UnityEngine;
using System.Collections;

public class AudioBall : MonoBehaviour {

    AudioSource soundSource;
    float rndPitch;

    void Awake()
    {
        soundSource = GetComponent<AudioSource>();
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Wall")
        {
            rndPitch = Random.Range(1.1f, 1.4f);
            soundSource.pitch = rndPitch;
            soundSource.Play();
        }
    }
}
