using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour
{

    public float speed = 0.1f;
    float direction = 1f;


    // Start is called before the first frame update
    void Start()
    {
        Vector3 centerPosition = new Vector3(0, 0, 0);

        // Transform sqareTransform = GetComponent<Transform>();

        // sqareTransform.position = centerPosition;

        gameObject.transform.position = centerPosition;
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        if (gameObject.transform.position.x > 8 || gameObject.transform.position.x < -8)
        {
            ChangeDirection();
        }

    }

    private void ChangeDirection()
    {
        // Debug.Log("Byter riktning");

        direction *= -1;
    }


    private void Move()
    {
        Vector3 position = gameObject.transform.position;

        position.x += direction * speed;

        gameObject.transform.position = position;
    }
}
