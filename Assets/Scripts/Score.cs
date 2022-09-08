using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoreText;
    public int _score = 0;

    public void ChangeScore(int score)
    {
        _score += score;
        scoreText.text = _score.ToString();
    }
}
