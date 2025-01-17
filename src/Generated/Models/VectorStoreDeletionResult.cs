// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.VectorStores
{
    public partial class VectorStoreDeletionResult
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal VectorStoreDeletionResult(bool deleted, string vectorStoreId)
        {
            Deleted = deleted;
            VectorStoreId = vectorStoreId;
        }

        internal VectorStoreDeletionResult(bool deleted, string vectorStoreId, InternalDeleteVectorStoreResponseObject @object, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Deleted = deleted;
            VectorStoreId = vectorStoreId;
            this.Object = @object;
            _additionalBinaryDataProperties = additionalBinaryDataProperties;
        }

        public bool Deleted { get; }

        internal IDictionary<string, BinaryData> SerializedAdditionalRawData
        {
            get => _additionalBinaryDataProperties;
            set => _additionalBinaryDataProperties = value;
        }
    }
}
