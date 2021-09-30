using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundController : MonoBehaviour
{
    [NonSerialized] public GameObject backgroundImage;

    [SerializeField] public GameObject backgroundImageLeft;
    [SerializeField] public GameObject backgroundImageRight;

    public event Action BackgroundImageTouched;
    private void Start()
    {
        BackgroundImageTouched += OnBackgroundImageTouched;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag != "Background")
        {
            return;
        }
        backgroundImage = collision.gameObject;
        BackgroundImageTouched?.Invoke();
    }

    void OnBackgroundImageTouched()
    {
        // [1250 (pixels) / 100 (ptx/unit) * 3.65 (scale value) * 2] - 2 (ptx offset);
        backgroundImage.transform.position += new Vector3(89.25f, 0f, 0f); 
    }

    public void StopBackgroundMovement()
    {
        backgroundImageLeft.GetComponent<Mover>().enabled = false;
        backgroundImageRight.GetComponent<Mover>().enabled = false;
    }
}
