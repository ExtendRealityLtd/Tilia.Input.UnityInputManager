namespace Tilia.Input.UnityInputManager
{
    using Malimbe.PropertySerializationAttribute;
    using Malimbe.XmlDocumentationAttribute;
    using UnityEngine;
    using Zinnia.Action;
    using Zinnia.Process;

    /// <summary>
    /// Listens for the specified <see cref="KeyCode"/> state and emits the appropriate action.
    /// </summary>
    public class UnityInputManagerButtonAction : BooleanAction, IProcessable
    {
        /// <summary>
        /// The <see cref="UnityEngine.KeyCode"/> to listen for state changes on.
        /// </summary>
        [Serialized]
        [field: DocumentedByXml]
        public KeyCode KeyCode { get; set; }

        /// <inheritdoc />
        public void Process()
        {
            Receive(Input.GetKey(KeyCode));
        }
    }
}