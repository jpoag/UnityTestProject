using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    [System.Serializable]
    public class HallSection : MonoBehaviour
    {
        public Magnet[] magnets;
        public Waypoint[] waypoints;

        public Magnet GetStartMagnet()
        {
            if (magnets.Length > 0)
            {
                return magnets[0];
            }
            return null;
        }

        public Magnet GetEndMagnet()
        {
            if(magnets.Length > 0)
            {
                return magnets[magnets.Length - 1];
            }
            return null;
        }

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}