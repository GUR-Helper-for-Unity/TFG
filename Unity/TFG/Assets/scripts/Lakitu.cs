using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lakitu : MonoBehaviour
{
    public float attackInterval = 5f;
    public Transform spawnPos;
    public GameObject projectilePrefab;


    private void Start()
    {
        InvokeRepeating("spawnProjectile", attackInterval, attackInterval);
    }


    void spawnProjectile()
    {
        Debug.Log("pam");
        Instantiate(projectilePrefab, spawnPos.position, Quaternion.identity);
    }

}
