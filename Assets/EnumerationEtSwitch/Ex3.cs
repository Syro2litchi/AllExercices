using UnityEngine;

namespace EnumerationEtSwitch
{
    public class Ex3 : MonoBehaviour
    {
        public enum GameState
        {
            Menu,
            Playing,
            Paused,
            GameOver
        }
        public GameState currentState;
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            
        }

        // Update is called once per frame
        void Update()
        {
            switch (currentState)
            {
                case GameState.Menu:
                    Debug.Log("Dans les menus.");
                    break;
                case GameState.Playing:
                    Debug.Log("En jeu.");
                    break;
                case GameState.Paused:
                    Debug.Log("Jeu en pause.");
                    break;
                case GameState.GameOver:
                    Debug.Log("Jeu terminé.");
                    break;
            }
        }
    }
}

