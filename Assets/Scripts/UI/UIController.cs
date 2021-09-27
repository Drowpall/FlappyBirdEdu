using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] GameObject deathUI;
    [SerializeField] Text score;
    [SerializeField] TMP_Text gameOver;
    [SerializeField] Player player;
    [SerializeField] Button restartButton;

    void Awake()
    {
        deathUI.gameObject.SetActive(false);
    }

    void Update()
    {
        score.text = player.Score.ToString();
    }

    public void PlayDeathSceneUI()
    {
        score.gameObject.SetActive(false);
        gameOver.text = "Game Over" + "\nScore: " + player.Score.ToString();
        deathUI.gameObject.SetActive(true);
    }
}
