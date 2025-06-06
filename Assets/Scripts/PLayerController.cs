using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLayerController : MonoBehaviour
{
    private int speedAir = 20;
    private float horizontal;
    private float vertical;

    public GameObject gameOverScreen;
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speedAir * Time.deltaTime);
        transform.Translate(Vector3.right * speedAir * Time.deltaTime * horizontal);
        transform.Translate(Vector3.up * speedAir * Time.deltaTime * vertical);

        if(transform.position.x <= -520)
        {
            gameOverScreen.SetActive(true);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            gameOverScreen.SetActive(true);
        }
    }
}
