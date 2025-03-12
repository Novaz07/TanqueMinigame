using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score = 0;
    public Text scoreText;

    public void AddPoint()
    {
        score++;
        scoreText.text = "Score: " + score;
    }
}
