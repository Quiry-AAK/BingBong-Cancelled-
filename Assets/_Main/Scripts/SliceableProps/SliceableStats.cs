using UnityEngine;

namespace _Main.Scripts.SliceableProps
{
    [CreateAssetMenu(fileName = "New Sliceable", menuName = "Stats/Sliceable", order = 0)]
    public class SliceableStats : ScriptableObject
    {
        [SerializeField] private float explosionForce;
        [SerializeField] private Material slicedMat;
        
        public float ExplosionForce => explosionForce;

        public Material SlicedMat => slicedMat;
    }
}