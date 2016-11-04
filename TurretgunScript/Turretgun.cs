using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Turretgun : MonoBehaviour {

    public GameObject Bulletprefab;

    void Start()
    {       
    }

    void Update()
    {

    }

    void FireBullet()
    {
        GameObject Enemy = GameObject.FindWithTag("enemy");

        if(Enemy != null)
        {
            GameObject bullet = (GameObject)Instantiate(Bulletprefab);

            bullet.transform.position = transform.position;

            Vector2 direction = Enemy.transform.position - bullet.transform.position;

            bullet.GetComponent<BulletMovement>().SetDirection(direction);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("enemy"))
        {
            Invoke("FireBullet", 1f);
        }
    }
}
