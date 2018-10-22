﻿using System.Collections.Generic;

namespace ExRam.Gremlinq
{
    public sealed class VertexProperty : Element
    {
        public object Value { get; set; }
        public IDictionary<string, object> Properties { get; set; }
    }
}
