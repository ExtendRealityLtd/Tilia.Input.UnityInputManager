namespace Tilia.Input.UnityInputManager
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Process;

    /// <summary>
    /// Listens for the specified axis and emits the appropriate action.
    /// </summary>
    public class UnityInputManagerAxis1DAction : FloatAction, IProcessable
    {
        /// <summary>
        /// The named axis to listen for state changes on.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public string AxisName { get; set; }
        /// <summary>
        /// Multiplies the axis value.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public float Multiplier { get; set; } = 1f;

        /// <inheritdoc />
        public void Process()
        {
            Receive(Input.GetAxis(AxisName) * Multiplier);
        }
    }
}