﻿using System;

namespace TypeCobol.Compiler.CodeElements
{
    /// <summary>
    /// The factory IDENTIFICATION DIVISION introduces the factory definition, which
    /// is the portion of a class definition that defines the factory object of the class.
    /// </summary>
    public class FactoryEnd : CodeElementEnd
    {
        public FactoryEnd() : base(CodeElementType.FactoryEnd)
        { }

        public override void Accept<R, D>(ICodeElementVisitor<R, D> v, D data)
        {
            v.Visit(this, data);
        }
    }
}
