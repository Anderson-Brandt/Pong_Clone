using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBall : MonoBehaviour
{
    public GameObject BallPrefab;
    private GameObject currentBall;

    private float timeCount;
    public float spawnTime;

    void Update()
    {
        SpawnCurrentBall();
    }

    public void SpawnCurrentBall()
    {
        if (currentBall == null)
        {
            timeCount += Time.deltaTime;
            if (timeCount >= spawnTime)
            {
                CreateBall();
                timeCount = 0f;
            }

        }
    }

    public void CreateBall()
    {
        GameObject e = Instantiate(BallPrefab, transform.position, transform.rotation);
        currentBall = e;
    }
}
