using UnityEngine;

namespace EnumerationEtSwitch
{
    public class Ex4 : MonoBehaviour
    {
        enum Seasons
        {
            Spring,
            Winter,
            Autumn,
            Summer
        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            for (int i = 0; i != 10; i++)
            {
                switch (i)
                {
                    case 3 :
                        Debug.Log("Pause de primptemps.");
                        continue;
                    case 6 :
                        Debug.Log("Fin prématurée en été.");
                        break;
                    default:
                        switch (i % 4)
                        {
                            case 1 :
                                Debug.Log("C'est l'automne.");
                                break;
                            case 2 :
                                Debug.Log("C'est l'été.");
                                break;
                            case 0 :
                                Debug.Log("C'est l'hiver.");
                                break;
                            case 3 :
                                Debug.Log("C'est le primptemps");
                                break;
                        }
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
