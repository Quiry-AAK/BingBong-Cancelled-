using UnityEngine;

namespace _Main.Scripts.Player
{
    [CreateAssetMenu(fileName = "Dart Stats", menuName = "Stats/Dart Stats", order = 0)]
    public class PlayerStats : ScriptableObject
    {
        [Header("Movement")]
        [SerializeField] private float releaseForce;
        [SerializeField] private float inputMagnitudeMultiplier;
        [SerializeField] private float movementRotateMultiplier;

        [Header("Input Normalization")]
        [SerializeField]private float inputMagnitudeDivider;
        [SerializeField]private float maxInputMagnitude;
        
        public float MovementRotateMultiplier => movementRotateMultiplier;
        public float InputMagnitudeMultiplier => inputMagnitudeMultiplier;
        public float ReleaseForce => releaseForce;
        public float InputMagnitudeDivider => inputMagnitudeDivider;
        public float MaxInputMagnitude => maxInputMagnitude;
    }
}