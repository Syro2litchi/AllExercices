using HeritageEtScriptableObjects;
using UnityEngine;

namespace HeritageEtScriptableObject
{
    [CreateAssetMenu(fileName = "RandomWand")]
    public class RandomWand : ThingInHand
    {
        private int RandomNumber;
        
        public override void Use()
        {
            RandomNumber = Random.Range(0, 5);
            switch (RandomNumber)
            {
                case 0:
                    Debug.Log("You can fly");
                    break;
                case 1:
                    Debug.Log("You can breathe underwater");
                    break;
                case 2:
                    Debug.Log("You can resist to fire");
                    break;
                case 3:
                    Debug.Log("You can see through walls");
                    break;
                case 4:
                    Debug.Log("You can walk on water");
                    break;
                case 5:
                    Debug.Log("Nothing happened");
                    break;
            }
            
        }
    }
}

