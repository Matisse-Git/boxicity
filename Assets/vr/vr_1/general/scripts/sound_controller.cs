using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sound_controller : MonoBehaviour
{

    //wav imports
    [SerializeField]
    private AudioClip happySong;
    [SerializeField]
    private AudioClip parkNoises;
    private AudioSource audioSource;

    //script bools
    private bool backgroundSoundActive = false;

    //script objects
    private quadrant_checker qc;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        qc = GetComponent<quadrant_checker>();

        if (!backgroundSoundActive)
            InitBackgroundSounds();
    }

    void Update()
    {

    }

    private void InitBackgroundSounds()
    {
        audioSource.PlayOneShot(happySong, 0.1f);
        audioSource.PlayOneShot(parkNoises, 0.2f);
        backgroundSoundActive = true;
    }
}
