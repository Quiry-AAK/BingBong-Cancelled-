using _Main.Scripts.Breakable;
using _Main.Scripts.SliceableProps;
using StateMachineGenerator;
using UnityEngine;

namespace _Main.Scripts.Player.PlayerCollisions
{
    public class PlayerCollisionChecker : MonoBehaviour
    {
        [SerializeField] private StateManager playerStateManager;
        
        private Transform _tr;

        private void Start()
        {
            _tr = transform;
        }

        public void CheckSticking(Collision other)
        {
            if (other.collider.CompareTag("Ground"))
            {
                playerStateManager.ChangeStateIfItsPossible("Stick");
            }
        }

        public void CheckSlicing(Collider other)
        {
            if (other.CompareTag("Sliceable"))
            {
                other.attachedRigidbody.GetComponent<ISliceable>().Slicer.Slice(_tr.position);
            }

            if (other.CompareTag("Breakable"))
            {
                other.attachedRigidbody.GetComponent<IBreakable>().Break(_tr.position);
            }
        }
    }
}