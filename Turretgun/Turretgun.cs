using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Turretgun : MonoBehaviour {
    List<GameObject> enemy;
    public GameObject Bulletprefab;

    void Start()
    {
        enemy = new List<GameObject>();
        InvokeRepeating("FireBullet", 1f, 0.5f);
    }
    void Update()
    {
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("enemy") && !enemy.Contains(other.gameObject))
        {
            enemy.Add(other.gameObject);
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("enemy") && enemy.Contains(other.gameObject))
        {
            enemy.Remove(other.gameObject);
            if(other.gameObject != null)
            {
                enemy.Remove(other.gameObject);
            }
        }
        if (other.CompareTag("TurretBullet"))
        {
            Destroy(other.gameObject);
        }
    }

    void FireBullet()
    {
        if (enemy[0] != null)
        {
            if (enemy[0].transform.position.x > (transform.position.x + 2))
            {
                enemy.Remove(enemy[0]);
            }
            GameObject bullet = (GameObject)Instantiate(Bulletprefab);

            bullet.transform.position = transform.position;

            Vector2 direction = enemy[0].transform.position - bullet.transform.position;

            bullet.GetComponent<BulletMovement>().SetDirection(direction);

            AudioSource firesound = gameObject.GetComponent<AudioSource>();
            firesound.PlayOneShot(firesound.clip);
        }
        else
        {
            enemy.Remove(enemy[0]);
        }
    }
}
