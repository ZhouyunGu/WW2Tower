using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour
{
    float speed;
    Vector2 _direction;
    bool isReady;

    void Awake()
    {
        speed = 7.0f;
        isReady = false;
    }

    void Start()
    {
    }

    public void SetDirection(Vector2 direction)
    {
        _direction = direction.normalized;

        isReady = true;
    }

    void Update()
    {
        if (isReady)
        {
            Vector2 position = transform.position;
            position += _direction * speed * Time.deltaTime;
            transform.position = position;

            if (position.x >= 20 || position.x <= -20)
            {
                Destroy(gameObject);
            }
        }
    }
}
