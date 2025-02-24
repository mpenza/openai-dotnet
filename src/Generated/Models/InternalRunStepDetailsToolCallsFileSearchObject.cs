// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalRunStepDetailsToolCallsFileSearchObject : RunStepToolCall
    {
        internal InternalRunStepDetailsToolCallsFileSearchObject(string id, InternalRunStepDetailsToolCallsFileSearchObjectFileSearch fileSearch) : base(id)
        {
            Argument.AssertNotNull(id, nameof(id));
            Argument.AssertNotNull(fileSearch, nameof(fileSearch));

            Kind = RunStepToolCallKind.FileSearch;
            FileSearch = fileSearch;
        }

        internal InternalRunStepDetailsToolCallsFileSearchObject(RunStepToolCallKind kind, string id, IDictionary<string, BinaryData> serializedAdditionalRawData, InternalRunStepDetailsToolCallsFileSearchObjectFileSearch fileSearch) : base(kind, id, serializedAdditionalRawData)
        {
            FileSearch = fileSearch;
        }

        internal InternalRunStepDetailsToolCallsFileSearchObject()
        {
        }

        public InternalRunStepDetailsToolCallsFileSearchObjectFileSearch FileSearch { get; }
    }
}
