using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

/// <summary>
/// Keeps track of player score and displays it on the screen.
/// </summary>
public class PlayerScore : MonoBehaviour
{
    /// <summary>
    /// Reference to the score UI object's text component.
    /// </summary>
    public Text scoreText = null;

    /// <summary>
    /// The score.
    /// </summary>
    public int score = 2000;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            this.score = this.score - 20;
        }
        this.scoreText.text = "Current Score: " + this.score;
        if (this.score == 0)
        {
            SceneManager.LoadScene("Lose");
        }
    }
    void OnTriggerEnter(Collider other)
    {
        // Check if we collided with an object tagged "Coin".
        if (other.gameObject.tag == "Bullet")
        {
            // We have collided with a coin. 
            // Increment our score.
            this.score = this.score + 100;

            // Display the score.
            this.scoreText.text = "Current Score: " + this.score;

            // Destroy the coin.
            Destroy(other.gameObject);
        }
    }
}
