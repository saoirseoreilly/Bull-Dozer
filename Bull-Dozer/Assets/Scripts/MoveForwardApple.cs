using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardApple : MonoBehaviour
{
    private AudioSource AppleSound;
    public float speed = 40.0f;
    // Start is called before the first frame update
    void Start()
    {
        AppleSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime * speed);

    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Powerup")
        {
            AppleSound.Play();
        }

    }
}
