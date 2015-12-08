using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Json;

namespace MUDDYBOOTS.Model
{
    public class SuccessStatus
    {
        private const string idKey = "auth_token";

        public SuccessStatus(string jsonString) : this()
        {
            JsonObject jsonObject = JsonObject.Parse(jsonString);
            Auth_token = jsonObject.GetNamedString(idKey, "");
        }

        public SuccessStatus()
        {
            Auth_token = "";
        }

        public bool success { get; set; }
        public int status { get; set; }
        public string Auth_token { get; set; }
    }
}
