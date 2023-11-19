using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    Transform spawnPosition;
    [SerializeField]
    GameObject prefab;
    [SerializeField]
    float velocidad = 5f;

    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Spawn"))
        {
            Instantiate(prefab, spawnPosition.position, Quaternion.identity, transform);
        }
        Vector3 vel = new Vector3(Input.GetAxis("Horizontal") * velocidad, rb.velocity.y, rb.velocity.z);
        rb.velocity = vel;
    }
}
