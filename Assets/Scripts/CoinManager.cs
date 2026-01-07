using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour
{

    [SerializeField] int _numberOfCoinsInLevel1;
    
    public void AddOne() {
        _numberOfCoinsInLevel1 += 1;
    }

}
