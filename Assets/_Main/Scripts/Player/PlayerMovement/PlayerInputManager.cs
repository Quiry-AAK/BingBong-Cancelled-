using EMA.Scripts.InputEma;
using StateMachineGenerator;
using UnityEngine;

namespace _Main.Scripts.Player.PlayerMovement
{
    public class PlayerInputManager : MonoBehaviour
    {
        [SerializeField] private StateManager playerStateManager;
        [SerializeField] private PlayerDotManager playerDotManager;
        [Space]
        [SerializeField] private PlayerMovement playerMovement;
        [Space] [SerializeField] private DartInputPropertiesFactory playerInputPropertiesFactory;

        private Transform _playerTr;

        private void Start()
        {
            _playerTr = transform;
        }

        public void FillInputsForTouchingState(bool value)
        {
            if (value)
            {
                HoldAndReleaseInput.Instance.HoldEvent.AddListener(HoldingInput);
                HoldAndReleaseInput.Instance.ReleaseEvent.AddListener(ReleaseInput);
            }

            else
            {
                HoldAndReleaseInput.Instance.HoldEvent.RemoveListener(HoldingInput);
                HoldAndReleaseInput.Instance.ReleaseEvent.RemoveListener(ReleaseInput);
            }
        }

        public void FillInputsToCheckTouchingTransition(bool value)
        {
            if (value)
            {
                HoldAndReleaseInput.Instance.TouchStartedEvent.AddListener(TouchStartedInput);
            }

            else
            {
                HoldAndReleaseInput.Instance.TouchStartedEvent.RemoveListener(TouchStartedInput);
            }
        }
        
        private void TouchStartedInput()
        {
            playerStateManager.ChangeStateIfItsPossible("Touching");
        }

        private void ReleaseInput(Vector2 input)
        {
            var props = playerInputPropertiesFactory.GetInputProperties(input);
            playerMovement.ApplyForce(props.ConvertedInput, props.InputMagnitude);
            playerStateManager.ChangeStateIfItsPossible("Flying");
        }

        private void HoldingInput(Vector2 input)
        {
            var props = playerInputPropertiesFactory.GetInputProperties(input);
            playerDotManager.AdjustDots(_playerTr.position, playerMovement.GetInitialVelocity(props.ConvertedInput, props.InputMagnitude));
        }

    }
}