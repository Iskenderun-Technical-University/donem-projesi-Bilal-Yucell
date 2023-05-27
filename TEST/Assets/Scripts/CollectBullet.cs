using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class CollectBullet : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI bulletText;
    public PlayerController playerController;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            AddBullet();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("End"))
        {
            Debug.Log("Congrats!");
            playerController.characterSpeed = 0;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collision"))
        {
            Debug.Log("Touched Obstacle!");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    public void AddBullet()
    {
        score++;
        bulletText.text = "Score: " + score.ToString();
    }
}
