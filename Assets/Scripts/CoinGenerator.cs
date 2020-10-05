using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinGenerator : MonoBehaviour
{
    public  GameObject CoinPrefab;

    public float xMinPosition = 10f;
    public float xMaxPosition = 10f;
    public float yMinPosition = 10f;
    public float yMaxPosition = 10f;

    private float interval;
    private float time = 0f;
    public float MinTime = 1f;
    public float MaxTime = 2f;


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
            GameObject coin = Instantiate(CoinPrefab);
            coin.transform.position = GetRandomPosition();
            time = 0f;
            interval = GetRandomTime();
        }

        
    }

    private float GetRandomTime()
    {
        return Random.Range(MinTime, MaxTime);
    }

    private Vector2 GetRandomPosition()
    {
        float x = Random.Range(xMinPosition, xMaxPosition);
        float y = Random.Range(yMinPosition, yMaxPosition);

        return new Vector2(x, y);
    }
}
