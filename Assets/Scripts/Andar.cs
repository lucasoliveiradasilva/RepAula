using UnityEngine;
using UnityEngine.Rendering;

public class Andar : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    public bool isGrounded;

    public Rigidbody rb;

    public void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveX, 0, moveY);
        transform.Translate(movement * speed * Time.deltaTime);

        if (Input.GetKey(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
        }

    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            isGrounded = true;
        }
    }
}