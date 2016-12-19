using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace global820
{
    public class ChatMessage
    {
        public string Message { get; set; }
        public string Sender { get; set; }
        /// <summary>
        /// Time the message Was sent
        /// </summary>
        public DateTime TimeStamp { get; set; }
        /// <summary>
        /// Channel the message was sent on
        /// </summary>
        public eChatChannel Channel { get; set; }
        public bool NotificationMatch { get; set; }

    }
}
