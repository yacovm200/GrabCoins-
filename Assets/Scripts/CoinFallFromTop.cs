using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinFallFromTop : MonoBehaviour
{

    public Rigidbody rb;

        private void OnCollisionEnter(Collision collision)
    {
       // Debug.Log(gameObject.name + " has colleted with " + collision.gameObject.name);

        if (collision.gameObject.name == "player")
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.transform.position = new Vector3(Random.Range(-10, 10), Random.Range(60, 80), Random.Range(-10, 10));
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector3(0, Random.Range(-20, -5), 0);

         if (transform.position.y <= 1.5)
         {
         gameObject.transform.position = new Vector3(Random.Range(-10, 10), Random.Range(50, 80), Random.Range(-10, 10));
        }
    }
}