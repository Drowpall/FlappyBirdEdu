using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [SerializeField] Text score;
    [SerializeField] Player player;

    void Update()
    {
        score.text = player.Score.ToString();
    }
}
