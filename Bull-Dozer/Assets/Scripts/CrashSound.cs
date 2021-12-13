using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrashSound : MonoBehaviour
{
    public AudioSource crashSource;
    // Start is called before the first frame update
    void Start()
    {
        crashSource = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "fence")
        {
            crashSource.Play();
        }
    }
}
