using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class PlayerUI : MonoBehaviour
{
    public Health healthPlayer;
    public CoinsCounter coinsPlayer;
    public TextMeshProUGUI coinsCounterText;
    public Slider healthSlider;
    // Update is called once per frame
    void Update()
    {
        coinsCounterText.text = coinsPlayer.coins.ToString();
        healthSlider.maxValue = healthPlayer.maxHealth;

    }
}
