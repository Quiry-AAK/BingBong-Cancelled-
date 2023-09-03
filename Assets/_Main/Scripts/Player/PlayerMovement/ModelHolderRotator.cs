using System;
using StateMachineGenerator;
using UnityEngine;

namespace _Main.Scripts.Player.PlayerMovement
{
    public class ModelHolderRotator : MonoBehaviour
    {
        [SerializeField] private PlayerStats playerStats;
        [SerializeField] private Transform modelHolderTr;
        [SerializeField] private Rigidbody playerRb;

        public void RotateAccordingToVelocity()
        {
            modelHolderTr.Rotate(playerStats.MovementRotateMultiplier * Time.deltaTime * playerRb.velocity.magnitude * -Vector3.up);
        }
    }
}