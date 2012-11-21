using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace dbdit.BLL.Lib
{
    public class BResult
    {
        public bool IsValid
        {
            get
            {
                return !(this.Messages.Count > 0);
            }
        }
        public IDictionary<string, string> Messages { get; set; }

        public void AddError(string key, string message)
        {
            this.Messages.Add(key, message);
        }

        public void AddErrors(IDictionary<string, string> messages)
        {
            foreach (var msg in messages)
            {
                this.AddError(msg.Key, msg.Value);
            }
        }

        public BResult()
        {
            this.Messages = new Dictionary<string, string>();
        }

        public BResult(IDictionary<string, string> messages)
        {
            this.Messages = messages;
        }
    }
}
