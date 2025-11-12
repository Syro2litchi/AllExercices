using UnityEngine;

namespace HeritageEtScriptableObjects
{
    public class Ex2 : MonoBehaviour
    {
        public Dog WoofGang;
        void Start()
        {
            WoofGang = new Dog(true);
            WoofGang.Bark();
            WoofGang.Die();
            Debug.Log(WoofGang.IsAlive);
            WoofGang.Bark();
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }

    public abstract class Animal
    {
        public bool IsAlive;

        public void Die()
        {
            IsAlive = false;
        }
    }
    
    public abstract class Mammal : Animal
    {
        public int PawNumber;
    }

    public class Dog : Mammal
    {
        public Dog(bool isAlive)
        {
            IsAlive = isAlive;
            PawNumber = 4;
        }

        public void Bark()
        {
            if (IsAlive)
            {
                Debug.Log("Woof !");
            }
        }
    }
    
}

