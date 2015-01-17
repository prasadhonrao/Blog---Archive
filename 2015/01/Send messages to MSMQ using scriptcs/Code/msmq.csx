#r System.Messaging;
using System.Messaging;

const string queueAddress = @".\private$\msmq-scriptcs-test";

using (var msmq = new MessageQueue(queueAddress))
{
for (int i = 0 ; i < 10; i++)
	{
		var message = new Message(i.ToString());
		msmq.Send(message);
	}
}

Console.WriteLine("Messages sent successfully");
Console.ReadLine();