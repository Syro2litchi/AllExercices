using System.Collections.Generic;
using UnityEngine;

namespace EnumerationEtSwitch
{
    public class Ex6 : MonoBehaviour
    {
        public enum ColorChoice
        {
            Red,
            Green,
            Blue,
            Yellow,
        }

        public List<GameObject> objectsToColor;

        public ColorChoice selectedColor;
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Update()
        {
            foreach (GameObject g in objectsToColor)
            {
                switch (selectedColor)
                {
                    case ColorChoice.Red:
                        g.GetComponent<Renderer>().material.color = Color.red;
                        break;
                    case ColorChoice.Green:
                        g.GetComponent<Renderer>().material.color = Color.green;
                        break;
                    case ColorChoice.Blue:
                        g.GetComponent<Renderer>().material.color = Color.blue;
                        break;
                    case ColorChoice.Yellow:
                        g.GetComponent<Renderer>().material.color = Color.yellow;
                        break;
                        
                }
            }
        }
    }
}

