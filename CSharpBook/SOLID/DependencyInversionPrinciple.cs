using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.SOLID
{

    // Abstractions
    interface IMessage
    {
        void SendMessage();
    }

    // Concrete Implementations
    class SendMail : IMessage
    {
        public SendMail() { }

        public void SendMessage()
        {
            Console.WriteLine("Email Implementation");
        }
    }

    class SendSMS : IMessage
    {
        public SendSMS() { }

        public void SendMessage()
        {
            Console.WriteLine("SMS Implementation");
        }
    }

    // High-Level Module
    class Notification
    {
        IMessage _objMsg;
        public Notification(IMessage objMsg)
        {
            _objMsg = objMsg;
        }

        public void SendMessage()
        {
            _objMsg.SendMessage();
        }
    }

    internal class DependencyInversionPrinciple
    {
        IMessage objSMS;
        IMessage objMail;

        public DependencyInversionPrinciple()
        {
            objSMS = new SendSMS();
            objMail = new SendMail();
        }


        public void MainMethod()
        {
            Notification notificationSMS = new Notification(objSMS);
            notificationSMS.SendMessage();
            Notification notificationMail = new Notification(objMail);
            notificationMail.SendMessage();
        }

    }
}
