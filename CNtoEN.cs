using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Valve.VR.InteractionSystem.Sample
{
    public class CNtoEN : MonoBehaviour
    {
        
        
       

        private void OnHandHoverBegin(Hand hand)
        {

        }

        private void OnHandHoverEnd(Hand hand)
        {
           

            GameObject[] slots44 = GameObject.FindGameObjectsWithTag("infoinfo2");
            foreach (GameObject slot in slots44)
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
    

