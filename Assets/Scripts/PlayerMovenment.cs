
using UnityEngine;

public class PlayerMovenment : MonoBehaviour
{  
    [SerializeField] float speed;

    private Rigidbody2D rb;
    private Vector2 input;
    private bool isFacingRight = true;
       void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    /// <summary>
    /// Process inputs and flip player if necessary
    void Update()
    {
        ProcessInputs();
        Flip();
    }

    private void ProcessInputs()
    {
        float xInput = Input.GetAxis("Horizontal");
        float yInput = Input.GetAxis("Vertical");
        input = new Vector2(xInput,yInput).normalized;
    }

    private void FixedUpdate()
    {
        rb.velocity = input * speed;
    } 

    private void Flip()
    {
        // si esta mirando a la derecha  y aprieto a la izquierda
        // si esta mirando a la izquierda y aprieto a la derecha
        if(isFacingRight && input.x < 0f || !isFacingRight && input.x > 0f)
        {
            Vector3 scale = transform.localScale;
            scale.x *= -1f;
            transform.localScale = scale;
            isFacingRight = !isFacingRight; 
        }
    }
}
