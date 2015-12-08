using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MUDDYBOOTS
{
    class StringUtils
    {
        public const string AndroidHiveFake = "http://api.androidhive.info/contacts/";
        public const string stageDataMapperLogin = "http://stage.datamapper.com:80/admin/api/v1/accounts/sign_in";
        public const string stageDataMapperSurvey = "http://stage.datamapper.com:80/api/v1/surveys";
        public const string fakeResponseSurveyString = "{" +
            "  \"surveys\": [\r\n" +
            "    {\r\n" +
            "        \"id\": \"9017a354-a683-40d8-becc-dd7d5eeb981e\",\r\n" +
            "        \"name\": \"Untitled\",\r\n" +
            "        \"status\": \"UPLOADING\"\r\n" +
            "    },\r\n" +
            "    {\r\n" +
            "        \"id\": \"505dd44d-df76-4cab-9f07-0a692f0e51e2\",\r\n" +
            "        \"name\": \"Untitled\",\r\n" +
            "        \"status\": \"UPLOADING\"\r\n" +
            "    }\r\n" +
            "  ]\r\n" +
            "}";
    }
}
