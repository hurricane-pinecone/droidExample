using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace testGraphQL
{
    class TestQuery : ObjectGraphType
    {
        public TestQuery()
        {
            Field<DroidType>(
                "hero",
                resolve: context => new Droid { 
                    Id = 1,
                    Name = "R2D2"
                }
            );
        }
    }
}
