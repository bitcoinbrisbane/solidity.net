using System;

namespace NSolc.libsolidity.codegen
{
    public class ABIFunctions
    {
        public static String tupleEncoder(bool _encodeAsLibraryTypes)
        {
/*            string functionName = "abi_encode_tuple_";

            for (auto const& t: _givenTypes)
                functionName += t->identifier() + "_";

            functionName += "_to_";
            for (auto const& t: _targetTypes)
                functionName += t->identifier() + "_";

            if (_encodeAsLibraryTypes)
                functionName += "_library";

            return createFunction(functionNa*/me);
        }

        public static String tupleDecoder()
        {
            throw new NotImplementedException();
        }

        //Returns concatenation of all generated functions.
        public static String requestedFunctions()
        {
            throw new NotImplementedException();
        }

        private static String cleanupFunction()
        {
            throw new NotImplementedException();
        }

        private static String createFunction(string functionName)
        {
            throw new NotImplementedException();
        }
    }
}