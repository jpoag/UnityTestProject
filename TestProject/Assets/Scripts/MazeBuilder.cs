using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Gameplay
{
    public class MazeBuilder : MonoBehaviour
    {
        public HallSection[] sections; // split into {'straight', 'turn', 'junction', 'reward', 'punish', 'death'}
        public Transform dynamicParent;

        public List<HallSection> myPath; // can we start with seed?

        // Use this for initialization
        void Start()
        {
        }

        // Update is called once per frame
        void Update()
        {
            
        }

        // Public API
        public void AddSection()
        {
            if(myPath.Count > 0)
            {
                // grab last section to tack new section onto
                HallSection lastSection = myPath[myPath.Count - 1];
                if(lastSection != null && sections.Length > 0)
                {
                    // instantiate a new section
                    int rand_num = Random.Range(0, sections.Length - 1);
                    HallSection newSection = (HallSection)Instantiate(sections[rand_num], dynamicParent);
                    myPath.Add(newSection);

                    Magnet lastSectionMagnet = lastSection.GetEndMagnet();
                    Magnet newSectionMagnet = newSection.GetStartMagnet();

                    // align new section to end of old section
                    if(lastSectionMagnet != null && newSectionMagnet != null)
                    {
                        // first, try subtracting the sections rotations to align
                        Vector3 rot_diff = lastSectionMagnet.transform.rotation.eulerAngles - newSectionMagnet.transform.rotation.eulerAngles;
                        newSection.transform.rotation = Quaternion.Euler(rot_diff);

                        // shift into position
                        Vector3 pos_dif = lastSectionMagnet.transform.position - newSectionMagnet.transform.position;
                        newSection.transform.position += pos_dif;
                    }
                }
            }
        }

        public void RemoveSection()
        {
            if(myPath.Count > 1)
            {
                HallSection firstSection = myPath[0];
                myPath.RemoveAt(0);

                if(firstSection)
                {
                    Destroy(firstSection.gameObject,1);
                }
            }
        }
    }
}

