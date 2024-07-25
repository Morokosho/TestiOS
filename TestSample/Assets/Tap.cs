using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Tap : MonoBehaviour
{
    [SerializeField] private Button tapButton;
    [SerializeField] private TextMeshProUGUI numberText;
    void Start()
    {
        tapButton.onClick.AddListener(RandomNumber);
    }

    void RandomNumber()
    {
        numberText.text = Random.Range(0, 101).ToString();
    }
}
