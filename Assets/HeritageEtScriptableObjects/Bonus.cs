using UnityEngine;

namespace HeritageEtScriptableObjects
{
    public class Bonus : MonoBehaviour
    {
        public ThingInHand ThingInHand;
        void Start()
        {
        
        }

        void Update()
        {
            if (ThingInHand && Input.GetButtonDown("Fire1"))
            {
                ThingInHand.Use();
            }
        }
    }
    
    public abstract class ThingInHand : ScriptableObject
    {
        public abstract void Use();
    }

}
