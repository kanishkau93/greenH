using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Valve.VR.InteractionSystem.Sample
{
    public class reset : MonoBehaviour
    {
        private GameObject go;
        private GameObject go2;
        public GameObject brinj;
       

        private void OnHandHoverBegin(Hand hand)
        {

        }

        private void OnHandHoverEnd(Hand hand)
        {
            SceneManager.LoadScene("classroom");

        }

        private void OnAttachedToHand(Hand hand)
        {

        }
        private void OnDetachedFromHand(Hand hand)
        {

        }
        

        }
    }
    

