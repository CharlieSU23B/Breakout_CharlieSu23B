using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float speed = 5f;

    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        direction = new Vector3(1, 1, 0).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction * speed * Time.deltaTime);

        if(transform.position.y < -5)
        {
            transform.position = new Vector3(0, 8, 0);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Brick"))
        {
            Destroy(collision.gameObject);

            direction = Vector3.Reflect(direction, collision.contacts[0].normal);
        }
        else
        {
            direction = Vector3.Reflect(direction, collision.contacts[0].normal);
        }
        

    }
}
