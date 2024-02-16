using GURHelper;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    float velocidad = 5f;
    [SerializeField]
    float jumpForce = 10f;

    Rigidbody rb;
    bool inGround = false;

    public int playerLife = 3;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        UIManager.Instance.setLifes(playerLife);
    }

    private void Update()
    {
        Vector3 vel = new Vector3(Input.GetAxis("Horizontal") * velocidad, rb.velocity.y, rb.velocity.z);
        rb.velocity = vel;
        if (inGround && Input.GetKeyDown(KeyCode.Space))
            jump();

    }

    void jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            inGround = true;
        }
        else if (collision.gameObject.CompareTag("projectile"))
        {
            Die();
        }
    }

    void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("ground"))
        {
            inGround = false;
        }
    }

    void Die()
    {
        gameObject.GetComponent<CallEvent>().TrackEvent();
        playerLife--;
        if (playerLife == 0)
        {
            Debug.Log("sacabo");
        }
        UIManager.Instance.setLifes(playerLife);

    }
}
