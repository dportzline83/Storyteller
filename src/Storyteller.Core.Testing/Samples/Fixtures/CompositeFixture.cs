using System;
using Storyteller.Core.Grammars.Tables;

namespace Storyteller.Core.Testing.Samples.Fixtures
{
    public class CompositeFixture : MathFixture
    {
        public CompositeFixture()
        {
            this["AddAndMultiply"] = Paragraph("Add and Multiply", x =>
            {
                x += this["StartWith"];
                x += this["Add"];
                x += this["MultiplyBy"];
                x += this["TheValueShouldBe"];
            });

            this["AddAndMultiplyTable"] = this["AddAndMultiply"].AsTable("Add and Multiply in a Table");

            this["AddAndMultiplyThrow"] = Paragraph("Add and Multiply", x =>
            {
                x += this["StartWith"];
                x += this["Add"];
                x += this["MultiplyBy"];
                x += c => { throw new NotImplementedException(); };
                x += this["TheValueShouldBe"];
            });
        }
    }
}