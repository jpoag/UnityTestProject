using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    public class DevInput : MonoBehaviour
    {
        public MazeBuilder mMazeBuilder;

        // Use this for initialization
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyUp(KeyCode.Q))
            {
                mMazeBuilder.AddSection();
            }
            else if (Input.GetKeyUp(KeyCode.E))
            {
                mMazeBuilder.RemoveSection();
            }
        }
    }
}
