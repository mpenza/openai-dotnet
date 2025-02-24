// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using System.Linq;

namespace OpenAI.Chat
{
    public partial class ChatCompletionOptions
    {
        // HACK: Expose this so we can add options until the library has official support.
        public IDictionary<string, BinaryData> SerializedAdditionalRawData { get; set; }

        internal ChatCompletionOptions(IList<ChatMessage> messages, InternalCreateChatCompletionRequestModel model, bool? storedOutputEnabled, IDictionary<string, string> metadata, float? frequencyPenalty, IDictionary<int, int> logitBiases, bool? includeLogProbabilities, int? topLogProbabilityCount, int? deprecatedMaxTokens, int? maxOutputTokenCount, int? n, float? presencePenalty, ChatResponseFormat responseFormat, long? seed, InternalCreateChatCompletionRequestServiceTier? serviceTier, IList<string> stopSequences, bool? stream, InternalChatCompletionStreamOptions streamOptions, float? temperature, float? topP, IList<ChatTool> tools, ChatToolChoice toolChoice, bool? allowParallelToolCalls, string endUserId, ChatFunctionChoice functionChoice, IList<ChatFunction> functions, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Messages = messages;
            Model = model;
            StoredOutputEnabled = storedOutputEnabled;
            Metadata = metadata;
            FrequencyPenalty = frequencyPenalty;
            LogitBiases = logitBiases;
            IncludeLogProbabilities = includeLogProbabilities;
            TopLogProbabilityCount = topLogProbabilityCount;
            _deprecatedMaxTokens = deprecatedMaxTokens;
            MaxOutputTokenCount = maxOutputTokenCount;
            N = n;
            PresencePenalty = presencePenalty;
            ResponseFormat = responseFormat;
            Seed = seed;
            _serviceTier = serviceTier;
            StopSequences = stopSequences;
            Stream = stream;
            StreamOptions = streamOptions;
            Temperature = temperature;
            TopP = topP;
            Tools = tools;
            ToolChoice = toolChoice;
            AllowParallelToolCalls = allowParallelToolCalls;
            EndUserId = endUserId;
            FunctionChoice = functionChoice;
            Functions = functions;
            SerializedAdditionalRawData = serializedAdditionalRawData;
        }
        public float? FrequencyPenalty { get; set; }
        public float? PresencePenalty { get; set; }
        public ChatResponseFormat ResponseFormat { get; set; }
        public float? Temperature { get; set; }
        public float? TopP { get; set; }
        public IList<ChatTool> Tools { get; }
    }
}
