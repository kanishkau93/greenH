using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Valve.VR.InteractionSystem.Sample
{
    public class cornAnimator : MonoBehaviour
    {
        private GameObject go;
        private GameObject go2;
        public GameObject corn;
       

        private void OnHandHoverBegin(Hand hand)
        {

        }

        private void OnHandHoverEnd(Hand hand)
        {
            GameObject newTarget = Instantiate(corn, transform.position, transform.rotation);
            newTarget.name = "corn";
            GameObject[] slots = GameObject.FindGameObjectsWithTag("brinanim");
            foreach (GameObject slot in slots)
                GameObject.Destroy(slot);
            GameObject[] slots2 = GameObject.FindGameObjectsWithTag("chilanim");
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
    

