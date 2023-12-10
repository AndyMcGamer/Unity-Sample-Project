using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class MainGameUI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI speedText;
    [SerializeField] private Rigidbody playerRb;

    private void Update()
    {
        Vector3 velocity = playerRb.velocity;

        float speed = velocity.magnitude;

        speedText.text = speed.ToString() + " m/s";
    }

}
