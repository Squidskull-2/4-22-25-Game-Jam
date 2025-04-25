using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed;
    Rigidbody2D rigid;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        Vector2 destination = GameObject.Find("Player").transform.position - transform.position;
        destination.Normalize();
        rigid.AddForce(destination * speed * 50f);
        Object.Destroy(this.gameObject, 5);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Through"))
        {
            Object.Destroy(this.gameObject);
        }
    }
}
