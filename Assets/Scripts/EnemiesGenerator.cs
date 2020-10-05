using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesGenerator: MonoBehaviour
{
    public GameObject enemyPrefab;

    private float interval;

    private float time = 0f;

    public float minTime = 2f;

    public float maxTime = 5f;

    public float xMinPosition = -12f;

    public float xMaxPosition = 12f;

    public float yMinPosition = 17f;

    public float yMaxPosition = 17f;

    // Start is called before the first frame update
    void Start()
    {
        interval = GetRandomTime();
        
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        if(time > interval)
        {
            GameObject enemy = Instantiate(enemyPrefab);

            enemy.transform.position = GetRandomPosition();

            time = 0f;

            interval = GetRandomTime();
        }
        

    }

    private float GetRandomTime()
    {
        return Random.Range(minTime, maxTime);
    }

    private Vector2 GetRandomPosition()
    {
        float x = Random.Range(xMinPosition, xMaxPosition);
        float y = Random.Range(yMinPosition, yMaxPosition);

        return new Vector2(x, y);
    }

     
    
}
