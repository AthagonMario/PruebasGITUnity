using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SonidoBotones : MonoBehaviour
{

    [SerializeField] AudioClip primerpulso;
    [SerializeField] AudioClip segundopulso;

    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    public void Playprimer()
    {
        audioSource.PlayOneShot(primerpulso);
    }

    public void Playsegun()
    {
        audioSource.PlayOneShot(segundopulso);
    }
}
