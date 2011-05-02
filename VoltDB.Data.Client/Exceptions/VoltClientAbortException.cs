﻿/*

 This file is part of VoltDB.
 Copyright (C) 2008-2011 VoltDB Inc.

 Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
 documentation files (the "Software"), to deal in the Software without restriction, including without limitation the
 rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit
 persons to whom the Software is furnished to do so, subject to the following conditions:

 The above copyright notice and this permission notice shall be included in all copies or substantial portions of the
 Software.

 THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS BE
 LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

*/
using System;

namespace VoltDB.Data.Client
{
    /// <summary>
    /// Exceptions for client-side aborts thrown when the client application calls ExecuteCancelAsync on a specific
    /// request.
    /// This class cannot be inherited.
    /// </summary>
    [Serializable]
    public sealed class VoltClientAbortException : VoltException
    {
        internal VoltClientAbortException(string msg)
            : base(msg) { }

        internal VoltClientAbortException(string msg, Exception inner)
            : base(msg, inner) { }

        internal VoltClientAbortException(string format, params object[] parameters)
            : base(format, parameters) { }

        internal VoltClientAbortException(string format, Exception inner, params object[] parameters)
            : base(format, inner, parameters) { }
    }
}
