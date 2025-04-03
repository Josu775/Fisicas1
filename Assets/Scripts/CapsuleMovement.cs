using UnityEngine;

public class CapsuleMovement : MonoBehaviour
{
    public float jumpForce = 8f;  // Aumentado para asegurar el salto
    public float speed = 5f;

    private Rigidbody rb;
    private bool canJump;

    void Start()
    {
        rb = GetComponent<Rigidbody>(); // Obtiene el Rigidbody del objeto
    }

    void Update()
    {
        Movement();
        Jump();
    }

    private void Movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Time.deltaTime * Vector3.forward * speed;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Time.deltaTime * Vector3.back * speed;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position += Time.deltaTime * Vector3.left * speed;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position += Time.deltaTime * Vector3.right * speed;
        }
    }

    private void Jump()
    {
        if (canJump && Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Espacio pulsado, intentando saltar");
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse); // Ahora usa IMPULSE
            canJump = false;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            Debug.Log("Tocando el suelo, puede saltar");
            canJump = true;
        }
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Ground"))
        {
            canJump = false;
        }
    }
}
