using System.Collections.Generic;
using UnityEngine;

namespace BouclesEtCollections
{
    public class Ex3 : MonoBehaviour
    {
        public List<string> Names;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            for (int i = 0; i < Names.Count; i++)
            {
                print(Names[i]);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}