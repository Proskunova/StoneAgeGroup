using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetHearts : MonoBehaviour
{
    public void ResetHeartsCount()
    {
        PlayerPrefs.DeleteKey("PlayerLives");
    }
}
