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

    public void AddBullet()
    {
        score++;
        bulletText.text = "Score: " + score.ToString();
    }
}
