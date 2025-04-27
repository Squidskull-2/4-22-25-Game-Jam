using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectileAttack : MonoBehaviour
{

    public float attackTimer = 3f;
    EnemyMovement movement;
    public GameObject bullet;
    float timer = 0;
    bool playerInRange;

    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<EnemyMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(GameObject.FindWithTag("Player").transform.position, transform.position) <= 5f)
        {
            playerInRange = true;
        }
        else
        {
            playerInRange = false;
        }
        timer += Time.deltaTime;
        if (timer >= attackTimer && playerInRange)
        {
            timer = 0f;
            ShootProjectile();
        }
    }

    void ShootProjectile()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
