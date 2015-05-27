  public class MyConsumerErrorStrategy : DefaultConsumerErrorStrategy, IConsumerErrorStrategy
    {
        public MyConsumerErrorStrategy(IConnectionFactory connectionFactory, ISerializer serializer, IEasyNetQLogger logger, IConventions conventions, ITypeNameSerializer typeNameSerializer)
            : base(connectionFactory, serializer, logger, conventions, typeNameSerializer){}

        public override AckStrategy HandleConsumerError(ConsumerExecutionContext context, Exception exception)
        {
            return AckStrategies.Nothing;
        }

    }
