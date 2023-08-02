﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the MIT license. See License.txt in the project root for license information.

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.Text;

namespace Microsoft.VisualStudio.LanguageServer.ContainedLanguage;

public abstract class LSPDocument : IDisposable
{
    public abstract int Version { get; }

    public abstract Uri Uri { get; }

    public abstract ITextBuffer TextBuffer { get; }

    public abstract LSPDocumentSnapshot CurrentSnapshot { get; }

    public abstract IReadOnlyList<VirtualDocument> VirtualDocuments { get; }

    public abstract LSPDocumentSnapshot UpdateVirtualDocument<TVirtualDocument>(IReadOnlyList<ITextChange> changes, int hostDocumentVersion, object? state) where TVirtualDocument : VirtualDocument;

    public virtual LSPDocumentSnapshot UpdateVirtualDocument<TVirtualDocument>(TVirtualDocument virtualDocument, IReadOnlyList<ITextChange> changes, int hostDocumentVersion, object? state) where TVirtualDocument : VirtualDocument
    {
        // This is only virtual to prevent a binary breaking change. We don't expect anyone to call this method, without also implementing it
        throw new NotImplementedException();
    }

    public bool TryGetVirtualDocument<TVirtualDocument>([NotNullWhen(returnValue: true)] out TVirtualDocument? virtualDocument) where TVirtualDocument : VirtualDocument
    {
        virtualDocument = null;

        for (var i = 0; i < VirtualDocuments.Count; i++)
        {
            if (VirtualDocuments[i] is TVirtualDocument actualVirtualDocument)
            {
                Debug.Assert(virtualDocument is null, "Found multiple virtual documents of the same type. Should call TryGetAllVirtualDocuments instead.");
                virtualDocument = actualVirtualDocument;
#if !DEBUG
                return true;
#endif
            }
        }

        return virtualDocument is not null;
    }

    public bool TryGetVirtualDocument<TVirtualDocument>(Uri virtualDocumentUri, [NotNullWhen(returnValue: true)] out TVirtualDocument? virtualDocument) where TVirtualDocument : VirtualDocument
    {
        virtualDocument = null;

        for (var i = 0; i < VirtualDocuments.Count; i++)
        {
            if (VirtualDocuments[i] is TVirtualDocument actualVirtualDocument &&
                actualVirtualDocument.Uri == virtualDocumentUri)
            {
                Debug.Assert(virtualDocument is null, "Found multiple virtual documents of the same type. Should call TryGetAllVirtualDocuments instead.");
                virtualDocument = actualVirtualDocument;
#if !DEBUG
                return true;
#endif
            }
        }

        return virtualDocument is not null;
    }

    [SuppressMessage("Usage", "CA1816:Dispose methods should call SuppressFinalize", Justification = "https://github.com/dotnet/roslyn-analyzers/issues/4801")]
    public virtual void Dispose()
    {
        foreach (var virtualDocument in VirtualDocuments)
        {
            virtualDocument.Dispose();
        }
    }
}
