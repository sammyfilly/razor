﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using Microsoft.VisualStudio.LanguageServer.Protocol;

namespace Microsoft.AspNetCore.Razor.LanguageServer.Diagnostics;

internal record RazorPullDiagnosticResponse(VSInternalDiagnosticReport[] CSharpDiagnostics, VSInternalDiagnosticReport[] HtmlDiagnostics);
