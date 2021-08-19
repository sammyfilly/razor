﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

namespace Microsoft.CodeAnalysis.Razor
{
    internal abstract class SolutionCloseTracker
    {
        public virtual bool IsClosing { get; protected set; }
    }
}
