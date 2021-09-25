using PlayerLogic.PlayerMovement;
using System;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    [SerializeField] Player player;

    public event Action RegisteredPlayer;

    private void Awake()
    {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    private void Start()
    {
        RegisteredPlayer += OnPlayerScored;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.GetComponentInParent<Player>())
            return;
        RegisteredPlayer?.Invoke();
    }

    void OnPlayerScored()
    {
        player.IncrementScore();
        Debug.Log($"New score: {player.Score}");
    }
}
