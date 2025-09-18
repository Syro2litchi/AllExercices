using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

namespace BouclesEtCollections
{
    public class Bonus : MonoBehaviour
    {
        
    }
    public class Weapon : MonoBehaviour
    {
        private int damage;
        private int clip;
        private bool ammoInClip;
        private string name;

        private List<Weapon> weaponList = new List<Weapon>();
        public Weapon(string name, int damage, int clip, bool ammoInClip)
        {
            this.damage = damage;
            this.clip = clip;
            this.ammoInClip = ammoInClip;
            this.name = name;
        }

        void start()
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
}