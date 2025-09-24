using System;
using UnityEngine;

namespace EnumerationEtSwitch
{
    public class Ex1 : MonoBehaviour
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
            DayOfWeek today;
            foreach (var day in Enum.GetValues(typeof(DayOfWeek)))
            {
                today = (DayOfWeek)day;
                Debug.Log("Aujourd'hui nous sommes : " + today);
            }
        }
    }
}

