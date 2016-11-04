using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Turretgun : MonoBehaviour {
    List<GameObject> enemy;
    public GameObject Bulletprefab;
    bool enemyinrange;

    void Awake()
    {
        enemy = new List<GameObject>();
    }

    void Start()
    {
        InvokeRepeating("FireBullet", 1f, 1f);
    }
    void Update()
    {    
    }

    void OnEnemyDestroy(GameObject enemy1)
    {
        enemy.Remove(enemy1);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("enemy"))
        {
            enemy.Add(other.gameObject);
            enemyinrange = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("enemy"))
        {
            enemy.Remove(other.gameObject);
            enemyinrange = false;
        }
    }

    void FireBullet()
    {
        foreach (GameObject enemies in enemy)
        {
            GameObject bullet = (GameObject)Instantiate(Bulletprefab);

            bullet.transform.position = transform.position;

            Vector2 direction = enemies.transform.position - bullet.transform.position;

            bullet.GetComponent<BulletMovement>().SetDirection(direction);
        }
    }
}
