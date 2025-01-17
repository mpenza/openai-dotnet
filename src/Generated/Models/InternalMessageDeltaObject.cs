// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Assistants
{
    internal partial class InternalMessageDeltaObject
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal InternalMessageDeltaObject(string id, InternalMessageDeltaObjectDelta delta)
        {
            Id = id;
            Delta = delta;
        }

        internal InternalMessageDeltaObject(string id, InternalMessageDeltaObjectObject @object, InternalMessageDeltaObjectDelta delta, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Id = id;
            Object = @object;
            Delta = delta;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public string Id { get; }

        public InternalMessageDeltaObjectObject Object { get; } = "thread.message.delta";

        public InternalMessageDeltaObjectDelta Delta { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
