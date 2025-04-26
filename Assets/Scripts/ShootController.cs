using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootController : MonoBehaviour
{
    public GameObject bullet;
    public Transform leftWing;
    public Transform rightWing;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bullet, leftWing.position, bullet.transform.rotation);
            Instantiate(bullet, rightWing.position, bullet.transform.rotation);
        }
    }
}
