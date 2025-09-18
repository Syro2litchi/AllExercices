using UnityEngine;

namespace BouclesEtCollections
{
    public class Ex2 : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            int a = 7;
            int b = 7;
            int result = 0;
            for (int i = 0; i < a; i++)
            {
                result += b;
                print("itération : " + i + " result : " + result);
            }

            print("result : " + result);
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}