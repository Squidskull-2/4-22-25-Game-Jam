using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectileAttack : MonoBehaviour
{

    public float attackTimer = 3f;
    EnemyMovement movement;
    public GameObject bullet;

    // Start is called before the first frame update
    void Start()
    {
        movement = GetComponent<EnemyMovement>();
        InvokeRepeating("ShootProjectile", 1f, attackTimer);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ShootProjectile()
    {
        Instantiate(bullet, transform.position, Quaternion.identity);
    }
}
