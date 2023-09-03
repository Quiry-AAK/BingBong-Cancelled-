using DG.Tweening;
using UnityEngine;

namespace _Main.Scripts.SliceableProps.SliceMech
{
    public class SliceFxManager : MonoBehaviour
    {
        [SerializeField] private GameObject particle;

        public void EnableParticle()
        {
            particle.transform.SetParent(null);
            var p = particle.GetComponent<ParticleSystem>();
            particle.SetActive(true);
            Destroy(particle, p.main.duration);
        }
    }
}