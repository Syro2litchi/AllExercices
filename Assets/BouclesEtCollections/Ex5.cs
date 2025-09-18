using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Playables;

namespace BouclesEtCollections
{
    public class Ex5 : MonoBehaviour
    {
        public List<GameObject> GameObjectList = new List<GameObject>();

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            foreach (GameObject g in GameObjectList)
            {
                Destroy(g);
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}