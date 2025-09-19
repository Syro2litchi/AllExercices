using System;
using UnityEngine;

namespace EnumerationEtSwitch
{
    public class Ex2 : MonoBehaviour
    {
        enum DayOfWeek
        {
            Lundi,
            Mardi,
            Mercredi,
            Jeudi,
            Vendredi,
            Samedi,
            Dimanche
        }
        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            DayOfWeek today = DayOfWeek.Mercredi;
            foreach (var day in Enum.GetValues(typeof(DayOfWeek)))
            {
                today = (DayOfWeek)day;
                switch (today)
                {
                    case DayOfWeek.Lundi :
                        Debug.Log("Courage, la semaine commence !");
                        break;
                    case DayOfWeek.Vendredi :
                        Debug.Log("C'est bientôt le week-end.");
                        break;
                    case DayOfWeek.Samedi :
                        Debug.Log("Repos bien mérité !");
                        break;
                    case DayOfWeek.Dimanche :
                        Debug.Log("Repos bien mérité !");
                        break;
                    default:
                        Debug.Log("Un jour de semaine ordinaire.");
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
