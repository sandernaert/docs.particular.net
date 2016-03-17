﻿using System.Threading.Tasks;
using NServiceBus;
using NServiceBus.Logging;

public class Message1Handler : IHandleMessages<Message1>
{
    static ILog logger = LogManager.GetLogger<Message1Handler>();

    public async Task Handle(Message1 message, IMessageHandlerContext context)
    {
        logger.InfoFormat("Received Message1: {0}", message.Property);
        await context.Reply(new Message2
        {
            Property = "Hello from Endpoint2"
        });
    }
}