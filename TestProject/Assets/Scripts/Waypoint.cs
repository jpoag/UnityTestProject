using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    [System.Serializable]
    public class Waypoint : MonoBehaviour
    {
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, 1);
            Gizmos.color = Color.blue;
            Gizmos.DrawRay(transform.position, transform.forward);
        }
    }
}
