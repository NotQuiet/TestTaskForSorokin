using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Sorokin
{
    public class DeadLine : MonoBehaviour
    {
        [SerializeField]
        private GameObject _deadLineObject;

        private int _deadLine = 0;

        public void SetDeadlineValue(int value)
        {
            _deadLine = value;
            Debug.Log($"Deadline value = {_deadLine}");
            _deadLineObject.transform.position = new Vector3(-_deadLine, 0, 0);
        }

        private void OnCollisionEnter(Collision collision)
        {
            Destroy(collision.gameObject);
        }

    }
}
