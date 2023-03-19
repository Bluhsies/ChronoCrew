using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSound : MonoBehaviour
{

    [SerializeField]
    new AudioSource soundClip;
    [SerializeField]
    private AudioClip hit;
    
    // When the player character collides with one of the items, a new audio source will be created.
    void Start()
    {
        soundClip = (AudioSource)gameObject.AddComponent<AudioSource>();
    }

    // When the collision happens between the player character and item, PlayOneShot will mean that the sound is only played once and will be played at a volume of 1.
    void OnTriggerEnter2D(Collider2D collision)
    {

        soundClip.PlayOneShot(hit, 1);

    }


}
