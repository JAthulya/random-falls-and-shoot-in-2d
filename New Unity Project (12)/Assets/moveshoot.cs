using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveshoot : MonoBehaviour
{
    public GameObject bullet;
    public Transform bulletspawn;
    public float playerspeed = 50f;
    public Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        rotation = new Vector3(0f, 0f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, bulletspawn.position, bulletspawn.rotation);
        }
        transform.Rotate(rotation * playerspeed * Time.deltaTime);
    }
}
