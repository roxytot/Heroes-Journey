using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectLanguage : MonoBehaviour
{
    public int score = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Language"))
        {
            ScoreScript.scoreValue += 1;
            score += 1;
            Debug.Log(score);
        }
    }

}
