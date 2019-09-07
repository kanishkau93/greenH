using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Valve.VR.InteractionSystem.Sample
{
    public class clear : MonoBehaviour
    {
        private GameObject go;
        private GameObject go2;
        public GameObject brinj;
       

        private void OnHandHoverBegin(Hand hand)
        {

        }

        private void OnHandHoverEnd(Hand hand)
        {
            GameObject[] slots = GameObject.FindGameObjectsWithTag("brinanim");
            foreach (GameObject slot in slots)
                GameObject.Destroy(slot);
            GameObject[] slots2 = GameObject.FindGameObjectsWithTag("cornanim");
            foreach (GameObject slot in slots2)
                GameObject.Destroy(slot);
            GameObject[] slots3 = GameObject.FindGameObjectsWithTag("chilanim");
            foreach (GameObject slot in slots3)
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
    

