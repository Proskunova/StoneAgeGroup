using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class Banana : AFruit
    {
        public override int GetPoints()
        {
            return base.points;
        }

        protected override void PrintName()
        {
            Debug.Log("Banana");
        }
    }
}

