using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gate : MonoBehaviour
{

    [SerializeField] int _value;
    [SerializeField] DeformationType _deformationType;
    [SerializeField] GateAppearance _gateAppearance;

    private void OnValidate()
    {
        _gateAppearance.UpdateVisual(_deformationType, _value);
    }

}
