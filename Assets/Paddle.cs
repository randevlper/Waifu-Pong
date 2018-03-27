using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{

    public float speed;
    public float hitSpeed = 10;

    [Range(0, 1)]
    public int player;

    public float maxY = 1.86f;

    // Use this for initialization
    void Start()
    {

    }

    public void MoveUp()
    {
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        ClampY();
    }

    public void MoveDown()
    {
        transform.Translate(-Vector2.up * speed * Time.deltaTime);
        ClampY();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Ball")
        {
            Rigidbody2D otherRB = other.gameObject.GetComponent<Rigidbody2D>();
            otherRB.AddForce(new Vector2((player > 0 ? -1 : 1) * hitSpeed, 0));
        }
    }

    void ClampY()
    {
        float clampedY = Mathf.Clamp(transform.position.y, -maxY, maxY);
        transform.position = new Vector2(transform.position.x, clampedY);
    }
}
