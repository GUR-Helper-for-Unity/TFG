using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class FollowPlayer : MonoBehaviour
{
    public Transform player;  
    public float smooth = 5f;
    public Vector2 offset = new Vector2(0f, 0f);
    public Transform leftLimit;
    public Transform rightLimit;
    private void Start()
    {
        transform.position = new Vector3(player.position.x + offset.x, transform.position.y + offset.y, transform.position.z);

    }
    void Update()
    {
        float newX = player.position.x + offset.x;

        newX = Mathf.Max(newX, leftLimit.position.x);
        newX = Mathf.Min(newX, rightLimit.position.x);

        Vector3 newPos = new Vector3(newX, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, newPos, smooth * Time.deltaTime);

    }
}
