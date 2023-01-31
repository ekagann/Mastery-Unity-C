using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UICoinText : MonoBehaviour
{
    private TextMeshProUGUI tmproText;

    private void Awake()
    {
        tmproText = GetComponent<TextMeshProUGUI>();
    }
    private void Start()
    {
        GameManager.Instance.OnCoinsChanged += HandleCoinsChanged;
    }

    private void HandleCoinsChanged(int coins)
    {
        tmproText.text = coins.ToString();
    }

}
