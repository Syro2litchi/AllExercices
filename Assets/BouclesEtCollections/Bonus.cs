using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

namespace BouclesEtCollections
{
    public class Bonus : MonoBehaviour
    {
        private List<Weapon> weaponList = new List<Weapon>();

        private void Start()
        {
            weaponList.Add(new Weapon("Sniper",200, 3, true));
            weaponList.Add(new Weapon("Shotgun",150, 5, true));
            weaponList.Add(new Weapon("Riffle",33, 30, true));

            foreach (Weapon weapon in weaponList)
            {
                print(weapon);
            }
        }
    }
    public class Weapon
    {
        private int _damage;
        private int _clip;
        private bool _ammoInClip;
        private string _name;
        
        public Weapon(string name, int damage, int clip, bool ammoInClip)
        {
            this._damage = damage;
            this._clip = clip;
            this._ammoInClip = ammoInClip;
            this._name = name;
        }

        public override string ToString()
        {
            return
                $"{nameof(_damage)}: {_damage}, {nameof(_clip)}: {_clip}, {nameof(_ammoInClip)}: {_ammoInClip}, {nameof(_name)}: {_name}";
        }
    }
}