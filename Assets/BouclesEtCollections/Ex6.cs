using System.Collections.Generic;
using UnityEngine;

namespace BouclesEtCollections
{
    public class Ex6 : MonoBehaviour
    {
        public List<GameObject> GameObjectToColorList = new List<GameObject>();

        public GameObject GameObjectToRemove;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            GameObjectToColorList.Remove(GameObjectToRemove);
            foreach (GameObject g in GameObjectToColorList)
            { 
                g.GetComponent<Renderer>().material.color = Color.cornflowerBlue;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
