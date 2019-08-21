using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SquareController : MonoBehaviour
{

    public float speed = 0.1f;
    float direction = 1f;
    public List<Color> colors;
    


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

        if (gameObject.transform.position.x > 9 || gameObject.transform.position.x < -9)
        {
            ChangeDirection();
        }

    }

    private void ChangeDirection()
    {
        // Debug.Log("Byter riktning");

        direction *= -1;
        ChangeColor();
    }


    private void Move()
    {
        Vector3 position = gameObject.transform.position;

        position.x += direction * speed;

        gameObject.transform.position = position;
    }

    private void ChangeColor()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        int random = Random.Range(0, colors.Count);
        spriteRenderer.color = colors[random];
    }
}
