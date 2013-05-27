﻿// Copyright (c) Microsoft Corporation. All rights reserved. See License.txt in the project root for license information.

namespace DeltaExplorer
{
    // Represents a segment of a URI such as a separator or content
    internal abstract class PathSegment
    {
#if ROUTE_DEBUGGING
        public abstract string LiteralText
        {
            get;
        }
#endif
    }
}