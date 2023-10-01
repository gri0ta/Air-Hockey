using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class Ball : MonoBehaviour
{
    public TMP_Text enemyScore2;
    public TMP_Text playerScore2;
    int Playerscore = 0;
    int Enemyscore = 0;

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
            Enemyscore += 1;
            enemyScore2.text = Enemyscore.ToString();
            

        }
        if (other.gameObject.name.Contains("Enemy Gates"))
        {
            Playerscore += 1;
            playerScore2.text = Playerscore.ToString();

        }
    }
}
