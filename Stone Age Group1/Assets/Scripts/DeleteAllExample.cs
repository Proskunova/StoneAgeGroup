#if UNITY_EDITOR
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class DeleteAllExample : ScriptableObject
{
    [MenuItem("Examples/Delete All Player Prefs")]
    static void deleteAllExample()
    {
        if (EditorUtility.DisplayDialog("Player Prefs Deleter", "Delete all player prefs?", "Yes", "No"))
        {
            PlayerPrefs.DeleteAll();

            Debug.Log("Player Prefs deleted.");
        }
    }
}
#endif