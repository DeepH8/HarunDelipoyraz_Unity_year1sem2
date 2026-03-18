using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;
    public float speed = 10f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Debug.Log("Start function in playermovement script");

        rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {

        float moveX = Input.GetAxis("Horizontal");
        float moveZ = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (moveX, 0.5f , moveZ);

        rb.AddForce(movement * speed);

    }

}
