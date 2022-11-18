﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

#pragma warning disable CA1812 // dead code

using Windows.Win32.Foundation;
using Windows.Win32.System.Com;
using Windows.Win32.System.Com.Events;

/// <summary>
/// Contains "tests" that never run. Merely compiling is enough to verify the generated code has the right API shape.
/// </summary>
internal static unsafe class GeneratedForm
{
    private static unsafe void COMStructsPreserveSig()
    {
        IEventSubscription o = default;

        // Default is non-preservesig
        VARIANT v = o.GetPublisherProperty(null);

        // NativeMethods.json opts into PreserveSig for this particular method.
        HRESULT hr = o.GetSubscriberProperty(null, out v);
    }
}
