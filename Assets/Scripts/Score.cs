using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    private GameObject[] rings;
    private int count;
    public static int countRings = 0;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI recordText;

    private void Start()
    {
        rings = GameObject.FindGameObjectsWithTag("Ring");
        count = rings.Length;
        scoreText.text = count.ToString();
        recordText.text = countRings.ToString();
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.CompareTag("Ring"))
        {
            countRings++;
            count--;
            scoreText.text = count.ToString();
            recordText.text = countRings.ToString();
            Destroy(collision.gameObject);
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Asteroid"))
        {
            Destroy(gameObject);
        }
    }
}
