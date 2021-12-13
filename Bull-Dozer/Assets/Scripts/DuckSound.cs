using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuckSound : MonoBehaviour
{
    public AudioSource duckSource;
    // Start is called before the first frame update
    void Start()
    {
        duckSource = GetComponent<AudioSource> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "duck")
        {
            duckSource.Play();
        }
    }
}