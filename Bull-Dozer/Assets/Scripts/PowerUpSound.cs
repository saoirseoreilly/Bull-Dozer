using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSound : MonoBehaviour
{
    public AudioSource powerupaudio;

    // Start is called before the first frame update
    void Start()
    {
        powerupaudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Farmer")
        {
            powerupaudio.Play();
        }
    }
}

