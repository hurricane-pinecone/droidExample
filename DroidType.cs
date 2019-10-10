using GraphQL.Types;
using System;
using System.Collections.Generic;
using System.Text;

namespace testGraphQL
{
    class DroidType : ObjectGraphType<Droid>
    {
        public DroidType()
        {
            Name = "Droid";
            Description = "Some hunk of metal";
            Field(d => d.Name, nullable: false).Description("The name of the droid");

        }
    }
}
