using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    public class MazeBuilder : MonoBehaviour
    {
        public HallSection[] path; // need to start with 'seed'
        public HallSection[] sections; // split into {'straight', 'turn', 'junction', 'reward', 'punish', 'death'}
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

