using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enimspawn : MonoBehaviour
{
    
    float randomx;
    public Vector2 wheretospawn;
    public float spawnrate = 2f;
    float nextspawn = 0f;
    public GameObject enemy;  
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nextspawn)
        {
            nextspawn = Time.time + spawnrate;
            randomx = Random.Range(-4f, 4f);
            wheretospawn = new Vector2(randomx, transform.position.y);
            Instantiate(enemy, wheretospawn, Quaternion.identity);
        }
    }
}
