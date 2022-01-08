using UnityEngine;

namespace Breakout
{
    public class GameManager : Gamnet.Util.MonoSingleton<GameManager>
    {
        public float barSpeed;
        public float ballSpeed;
        public string host;
        public int port;

        public bool multiPlay;
        public bool useDeadReckoning;
        [Range(0, 1000)]
        public int packetDelay; //ms
        public int switchInterval;
        [Range(0, 1.0f)]
        public float syncInterval;
    }
}