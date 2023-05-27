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
    public int maxScore;
    public Animator playerAnim;
    public GameObject player;
    public GameObject endPanel;

    private void Start()
    {
        playerAnim = player.GetComponentInChildren<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            AddBullet();
            Destroy(other.gameObject);
        }
        else if (other.CompareTag("End"))
        {
            playerController.characterSpeed = 0;
            transform.Rotate(transform.rotation.x, 180, transform.rotation.z, Space.Self);
            endPanel.SetActive(true);

            if (score >= maxScore)
            {
                // Debug.Log("You Win!");
                playerAnim.SetBool("win", true);
            }
            else
            {
                // Debug.Log("You Lose!");
                playerAnim.SetBool("lose", true);
            }
        }
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
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
