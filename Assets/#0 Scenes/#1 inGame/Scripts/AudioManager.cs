using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource audioSource;
    public AudioSource BGM;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();

        BGM.Play();

    }
}