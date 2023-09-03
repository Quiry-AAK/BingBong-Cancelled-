using _Main.Scripts.GameManagement;
using UnityEngine;

namespace _Main.Scripts.Player.PlayerMovement
{
    public class PlayerTimeSlower : MonoBehaviour
    {
        [SerializeField] private GameProps gameProps;

        private void AdjustTimeScale(TimesForTouching timesForTouching)
        {
            switch (timesForTouching)
            {
                case TimesForTouching.Slow:
                    Time.timeScale = gameProps.SlowTimeScale;
                    break;
                case TimesForTouching.Normal:
                    Time.timeScale = 1f;
                    break;
                default:
                    Debug.LogError("Invalid Time");
                    return;
            }
        }
        
        public void AdjustTimeScaleToSlow()
        {
            AdjustTimeScale(TimesForTouching.Slow);
        }

        public void AdjustTimeScaleToNormal()
        {
            AdjustTimeScale(TimesForTouching.Normal);
        }
    }
}