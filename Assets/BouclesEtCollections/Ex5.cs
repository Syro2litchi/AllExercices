using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace BouclesEtCollections
{
    public class Ex5 : MonoBehaviour
    {
        public List<GameObject> GameObjectList = new List<GameObject>();

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        private void Start()
        {
            foreach (GameObject g in GameObjectList.ToList())
            {
                Destroy(g);
            }
        }

        // Update is called once per frame
        private void Update()
        {

        }
    }
}