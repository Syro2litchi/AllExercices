using System;
using UnityEngine;

namespace EnumerationEtSwitch
{
    [System.Flags]
    public enum WeaponType
    {
        Sword = 1,
        Bow = 2,
        Axe = 4,
        Staff = 8
    }
    public class Bonus : MonoBehaviour
    {

        public WeaponType WeaponType;
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            WeaponType myWeapons = WeaponType.Sword | WeaponType.Axe | WeaponType.Bow | WeaponType.Staff;

            switch (myWeapons)
            {
                case WeaponType.Sword:
                    break;
                case WeaponType.Bow:
                    break;
                case WeaponType.Axe:
                    break;
                case WeaponType.Staff:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            if (myWeapons == (WeaponType)1)
            { 
                Debug.Log("Je possède une hache !");
            }
            if (myWeapons == (WeaponType)2) 
            { 
                Debug.Log("Je possède un arc !");
            }
            if (myWeapons == (WeaponType)3)
            { 
                Debug.Log("Je possède un bâton !");
            }
            if (myWeapons == 0)
            { 
                Debug.Log("Je possède une épée !");
            }
        }
    }
}

