using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField]
    private InfoWeapon _infoweapon;

    public InfoWeapon Infoweapon { get => _infoweapon; set => _infoweapon = value; }

    public void Init()
    {
        
    }
}
