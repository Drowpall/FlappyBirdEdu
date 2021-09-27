using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] Text score;
    [SerializeField] Text gameOver;
    [SerializeField] Player player;
    [SerializeField] Button restartButton;

    void Update()
    {
        score.text = player.Score.ToString();
    }

    public void PlayDeathSceneUI()
    {
        restartButton.gameObject.SetActive(true);
        score.gameObject.SetActive(false);
        gameOver.text = "Game Over" + "\nYour score is: " + player.Score.ToString();
        gameOver.gameObject.SetActive(true);
    }
}
