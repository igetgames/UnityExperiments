using System;
using System.Reflection;
using UnityEngine;

public class Runtime : MonoBehaviour
{
    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        // From http://answers.unity3d.com/answers/333787/view.html
        var type = Type.GetType("Mono.Runtime");
        if (type != null)
        {
            var displayName = type.GetMethod("GetDisplayName", BindingFlags.NonPublic | BindingFlags.Static);
            if (displayName != null)
            {
                Debug.Log(displayName.Invoke(null, null));
            }
        }
    }
}
