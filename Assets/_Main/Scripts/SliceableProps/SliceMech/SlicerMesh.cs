using System;
using UnityEngine;

namespace _Main.Scripts.SliceableProps.SliceMech
{
    public class SlicerMesh
    {
        public static void RotateProperly(Vector3 needlePos, Transform slicerMeshTr)
        {
            var dir = slicerMeshTr.position - needlePos;
            dir.Normalize();
            var dir2 = dir - slicerMeshTr.right;
            var angle = Mathf.Atan2(dir2.y, dir2.x) * Mathf.Rad2Deg;
            if (slicerMeshTr.position.z  < needlePos.z)
            {
                angle *= -1f;
            }
            slicerMeshTr.rotation = Quaternion.AngleAxis(angle, Vector3.right);
        }
    }
}