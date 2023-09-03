using System;
using EzySlice;
using UnityEngine;
using UnityEngine.Events;
using Object = UnityEngine.Object;

namespace _Main.Scripts.SliceableProps.SliceMech
{
    [Serializable]
    public class Slicer
    {
        [SerializeField] private SliceableStats sliceableStats;
        [SerializeField] private UnityEvent sliceEvent;
        
        [SerializeField] private GameObject mainGo;
        [SerializeField] private GameObject wantedToBeSlicedGo;
        [SerializeField] private Transform slicerMeshTr;

        public void Slice(Vector3 needlePos)
        {
            SlicerMesh.RotateProperly(needlePos, slicerMeshTr);

            var go = wantedToBeSlicedGo.Slice(slicerMeshTr.position, slicerMeshTr.up, sliceableStats.SlicedMat);
            var upper = go.CreateUpperHull(wantedToBeSlicedGo, sliceableStats.SlicedMat);
            var lower = go.CreateLowerHull(wantedToBeSlicedGo, sliceableStats.SlicedMat);
            var pos = wantedToBeSlicedGo.transform.position;
            upper.transform.position = pos;
            lower.transform.position = pos;
            upper.layer = LayerMask.NameToLayer("SlicedPiece");
            lower.layer = LayerMask.NameToLayer("SlicedPiece");

            sliceEvent?.Invoke();
            SliceForceApplier.ApplyForce(upper, needlePos, sliceableStats.ExplosionForce);
            SliceForceApplier.ApplyForce(lower, needlePos, sliceableStats.ExplosionForce);
            Object.Destroy(mainGo);
        }
    }
}