using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Ball : MonoBehaviour
{
    public TMP_Text enemyScoreText;
    public TMP_Text playerScoreText;
    int scorePlayer = 0;
    int scoreEnemy = 0;

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.name.Contains("Gates"))
        {
            print("Goal");
            transform.position = Vector3.zero;
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
        }

        if (other.gameObject.name.Contains("Player Gates"))
        {
            scoreEnemy += 1;
            enemyScoreText.text = scoreEnemy.ToString();
            

        }
        if (other.gameObject.name.Contains("Enemy Gates"))
        {
            scorePlayer += 1;
            playerScoreText.text = scorePlayer.ToString();

        }
    }
}
