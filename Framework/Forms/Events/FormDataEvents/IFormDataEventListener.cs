// <copyright filename="IFormDataEventListener.cs" project="Framework">
//   This file is licensed to you under the MIT License.
//   Full license in the project root.
// </copyright>
namespace B1PP.Forms.Events.FormDataEvents
{
    using SAPbouiCOM;

    internal interface IFormDataEventListener
    {
        string Id { get; }

        void OnFormDataEvent(ref BusinessObjectInfo e, out bool bubbleEvent);
    }
}