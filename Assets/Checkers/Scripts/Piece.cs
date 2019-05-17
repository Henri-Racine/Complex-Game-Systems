using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Checkers
{
    public class Piece : MonoBehaviour
    {
        public bool isWhite, isKing;
        public int x, y;

        private Animator anim;

        // Use this for initialization
        void Start()
        {
            anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        public void King()
        {
            isKing = true;
            anim.SetTrigger("king");
        }
    } 
}
