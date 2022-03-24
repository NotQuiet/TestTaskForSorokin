using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Sorokin
{
    public class GeneralUI : MonoBehaviour
    {
        [SerializeField]
        private Text _forceValueText;

        [SerializeField]
        private Text _frequencyValueText;

        [SerializeField]
        private Text _deadLineText;

        [SerializeField]
        private Button _setButton;

        public UnityEvent<int> OnForceChanged;
        public UnityEvent<int> OnFrenquencyChanged;
        public UnityEvent<int> OnDeadLineChanged;

        private void Start()
        {
            OnUpdateValues(30, 10, 100);
        }

        private void OnEnable()
        {
            _setButton.onClick.AddListener(OnSetButtonClick);
        }

        public void OnUpdateValues(int force, int frenquency, int deadline)
        {
            OnForceChanged.Invoke(force);
            OnFrenquencyChanged.Invoke(frenquency);
            OnDeadLineChanged.Invoke(deadline);
        }


        private void OnSetButtonClick()
        {
            int force = Convert.ToInt32(_forceValueText.text);
            int frenquency = Convert.ToInt32(_frequencyValueText.text);
            int deadline = Convert.ToInt32(_deadLineText.text);

            OnUpdateValues(force, frenquency, deadline);
        }
    }
}
