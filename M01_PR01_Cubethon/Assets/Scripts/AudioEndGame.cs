using UnityEngine;

public class AudioEndGame : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GameObject.Find("Player").GetComponent<AudioSource>();
    }

    public void playSound()
    {
        audioSource.Play();
    }
}
