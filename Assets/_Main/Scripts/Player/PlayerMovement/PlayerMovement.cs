using System;
using EMA.Scripts.MyShortcuts;
using UnityEngine;

namespace _Main.Scripts.Player.PlayerMovement
{
    [Serializable]
    public class PlayerMovement
    {
        [SerializeField] private Rigidbody playerRb;
        [SerializeField] private PlayerStats playerStats;

        public void ApplyForce(Vector3 convertedInput, float inputMagnitude)
        {
            var multiplier = inputMagnitude * playerStats.InputMagnitudeMultiplier;
            MyShortcuts.RemoveMomentum(playerRb);
            playerRb.AddForce(convertedInput * multiplier * playerStats.ReleaseForce, ForceMode.Impulse);
        }

        public Vector3 GetInitialVelocity(Vector3 convertedInput, float inputMagnitude)
        {
            var multiplier = inputMagnitude * playerStats.InputMagnitudeMultiplier;
            MyShortcuts.RemoveMomentum(playerRb);
            return convertedInput * multiplier * playerStats.ReleaseForce;
        }
    }
}