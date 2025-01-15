using UnityEditor;
using UnityEngine;

namespace DebugInMenu
{
    public class DebugHelloWorldInMenu : Editor
    {
        [MenuItem("Tools/Log Console/Debug Hello World")]
        static void DebugHelloWorld()
        {
            Debug.Log("Hello World");
        }
    }
}