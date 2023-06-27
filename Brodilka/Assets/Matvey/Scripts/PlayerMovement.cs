using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float maxSpeed = 10f;
    private bool flipRight = true;
    [HideInInspector]
    public Rigidbody2D m_Rigidbody2D;
    Vector2 force = new Vector2(0, 700);
    public bool inAir;


    void Start()
    {
        m_Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    void Update()
    {

        float move = Input.GetAxis("Horizontal");
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);

        if (move > 0 && !flipRight)
        {
            Flip();
        }
        if (move < 0 && flipRight)
        {
            Flip();
        }
        if (Input.GetKeyDown(KeyCode.Space) && !inAir)
        {
            m_Rigidbody2D.AddForce(force);
        }

    }
    private void Flip()
    {
        flipRight = !flipRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            inAir = false;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            inAir = true;
        }
    }
}


