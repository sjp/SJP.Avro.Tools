﻿using System;
using System.Collections.Generic;

namespace SJP.Avro.Tools.Idl.Model
{
    public record Message : TypeDeclaration
    {
        public Message(
            DocComment? comment,
            Identifier name,
            AvroType returnType,
            IEnumerable<Property> properties,
            int position,
            IEnumerable<MessageParameter> parameters,
            bool oneway,
            IEnumerable<Identifier> errors
        ) : base(comment, properties, position)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            ReturnType = returnType ?? throw new ArgumentNullException(nameof(returnType));
            Parameters = parameters ?? throw new ArgumentNullException(nameof(parameters));
            OneWay = oneway;
            Errors = errors ?? throw new ArgumentNullException(nameof(errors));
        }

        public Identifier Name { get; }

        public AvroType ReturnType { get; }

        public IEnumerable<MessageParameter> Parameters { get; }

        public bool OneWay { get; }

        public IEnumerable<Identifier> Errors { get; }
    }
}
