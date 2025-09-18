using UnityEngine;

namespace BouclesEtCollections
{
    public class Ex1 : MonoBehaviour
    {
        private string camelCase;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int repeatNumber;
            repeatNumber = 7;
            string message = "Décollage dans";
            while (repeatNumber > 0)
            {
                print(message + " " + repeatNumber);
                repeatNumber--;
            }
        }
    }
}