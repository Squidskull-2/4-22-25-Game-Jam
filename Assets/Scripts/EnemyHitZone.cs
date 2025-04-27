using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHitZone : MonoBehaviour
{

    AudioSource source;
    public AudioClip music;
    BoxCollider2D boxCollider;
    SpriteRenderer sprite;

    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();
        boxCollider = GetComponentInParent<BoxCollider2D>();
        sprite = transform.parent.GetChild(0).GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            source.PlayOneShot(music);
            boxCollider.enabled = false;
            sprite.enabled = false;
            Destroy(transform.parent.gameObject, 1.2f);
            if (transform.parent.GetComponent<EnemyProjectileAttack>() != null)
            {
                transform.parent.GetComponent<EnemyProjectileAttack>().enabled = false;
            }
        }
    }
}
