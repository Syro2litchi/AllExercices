using UnityEngine;

namespace HeritageEtScriptableObjects
{
    public class Ex4 : MonoBehaviour
    {
        public Weapon Weapon;
        public Armor Armor;
        
        
        void Start()
        {
            Weapon = new Weapon(10, "Axe", 5);
            Armor = new Armor(10, "Chainmail", 2);
            
            Weapon.Buy();
            Weapon.Attack();
            Armor.Buy();
            Armor.Protect();
        }

        // Update is called once per frame
        void Update()
        {
            
        }
    }

    public abstract class Item
    {
        public int Price;
        public string Name;

        public void Buy()
        {
            Debug.Log("You bought " + Name + " for "  + Price + " gold.");
        }
    }

    public class Weapon : Item
    {
        public int Damage;

        public Weapon(int price, string name, int damage)
        {
            Price = price;
            Name = name;
            Damage = damage;
        }

        public void Attack()
        {
            Debug.Log("You deal " + Damage + " damages with "+ Name);
        }
    }

    public class Armor : Item
    {
        public int Protection;

        public Armor(int price, string name, int protection)
        {
            Price = price;
            Name = name;
            Protection = protection;
        }

        public void Protect()
        {
            Debug.Log(Name + " protects you from " +  Protection + " damages.");
        }
    }

}
