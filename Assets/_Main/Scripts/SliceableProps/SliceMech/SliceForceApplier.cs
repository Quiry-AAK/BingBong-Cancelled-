using System;
using UnityEngine;

namespace _Main.Scripts.SliceableProps.SliceMech
{
    public static class SliceForceApplier
    {
        public static void ApplyForce(GameObject go, Vector3 explosionPos, float force)
        {
            var rb = go.AddComponent<Rigidbody>();
            var col = go.AddComponent<SphereCollider>();
            rb.drag = .2f;
            col.radius = .2f;
            rb.AddExplosionForce(force, explosionPos, Mathf.Infinity, 1f, ForceMode.Impulse);
        }
    }
}