using UnityEngine;

namespace _Main.Scripts.Breakable
{
    public interface IBreakable
    {
        void Break(Vector3 playerPos);
    }
}