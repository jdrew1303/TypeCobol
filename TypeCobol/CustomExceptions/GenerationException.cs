﻿using System;
using TypeCobol.Compiler.Diagnostics;

namespace TypeCobol.CustomExceptions
{
    public class GenerationException : TypeCobolException
    {
        public GenerationException(string message, string path, Exception innerException = null, bool logged = true, bool needMail = true, int columnStartIndex = 0, int columnEndIndex = 0, int lineNumber = 1) 
            : base (MessageCode.GenerationFailled, message, path, innerException, logged, needMail, columnStartIndex, columnEndIndex, lineNumber)
        {
            //Here you can do special thinks for this kind of exception... 
        }

    }
}
