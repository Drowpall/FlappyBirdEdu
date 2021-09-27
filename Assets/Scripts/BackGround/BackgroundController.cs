using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [NonSerialized] public GameObject backgroundPiece;

    [SerializeField] public GameObject backgroundPiece1;
    [SerializeField] public GameObject backgroundPiece2;

    public event Action BackgroundPieceTouched;
    private void Start()
    {
        BackgroundPieceTouched += OnBackgroundPieceTouched;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject != backgroundPiece1 && collision.gameObject != backgroundPiece2)
        {
            Debug.LogError("This was supposed to be background\n");
            return;
        }
        backgroundPiece = collision.gameObject;
        BackgroundPieceTouched?.Invoke();
    }

    void OnBackgroundPieceTouched()
    {
        // [1250 (pixels) / 100 (ptx/unit) * 3.65 (scale value) * 2] - 2 (ptx offset);
        backgroundPiece.transform.position += new Vector3(89.25f, 0f, 0f); 
    }
}
