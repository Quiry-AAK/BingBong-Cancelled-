using UnityEditor;
using UnityEngine;

namespace EMA.Scripts.MenuItems
{
    public class CameraLookProvider : MonoBehaviour
    {
        [MenuItem("EMA/Look At The Camera")]
        public static void LookAtTheCamera()
        {
            var _tr = Selection.activeTransform;
            _tr.LookAt(Camera.main.transform);
        }

        public static void LookAtTheCamera(Transform tr)
        {
            tr.LookAt(Camera.main.transform);
        }
    }
}