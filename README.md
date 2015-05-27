# EasyNetQCustomErrorStategy
Quick and easy way to leave messages in the queue on error.

Register:

```
using (var bus = RabbitHutch.CreateBus("<your connection string>",serviceRegister =>
serviceRegister.Register<IConsumerErrorStrategy, MyConsumerErrorStrategy>()))
{
  // bus stuff
}
```
