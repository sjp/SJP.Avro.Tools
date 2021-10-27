﻿using System;
using System.Collections.Generic;

namespace SJP.Avro.Tools.Idl.Model
{
    public record UnionType : AvroType
    {
        public UnionType(IEnumerable<AvroType> typeOptions, IEnumerable<Property> properties)
            : base(properties)
        {
            TypeOptions = typeOptions ?? throw new ArgumentNullException(nameof(typeOptions));
        }

        public IEnumerable<AvroType> TypeOptions { get; }
    }
}
