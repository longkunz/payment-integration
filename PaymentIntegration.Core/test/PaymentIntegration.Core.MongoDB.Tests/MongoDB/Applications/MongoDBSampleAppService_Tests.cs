using PaymentIntegration.Core.MongoDB;
using PaymentIntegration.Core.Samples;
using Xunit;

namespace PaymentIntegration.Core.MongoDb.Applications;

[Collection(MongoTestCollection.Name)]
public class MongoDBSampleAppService_Tests : SampleAppService_Tests<CoreMongoDbTestModule>
{

}
