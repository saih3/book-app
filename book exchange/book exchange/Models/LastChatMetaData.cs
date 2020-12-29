using System;
using System.Collections.Generic;
using System.Text;

namespace book_exchange.Models
{
    /// <summary>
    /// Last chats infomations class such as: Last messages, hours,
    /// messages content, ....
    /// </summary>
    public class LastChatMetaData
    {
        public long LastChatMetaDataID { get; set; }
        public string LastChatDatetime { get; set; }
        public bool MessageIsFromMe { get; set; }
        public string MessageContent { get; set; }
    }
}
