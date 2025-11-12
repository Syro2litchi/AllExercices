using UnityEngine;

namespace HeritageEtScriptableObjects
{
    public class Ex1 : MonoBehaviour
    {
        public Son John;
    
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            John = new Son();
            Debug.Log (John.Name);
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }

    public class Dad
    {
        public string Name = "Mac Couille";
    
    }

    public class Son : Dad
    {
    
    }
}
