// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.AI.Language.Conversations.Authoring
{
    /// <summary> Represents the options used to create or update a project. </summary>
    public partial class ConversationAuthoringCreateProjectDetails
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringCreateProjectDetails"/>. </summary>
        /// <param name="projectKind"> Represents the project kind. </param>
        /// <param name="projectName"> The new project name. </param>
        /// <param name="language"> The project language. This is BCP-47 representation of a language. For example, use "en" for English, "en-gb" for English (UK), "es" for Spanish etc. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="projectName"/> or <paramref name="language"/> is null. </exception>
        public ConversationAuthoringCreateProjectDetails(ConversationAuthoringProjectKind projectKind, string projectName, string language)
        {
            Argument.AssertNotNull(projectName, nameof(projectName));
            Argument.AssertNotNull(language, nameof(language));

            ProjectKind = projectKind;
            ProjectName = projectName;
            Language = language;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringCreateProjectDetails"/>. </summary>
        /// <param name="projectKind"> Represents the project kind. </param>
        /// <param name="settings"> The project settings. </param>
        /// <param name="storageInputContainerName"> The storage container name in case of conversation summarization. </param>
        /// <param name="projectName"> The new project name. </param>
        /// <param name="multilingual"> Whether the project would be used for multiple languages or not. </param>
        /// <param name="description"> The project description. </param>
        /// <param name="language"> The project language. This is BCP-47 representation of a language. For example, use "en" for English, "en-gb" for English (UK), "es" for Spanish etc. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ConversationAuthoringCreateProjectDetails(ConversationAuthoringProjectKind projectKind, ConversationAuthoringProjectSettings settings, string storageInputContainerName, string projectName, bool? multilingual, string description, string language, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            ProjectKind = projectKind;
            Settings = settings;
            StorageInputContainerName = storageInputContainerName;
            ProjectName = projectName;
            Multilingual = multilingual;
            Description = description;
            Language = language;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="ConversationAuthoringCreateProjectDetails"/> for deserialization. </summary>
        internal ConversationAuthoringCreateProjectDetails()
        {
        }

        /// <summary> Represents the project kind. </summary>
        public ConversationAuthoringProjectKind ProjectKind { get; }
        /// <summary> The project settings. </summary>
        public ConversationAuthoringProjectSettings Settings { get; set; }
        /// <summary> The storage container name in case of conversation summarization. </summary>
        public string StorageInputContainerName { get; set; }
        /// <summary> Whether the project would be used for multiple languages or not. </summary>
        public bool? Multilingual { get; set; }
        /// <summary> The project description. </summary>
        public string Description { get; set; }
        /// <summary> The project language. This is BCP-47 representation of a language. For example, use "en" for English, "en-gb" for English (UK), "es" for Spanish etc. </summary>
        public string Language { get; }
    }
}
