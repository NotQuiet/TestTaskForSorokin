using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Sorokin
{
    public class Spawner : MonoBehaviour
    {
        [SerializeField]
        private GameObject _cube;

        [SerializeField]
        private Transform _spawnPoint;

        private int _spawnInterval = 10;

        private void Start()
        {
            InvokeRepeating("Spawn", _spawnInterval, _spawnInterval);
        }

        public void SetSpawnIntervalValue(int value)
        {
            CancelInvoke();
            _spawnInterval = value;
            InvokeRepeating("Spawn", _spawnInterval, _spawnInterval);
        }

        private void Spawn()
        {
            Instantiate(_cube, _spawnPoint);
            Debug.Log("Spawn " + _spawnInterval + " seconds");
        }
    }
}
