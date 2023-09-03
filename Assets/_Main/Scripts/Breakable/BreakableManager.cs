using _Main.Scripts.SliceableProps;
using _Main.Scripts.SliceableProps.SliceMech;
using DG.Tweening;
using UnityEngine;

namespace _Main.Scripts.Breakable
{
    public class BreakableManager : MonoBehaviour, IBreakable
    {
        [SerializeField] private SliceableStats sliceableStats;
        [SerializeField] private Rigidbody mainRb;
        [SerializeField] private Rigidbody[] rbs;
        [SerializeField] private Collider[] cols;
        [SerializeField] private GameObject mainCol;
        public void Break(Vector3 playerPos)
        {
            Destroy(mainCol);
            Destroy(mainRb);
            for (int i = 0; i < rbs.Length; i++)
            {
                rbs[i].isKinematic = false;
                cols[i].enabled = true;
                rbs[i].AddExplosionForce(sliceableStats.ExplosionForce, playerPos, Mathf.Infinity, 1f, ForceMode.Impulse);
                rbs[i].transform.DOScale(Vector3.zero, .75f).SetEase(Ease.InBack);
            }
        }
    }
}