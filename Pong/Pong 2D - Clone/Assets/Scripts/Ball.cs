using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public float speed = 5f;

    // Start is called before the first frame update
    void Start()
    {
        float speedX = Random.Range(0, 2) == 0 ? -1 : 1;
        float speedY = Random.Range(0, 2) == 0 ? -1 : 1;

        GetComponent<Rigidbody>().velocity = new Vector3(speed * speedX, speed * speedY, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider collision)
    {
        if(collision.gameObject.layer == 6)
        {
            Destroy(gameObject);
            AudioController.currentAudio.PlayMusic(AudioController.currentAudio.points);
            Points.points.AddLeftPoints();
        }

        if (collision.gameObject.layer == 7)
        {
            Destroy(gameObject);
            AudioController.currentAudio.PlayMusic(AudioController.currentAudio.points);
            Points.points.AddRightPoints();
        }
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == 8)
        {
            AudioController.currentAudio.PlayMusic(AudioController.currentAudio.pong);
        }

        if (collision.gameObject.layer == 9)
        {
            AudioController.currentAudio.PlayMusic(AudioController.currentAudio.pongPlatform);
        }
    }
}
