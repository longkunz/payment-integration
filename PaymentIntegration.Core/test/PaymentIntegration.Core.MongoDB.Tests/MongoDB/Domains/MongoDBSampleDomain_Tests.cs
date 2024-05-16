using PaymentIntegration.Core.Samples;
using Xunit;

namespace PaymentIntegration.Core.MongoDB.Domains;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleDomain_Tests : SampleManager_Tests<CoreMongoDbTestModule>
{

}
