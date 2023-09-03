using System.Collections.Generic;
using EMA.DotLine;
using UnityEngine;

namespace _Main.Scripts.Player.PlayerMovement
{
    public class PlayerDotManager : MonoBehaviour
    {
        [SerializeField] private DotLineManager dotLineManager;

        public void AdjustDots(Vector3 playerPos , Vector3 initialVelocity)
        {
            var dotPosList = new List<Vector3>();

            float time = 0f;

            for (int i = 0; i < dotLineManager.DotProps.DotCount; i++)
            {
                time += .1f;
                var x = initialVelocity.z * time;
                var y = initialVelocity.y * time  -  .5f *(-Physics.gravity.y * Mathf.Pow(time, 2));
                x += playerPos.z;
                y += playerPos.y;
                dotPosList.Add(new Vector3(0f, y, x));
            }
            
            
            dotLineManager.DrawLine(dotPosList);
        }

        public void SetActivenessOfDotLine(bool val)
        {
            dotLineManager.gameObject.SetActive(val);
        }
    }
}