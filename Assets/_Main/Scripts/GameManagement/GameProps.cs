using UnityEngine;

namespace _Main.Scripts.GameManagement
{
    [CreateAssetMenu(fileName = "Game Props", menuName = "GameProps", order = 0)]
    public class GameProps : ScriptableObject
    {
        [Header("Movement Slowing")]
        [SerializeField] private float slowTimeScale;

        public float SlowTimeScale => slowTimeScale;
    }
}