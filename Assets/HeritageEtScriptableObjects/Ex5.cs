using UnityEngine;

namespace HeritageEtScriptableObjects
{
    public class Ex5 : MonoBehaviour
    {
        public Spell CurrentSpell;
        
        
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
        
        }

        // Update is called once per frame
        void Update()
        {
            if (CurrentSpell != null && Input.GetButtonDown("Fire1"))
            {
                Debug.Log("Your spell " + CurrentSpell.name + " inflicts " + CurrentSpell.damage + " " + CurrentSpell.effect + "  damage.");
            }
        }
    }

    [CreateAssetMenu(fileName = "Spell")]
    public class Spell : ScriptableObject
    {
        public int damage;
        public string effect;
    }

}
