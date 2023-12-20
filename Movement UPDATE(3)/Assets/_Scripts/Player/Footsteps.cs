using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Footsteps : MonoBehaviour
{
    public List<AudioClip> WalkSounds;
    public AudioSource audioSource;
    public List<AudioClip> JumpSounds;
    public int position;
    public List<AudioClip> runningSounds;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void runningSound()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(runningSounds[position]);
        }
        position = (int)Mathf.Floor(Random.Range(0, WalkSounds.Count));
        
    }
    public void jumpsound()
    {
        if (!audioSource.isPlaying)
        {
            audioSource.PlayOneShot(JumpSounds[position]);
        }
        position = (int)Mathf.Floor(Random.Range(0, WalkSounds.Count));
        
    }
    public void walkSound()
    {
        position = (int)Mathf.Floor(Random.Range(0, WalkSounds.Count));
        audioSource.PlayOneShot(WalkSounds[position]);
    }


}
   

