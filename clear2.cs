using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Valve.VR.InteractionSystem.Sample
{
    public class clear2 : MonoBehaviour
    {
        private GameObject go;
        private GameObject go2;
        public GameObject brinj;
       

        private void OnHandHoverBegin(Hand hand)
        {

        }

        private void OnHandHoverEnd(Hand hand)
        {
            GameObject[] slots = GameObject.FindGameObjectsWithTag("plantanimation");
            foreach (GameObject slot in slots)
                GameObject.Destroy(slot);
            GameObject[] slots33 = GameObject.FindGameObjectsWithTag("infoinfo1");
            foreach (GameObject slot in slots33)
                GameObject.Destroy(slot);
            GameObject[] slots34 = GameObject.FindGameObjectsWithTag("infoinfo2");
            foreach (GameObject slot in slots34)
                GameObject.Destroy(slot);

        }

        private void OnAttachedToHand(Hand hand)
        {

        }
        private void OnDetachedFromHand(Hand hand)
        {

        }
        

        }
    }
    

