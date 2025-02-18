// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace OpenAI.Files
{
    public partial class FileDeletionResult
    {
        private protected IDictionary<string, BinaryData> _additionalBinaryDataProperties;

        internal FileDeletionResult(bool deleted, string fileId)
        {
            Deleted = deleted;
            FileId = fileId;
        }

        internal FileDeletionResult(bool deleted, string fileId, InternalDeleteFileResponseObject @object, IDictionary<string, BinaryData> additionalBinaryDataProperties)
        {
            Deleted = deleted;
            FileId = fileId;
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
