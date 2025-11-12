using UnityEngine;

namespace HeritageEtScriptableObjects
{
    public class Ex6 : MonoBehaviour
    {
        public OneHandedItem RightHand;
        public OneHandedItem LeftHand;
        
        void Start()
        {
            
        }
        
        void Update()
        {
            if (RightHand && Input.GetButtonDown("Fire1"))
            {
                RightHand.Use();
            }
            
            if (LeftHand && Input.GetButtonDown("Fire1"))
            {
                LeftHand.Use();
            }
        }
    }

    public abstract class OneHandedItem : ScriptableObject
    {
        public string TextSound;

        public abstract void Use();
    }

    [CreateAssetMenu(fileName = "MeleeWeapon")]
    public class MeleeWeapon : OneHandedItem
    {
        public int Damage;

        public override void Use()
        {
            Debug.Log(TextSound + " : You attack with" + name + " dealing " + Damage + " damages.");
        }
    }
    
    [CreateAssetMenu(fileName = "Shield")]
    public class Shield : OneHandedItem
    {
        public int Protection;

        public override void Use()
        {
            Debug.Log(TextSound + " : You raise " + name + " protecting from " + Protection + " damages.");
        }
    }

}