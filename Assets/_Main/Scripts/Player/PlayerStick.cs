using UnityEngine;

namespace _Main.Scripts.Player
{
    public class DartStick : MonoBehaviour
    {
        [SerializeField] private Rigidbody playerRb;

        public void MakeDartKinematic(bool value)
        {
            playerRb.isKinematic = value;
        }
    }
}