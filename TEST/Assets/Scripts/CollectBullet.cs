using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectBullet : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI bulletText;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            AddBullet();
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collision"))
        {
            Debug.Log("Touched Obstacle!");
        }
    }

    public void AddBullet()
    {
        score++;
        bulletText.text = "Score: " + score.ToString();
    }
}
