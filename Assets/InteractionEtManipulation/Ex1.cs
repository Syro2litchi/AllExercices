using UnityEngine;
using UnityEngine.InputSystem;

namespace InteractionEtManipulation
{
    public class Ex1 : MonoBehaviour
    {
        public Color leftClickColor;
        public Color rightClickColor;
        
        void Update()
        {
            if (Input.GetButtonDown("Fire 1"))
            {
                gameObject.GetComponent<MeshRenderer>().material.color = leftClickColor;
            }

            if (Input.GetButtonDown("Fire 2"))
            {
                gameObject.GetComponent<MeshRenderer>().material.color = rightClickColor;
            }
        }

        public void LeftClick(InputAction.CallbackContext context)
        {
            gameObject.GetComponent<MeshRenderer>().material.color = leftClickColor;
        }
    }
}

