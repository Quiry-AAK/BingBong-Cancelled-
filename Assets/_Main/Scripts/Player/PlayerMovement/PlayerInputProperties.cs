using UnityEngine;

namespace _Main.Scripts.Player.PlayerMovement
{
    public struct PlayerInputProperties
    {
        private Vector3 _convertedInput;
        private float _inputMagnitude;

        public PlayerInputProperties(Vector3 convertedInput, float inputMagnitude)
        {
            _convertedInput = convertedInput;
            _inputMagnitude = inputMagnitude;
        }

        public Vector3 ConvertedInput => _convertedInput;

        public float InputMagnitude => _inputMagnitude;
    }
}