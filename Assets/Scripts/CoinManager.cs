using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CoinManager : MonoBehaviour
{

    [SerializeField] int _numberOfCoinsInLevel1;
    [SerializeField] TextMeshProUGUI _text;
    
    public void AddOne() {
        _numberOfCoinsInLevel1 += 1;
        _text.text = _numberOfCoinsInLevel1.ToString();
    }

}
