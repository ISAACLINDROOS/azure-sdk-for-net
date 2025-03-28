// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

namespace Azure.Communication.CallAutomation
{
    /// <summary> The incoming call event. </summary>
    internal partial class IncomingCallInternal
    {
        /// <summary> Initializes a new instance of <see cref="IncomingCallInternal"/>. </summary>
        internal IncomingCallInternal()
        {
        }

        /// <summary> Initializes a new instance of <see cref="IncomingCallInternal"/>. </summary>
        /// <param name="to"> The communication identifier of the target user. </param>
        /// <param name="from"> The communication identifier of the user who initiated the call. </param>
        /// <param name="callerDisplayName"> Display name of caller. </param>
        /// <param name="serverCallId"> The server call id. </param>
        /// <param name="customContext"> Custom Context of Incoming Call. </param>
        /// <param name="incomingCallContext"> Incoming call context. </param>
        /// <param name="onBehalfOfCallee"> The communication identifier of the user on behalf of whom the call is made. </param>
        /// <param name="correlationId"> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </param>
        internal IncomingCallInternal(CommunicationIdentifierModel to, CommunicationIdentifierModel @from, string callerDisplayName, string serverCallId, CustomCallingContextInternal customContext, string incomingCallContext, CommunicationIdentifierModel onBehalfOfCallee, string correlationId)
        {
            To = to;
            From = @from;
            CallerDisplayName = callerDisplayName;
            ServerCallId = serverCallId;
            CustomContext = customContext;
            IncomingCallContext = incomingCallContext;
            OnBehalfOfCallee = onBehalfOfCallee;
            CorrelationId = correlationId;
        }

        /// <summary> The communication identifier of the target user. </summary>
        public CommunicationIdentifierModel To { get; }
        /// <summary> The communication identifier of the user who initiated the call. </summary>
        public CommunicationIdentifierModel From { get; }
        /// <summary> Display name of caller. </summary>
        public string CallerDisplayName { get; }
        /// <summary> The server call id. </summary>
        public string ServerCallId { get; }
        /// <summary> Custom Context of Incoming Call. </summary>
        public CustomCallingContextInternal CustomContext { get; }
        /// <summary> Incoming call context. </summary>
        public string IncomingCallContext { get; }
        /// <summary> The communication identifier of the user on behalf of whom the call is made. </summary>
        public CommunicationIdentifierModel OnBehalfOfCallee { get; }
        /// <summary> Correlation ID for event to call correlation. Also called ChainId for skype chain ID. </summary>
        public string CorrelationId { get; }
    }
}
