namespace Tilia.Input.UnityInputManager
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Process;

    /// <summary>
    /// Listens for the specified axes and emits the appropriate action.
    /// </summary>
    public class UnityInputManagerAxis2DAction : Vector2Action, IProcessable
    {
        /// <summary>
        /// The named x axis to listen for state changes on.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public string XAxisName { get; set; }
        /// <summary>
        /// The named y axis to listen for state changes on.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public string YAxisName { get; set; }
        /// <summary>
        /// Multiplies the x axis value.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public float XMultiplier { get; set; } = 1f;
        /// <summary>
        /// Multiplies the y axis value.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public float YMultiplier { get; set; } = 1f;

        /// <inheritdoc />
        public void Process()
        {
            Receive(new Vector2(Input.GetAxis(XAxisName) * XMultiplier, Input.GetAxis(YAxisName) * YMultiplier));
        }
    }
}