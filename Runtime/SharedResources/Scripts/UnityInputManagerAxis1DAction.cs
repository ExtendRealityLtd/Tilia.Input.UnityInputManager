﻿namespace Tilia.Input.UnityInputManager
{
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Process;

    /// <summary>
    /// Listens for the specified axis and emits the appropriate action.
    /// </summary>
    public class UnityInputManagerAxis1DAction : FloatAction, IProcessable
    {
        [Tooltip("The named axis to listen for state changes on.")]
        [SerializeField]
        private string axisName;
        /// <summary>
        /// The named axis to listen for state changes on.
        /// </summary>
        public string AxisName
        {
            get
            {
                return axisName;
            }
            set
            {
                axisName = value;
            }
        }
        [Tooltip("Multiplies the axis value.")]
        [SerializeField]
        private float multiplier = 1f;
        /// <summary>
        /// Multiplies the axis value.
        /// </summary>
        public float Multiplier
        {
            get
            {
                return multiplier;
            }
            set
            {
                multiplier = value;
            }
        }

        /// <inheritdoc />
        public void Process()
        {
#if UNITY_2019_2_OR_NEWER
#if ENABLE_LEGACY_INPUT_MANAGER
            Receive(Input.GetAxis(AxisName) * Multiplier);
#else
            Debug.LogWarning("The Legacy Unity Input Manager is disabled in the player settings.");
#endif
#else
            Receive(Input.GetAxis(AxisName) * Multiplier);
#endif
        }
    }
}