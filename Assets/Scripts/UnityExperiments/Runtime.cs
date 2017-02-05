using System.Runtime.InteropServices;
using UnityEngine;

/// <summary>
/// Provide information about the runtime environment.
/// </summary>
[ExecuteInEditMode]
public class Runtime : MonoBehaviour
{
    public static string runtimeBuildInfo
    {
        get
        {
            return mono_get_runtime_build_info();
        }
    }

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        Debug.Log(string.Format("Mono version: {0}", runtimeBuildInfo));
    }

    [DllImport("__Internal")]
    internal extern static string mono_get_runtime_build_info();
}
