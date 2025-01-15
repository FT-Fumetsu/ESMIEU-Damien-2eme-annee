using UnityEditor;
using UnityEngine;

namespace DebugInMenu
{
    public class DebugGameObjectNameInMenu : Editor
    {
        [MenuItem("Tools/Log Console/Debug Game Object Name")]
        static void DebugGameObjectName()
        {
                Debug.Log(Selection.activeGameObject.name);
        }

        [MenuItem("Tools/Log Console/Debug Game Object Name", true)]
        static bool ValidateLogSelectedGameObjectName()
        {
            return Selection.activeGameObject != null;
        }
    }
}