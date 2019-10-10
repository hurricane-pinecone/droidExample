using GraphQL;
using GraphQL.Types;
using System;

namespace testGraphQL
{
    class Program
    {
        static void Main(string[] args)
        {
            var schema = new Schema {
                Query = new TestQuery()
            };

            var json = schema.Execute(_ =>
            {
                _.OperationName = "MyTestQuery";
                _.Query = @"
query MyTestQuery {
    hero {
        id
        name
    }
}
";
            });

            Console.WriteLine(json);
        }
    }
}
