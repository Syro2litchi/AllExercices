using UnityEngine;

namespace HeritageEtScriptableObjects
{
    public class Ex3 : MonoBehaviour
    {
        public Tower BlackTower;
        public Piece WhiteTower;
        
        void Start()
        {
            BlackTower = new Tower();
            BlackTower.Movement();
            WhiteTower = new Tower();
            WhiteTower.Movement();
        }
        
        void Update()
        {
        
        }
    }

    public abstract class Piece
    {
        public abstract void Movement();
    }

    public class Tower : Piece
    {
        public override void Movement()
        {
            Debug.Log("Tower moves on line");
        }
    }

}
