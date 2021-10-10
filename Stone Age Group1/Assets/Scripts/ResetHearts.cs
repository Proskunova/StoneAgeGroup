using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
    public class ResetHearts : MonoBehaviour
    {
        public void ResetHeartsCount()
        {
            PlayerPrefs.DeleteKey("PlayerLives");
        }
    }
}

