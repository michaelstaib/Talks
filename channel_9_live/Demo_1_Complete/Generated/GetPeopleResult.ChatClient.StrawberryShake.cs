﻿#nullable enable

namespace Demo
{
    [global::System.CodeDom.Compiler.GeneratedCode("StrawberryShake", "11.0.0")]
    public partial class GetPeopleResult
        : IGetPeopleResult
    {
        public GetPeopleResult(IGetPeople_People? people)
        {
            People = people;
        }

        public IGetPeople_People? People { get; } = default!;
    }
}
