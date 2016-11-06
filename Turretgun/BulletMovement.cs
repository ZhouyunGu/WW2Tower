using UnityEngine;
using System.Collections;

public class BulletMovement : MonoBehaviour
{
    float speed;
    Vector2 _direction;
    bool isReady;
    public int damage = 1;

    void Awake()
    {
        speed = 10.0f;
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
        }
        if(_direction.x == 0 && _direction.y == 0)
        {
            Destroy(gameObject);
        }
    }
}
