using System;
using System.Collections.Generic;
using UnityEngine;

namespace EnumerationEtSwitch
{
    public class Ex5 : MonoBehaviour
    {
        public enum EnemyType
        {
            Goblin,
            Orc,
            Troll,
            Dragon
        }

        public List<EnemyType> enemyList;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            foreach (EnemyType i in enemyList)
            {
                switch(i)
                {
                    case EnemyType.Goblin :
                        Debug.Log("Petit mais rapide !");
                        break;
                    case EnemyType.Orc :
                        Debug.Log("Fort et brutal !");
                        break;
                    case (EnemyType)2 :
                        Debug.Log("Résistant !");
                        break;
                    case (EnemyType)3 :
                        Debug.Log("Attention au souffle de feu !");
                        break;
                }
            }
        }

        // Update is called once per frame
        void Update()
        {
        
        }
    }

}
