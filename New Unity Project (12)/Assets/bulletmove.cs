using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletmove : MonoBehaviour
{
    public float speed = 12f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        Destroy(this.gameObject, 2f);
    }
    void OnTriggerEnter2D (Collider2D other)
    {
        GameObject enemy = other.GetComponent<GameObject>();
        if(enemy != null)
        {
           
            Destroy(this.gameObject);
        }
    }
}
