using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Valve.VR.InteractionSystem.Sample
{
    public class chiliAnimator : MonoBehaviour
    {
        private GameObject go;
        private GameObject go2;
        public GameObject chili;
       

        private void OnHandHoverBegin(Hand hand)
        {

        }

        private void OnHandHoverEnd(Hand hand)
        {
            GameObject newTarget = Instantiate(chili, transform.position, transform.rotation);
            newTarget.name = "chil";
            GameObject[] slots = GameObject.FindGameObjectsWithTag("brinanim");
            foreach (GameObject slot in slots)
                GameObject.Destroy(slot);
            GameObject[] slots2 = GameObject.FindGameObjectsWithTag("cornanim");
            foreach (GameObject slot in slots2)
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
    

