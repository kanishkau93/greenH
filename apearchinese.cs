using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Valve.VR.InteractionSystem.Sample
{
    public class apearchinese : MonoBehaviour
    {
        private GameObject go;
        private GameObject go2;
        public GameObject ChN;


        private void OnHandHoverBegin(Hand hand)
        {

        }

        private void OnHandHoverEnd(Hand hand)
        {
            GameObject newTarget = Instantiate(ChN, transform.position, transform.rotation);
            newTarget.name = "CHHN";
          


        }

        private void OnAttachedToHand(Hand hand)
        {

        }
        private void OnDetachedFromHand(Hand hand)
        {

        }


    }
}