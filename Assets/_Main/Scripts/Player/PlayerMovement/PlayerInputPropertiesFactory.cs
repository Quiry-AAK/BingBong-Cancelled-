using System;
using UnityEngine;

namespace _Main.Scripts.Player.PlayerMovement
{
    [Serializable]
    public class DartInputPropertiesFactory
    {
        [Space] [SerializeField] private PlayerStats playerStats;

        public PlayerInputProperties GetInputProperties(Vector2 input)
        {
            var convertedInput = new Vector3(0f, input.y, input.x);
            convertedInput.Normalize();
            convertedInput *= -1f;
            convertedInput.z = Mathf.Clamp(convertedInput.z, 0f, 1f);

            var inputMagnitude = input.magnitude / playerStats.InputMagnitudeDivider;
            inputMagnitude = Mathf.Clamp(inputMagnitude, 0f, playerStats.MaxInputMagnitude);

            return new PlayerInputProperties(convertedInput, inputMagnitude);
        }
    }
}