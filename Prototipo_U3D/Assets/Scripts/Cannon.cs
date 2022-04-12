using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{  
    public Transform cannonBase ;
    public Transform cannonTubo ;
    public Transform instaciadorBolas ;
    public GameObject cannonBola ;
    public ParticleSystem[] disparoParticulas ;
    public float velocidadGiroPlataforma = 45 ;
    public float velocidadGiroTubo = 45 ;
    // Start is called before the first frame update
    void Start()
    {
        int longitud = disparoParticulas.Length;
        for (int i = 0; i < longitud; i++) {
            disparoParticulas[i].Stop();
        }
    }

    // Update is called once per frame
    void Update()
    {
        RotarBase();
        RotarTubo(); 
        Disparo();
    }

    private void Disparo()
    {
        if (Input.GetKeyDown(KeyCode.Space)) {
            Instantiate(cannonBola, instaciadorBolas.position, instaciadorBolas.rotation);

            int longitud = disparoParticulas.Length ;
            for (int i = 0; i < longitud; i++) {
                disparoParticulas[i].Play();
            }
        }
    }

    private void RotarTubo()
    {
        if (Input.GetKey(KeyCode.UpArrow)) {
            cannonTubo.Rotate(new Vector3(1 * velocidadGiroTubo * Time.deltaTime, 0, 0));
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            cannonTubo.Rotate(new Vector3(-1 * velocidadGiroTubo * Time.deltaTime, 0, 0));
        }
    }

    private void RotarBase()
    {
        if (Input.GetKey(KeyCode.LeftArrow)) {
            cannonBase.Rotate(new Vector3(0, 0, -1f * velocidadGiroPlataforma * Time.deltaTime));
        }
        if (Input.GetKey(KeyCode.RightArrow)) {
            cannonBase.Rotate(new Vector3(0, 0, 1f * velocidadGiroPlataforma * Time.deltaTime));
        }
    }
}
