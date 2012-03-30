= VoltDB C# Client Library

The VoltDB client library implements the native VoltDB wire
protocol. You can use the library to connect to a VoltDB cluster,
invoke stored procedures and read responses.

The Using VoltDB Guide explains how to use the CPP library in the
chapter 12.1.2: Writing VoltDB Client Applications in C++.

Binaries for 64-bit Linux and 64-bit OSX 10.5+ are provided. The
linking instructions below apply to the Linux binaries.


== Linking against libvoltdb.a

The following command will compile and link an example client
(clientvoter.cpp) libvoltdb.a.

Directory structure for this example:

./clientvoter.cpp     # Example client
./voltdb/include/     # Directory containing client library headers
./voltdb/lib          # Directory containing client library archive

g++ -lrt -I./voltdb/usr/include/ \
-D__STDC_LIMIT_MACROS            \
-DBOOST_SP_DISABLE_THREADS       \
clientvoter.cpp                  \
./voltdb/lib/libvoltcpp.a        \
-o clientvoter

==== Example clientvoter.cpp

/*
 This very simple example demonstrates a few basic concepts.
 This example executes against the 'voter' example included
 in the voltdb distribution.

 The "Using VoltDB Guide" includes more complete information.
*/

#include "Client.h"
#include "Parameter.hpp"
#include "ParameterSet.hpp"
#include "Row.hpp"
#include "Table.h"
#include "TableIterator.h"
#include "WireType.h"

#include <vector>

using namespace std;

int main(int argc, char** argv) {

    // instantiate a voltdb::Client instance
    voltdb::Client client = voltdb::Client::create();
    client.createConnection("localhost");

    // create a procedure instance for the Initialize procedure
    vector<voltdb::Parameter> initParamTypes(2);
    initParamTypes[0] = voltdb::Parameter(voltdb::WIRE_TYPE_INTEGER);
    initParamTypes[1] = voltdb::Parameter(voltdb::WIRE_TYPE_STRING);
    voltdb::Procedure initialize("Initialize", initParamTypes);
    voltdb::ParameterSet *initParams = initialize.params();

    // invoke the Initialize procedure
    int64_t maxContestant = 4;
    string contestantNames = "Edwina Burnam,Tabatha Gehling,Kelly Clauss,Jessie Alloway";
    initParams->addInt32(maxContestant);
    initParams->addString(contestantNames);
    voltdb::InvocationResponse initResponse = client.invoke(initialize);

    if (initResponse.failure()) {
        cout << "Initialization failed. " << initResponse.toString() << endl;
        return -1;
    }

    cout << "Successfully connected and initialized the database." << endl;
    return 0;
}