using UnityEngine;

namespace BouclesEtCollections
{
    public class Ex1 : MonoBehaviour
    {
        private string _camelCase;
        
        void Start()
        {
            var repeatNumber = 7;
            string message = "Décollage dans";
            while (repeatNumber > 0)
            {
                print(message + " " + repeatNumber);
                repeatNumber--;
            }
        }
    }
}