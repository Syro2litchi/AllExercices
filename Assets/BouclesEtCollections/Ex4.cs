using System.Collections.Generic;
using UnityEngine;

namespace BouclesEtCollections
{
    public class Ex4 : MonoBehaviour
    {
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            List<string> nameList = new List<string>();
            nameList.Add("Alexis");
            nameList.Add("Jordan");
            nameList.Add("Baptiste");
            foreach (string name in nameList)
            {
                print(name);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}