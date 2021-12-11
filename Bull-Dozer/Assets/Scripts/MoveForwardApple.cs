using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardApple : MonoBehaviour
{
    public AudioSource appleSource;
    public float speed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        appleSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);

        void OnCollisionEnter (Collision collision)
        {
            if(collision.gameObject.tag == "Apple")
            {
                appleSource.Play();
            }
        }
    }
}
