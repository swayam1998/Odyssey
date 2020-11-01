using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnLogic : MonoBehaviour
{
    public GameObject spawnObj;
    public float spawnTime;
    public float spawnOffset;
    private float timer;
    private float randPos;

    // Start is called before the first frame update
    void Start()
    {
        timer = spawnTime;
    }

    // Update is called once per frame
    void Update()
    {
        randPos = spawnOffset * Random.Range(0f, 100f) * 0.01f;

        if (timer > 0)
        {
            timer -= Time.deltaTime;
        }
        else
        {
            Vector3 spawnPos;
            if((int)randPos / 2 == 1)
                spawnPos = transform.position + new Vector3(randPos, 0, 0);
            else
                spawnPos = transform.position - new Vector3(randPos, 0, 0);

            Instantiate(spawnObj, spawnPos, Quaternion.identity);
            timer = spawnTime;
        }

    }
}
