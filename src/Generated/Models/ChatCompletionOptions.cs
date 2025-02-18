// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Chat
{
    public partial class ChatCompletionOptions
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal ChatCompletionOptions(float? frequencyPenalty, float? presencePenalty, ChatResponseFormat responseFormat, float? temperature, float? topP, IList<ChatTool> tools, IList<ChatMessage> messages, InternalCreateChatCompletionRequestModel model, int? n, bool? stream, InternalChatCompletionStreamOptions streamOptions, bool? includeLogProbabilities, int? topLogProbabilityCount, IList<string> stopSequences, IDictionary<int, int> logitBiases, ChatToolChoice toolChoice, ChatFunctionChoice functionChoice, bool? allowParallelToolCalls, string endUserId, long? seed, int? deprecatedMaxTokens, int? maxOutputTokenCount, IList<ChatFunction> functions, IDictionary<string, string> metadata, bool? storedOutputEnabled, ChatReasoningEffortLevel? reasoningEffortLevel, ChatOutputPrediction outputPrediction, InternalCreateChatCompletionRequestServiceTier? serviceTier, IList<InternalCreateChatCompletionRequestModality> internalModalities, ChatAudioOptions audioOptions, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            FrequencyPenalty = frequencyPenalty;
            PresencePenalty = presencePenalty;
            ResponseFormat = responseFormat;
            Temperature = temperature;
            TopP = topP;
            Tools = tools;
            Messages = messages;
            Model = model;
            N = n;
            Stream = stream;
            StreamOptions = streamOptions;
            IncludeLogProbabilities = includeLogProbabilities;
            TopLogProbabilityCount = topLogProbabilityCount;
            StopSequences = stopSequences;
            LogitBiases = logitBiases;
            ToolChoice = toolChoice;
            FunctionChoice = functionChoice;
            AllowParallelToolCalls = allowParallelToolCalls;
            EndUserId = endUserId;
            Seed = seed;
            _deprecatedMaxTokens = deprecatedMaxTokens;
            MaxOutputTokenCount = maxOutputTokenCount;
            Functions = functions;
            Metadata = metadata;
            StoredOutputEnabled = storedOutputEnabled;
            ReasoningEffortLevel = reasoningEffortLevel;
            OutputPrediction = outputPrediction;
            _serviceTier = serviceTier;
            _internalModalities = internalModalities;
            _audioOptions = audioOptions;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public float? FrequencyPenalty { get; set; }

        public float? PresencePenalty { get; set; }

        public ChatResponseFormat ResponseFormat { get; set; }

        public float? Temperature { get; set; }

        public float? TopP { get; set; }

        public IList<ChatTool> Tools { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
