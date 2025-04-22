using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPlatform : MonoBehaviour
{
    public float speed;
    public float moveTime;

    private bool dirUp = true;
    private float timer;

    void Update()
    {
        if (dirUp)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.down * speed * Time.deltaTime);
        }

        timer += Time.deltaTime;
        if (timer >= moveTime)
        {
            dirUp = !dirUp;
            timer = 0f;
        }
    }
}
