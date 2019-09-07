using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Valve.VR.InteractionSystem.Sample
{
    public class brinAnimator : MonoBehaviour
    {
        private GameObject go;
        private GameObject go2;
        public GameObject brinj;
        public GameObject brinjname;
        public GameObject brinjeninfo;
        public GameObject brinjcninfo;
        public GameObject eninfo;
        public GameObject cninfo;



        private void OnHandHoverBegin(Hand hand)
        {

        }

        private void OnHandHoverEnd(Hand hand)
        {
            GameObject newTarget = Instantiate(brinj, transform.position, transform.rotation);
            newTarget.name = "brin";
            GameObject newTarget2 = Instantiate(brinjname, transform.position, transform.rotation);
            newTarget.name = "brinN";
            GameObject newTarget3 = Instantiate(brinjeninfo, transform.position, transform.rotation);
            newTarget.name = "brinENI";
            GameObject newTarget4 = Instantiate(brinjcninfo, transform.position, transform.rotation);
            newTarget.name = "brinCNI";
            GameObject newTarget5 = Instantiate(eninfo, transform.position, transform.rotation);
            newTarget.name = "ENIT";
            GameObject newTarget6 = Instantiate(cninfo, transform.position, transform.rotation);
            newTarget.name = "CNIT";


            GameObject[] slots = GameObject.FindGameObjectsWithTag("chilanim");
            foreach (GameObject slot in slots)
                GameObject.Destroy(slot);
            GameObject[] slots2 = GameObject.FindGameObjectsWithTag("cornanim");
            foreach (GameObject enemy in slots2)
                GameObject.Destroy(enemy);


        }

        private void OnAttachedToHand(Hand hand)
        {

        }
        private void OnDetachedFromHand(Hand hand)
        {

        }
        

        }
    }
    

