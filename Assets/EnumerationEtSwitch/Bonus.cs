using UnityEngine;

namespace EnumerationEtSwitch
{
    [System.Flags]
    enum WeaponType
    {
        Sword,
        Bow,
        Axe,
        Staff
    }
    public class Bonus : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            WeaponType myWeapons = WeaponType.Sword | WeaponType.Axe | WeaponType.Bow | WeaponType.Staff;
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

