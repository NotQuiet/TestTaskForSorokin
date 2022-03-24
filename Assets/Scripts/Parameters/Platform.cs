using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Sorokin
{
    public class Platform : MonoBehaviour
    {
        private int _force;

        private void OnCollisionEnter(Collision collision)
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(-_force, 0, 0), ForceMode.Impulse);
        }

        public void SetForceValue(int value)
        {
            _force = value;
        }
    }
}
