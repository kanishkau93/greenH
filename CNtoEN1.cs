using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Valve.VR.InteractionSystem.Sample
{
    public class CNtoEN1 : MonoBehaviour
    {
        
       
       

        private void OnHandHoverBegin(Hand hand)
        {

        }

        private void OnHandHoverEnd(Hand hand)
        {
           
            GameObject[] slots45 = GameObject.FindGameObjectsWithTag("infoinfo2");
            foreach (GameObject slot in slots45)
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
    

