using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows.Speech;

public class BulletController : MonoBehaviour
{
    public int speedBullet = 100;
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * speedBullet);
    }
}
