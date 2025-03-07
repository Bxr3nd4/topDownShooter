
using UnityEngine;

public class PlayerMovenment : MonoBehaviour
{  
    [SerializeField] float speed;

    private Rigidbody2D rb;
    private Vector2 input;
       void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        ProcessInputs();
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
}
