using System;
using EzySlice;
using UnityEngine;
using Slicer = _Main.Scripts.SliceableProps.SliceMech.Slicer;

namespace _Main.Scripts.SliceableProps
{
    public class SliceableManager : MonoBehaviour, ISliceable
    {
        [SerializeField] private Slicer slicer;
        
        public Slicer Slicer => slicer;
    }
}