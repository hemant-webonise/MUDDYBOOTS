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
        public const string testDataMapperSurvey = "http://test.datamapper.com:80/api/v1/surveys";
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

        public const string fakeResponseSurveyStringUpdate = "{" +
            "  \"surveys\": [\r\n" +
            "    {\r\n" +
            "        \"id\": \"9017a354-a683-40d8-becc-dd7d5eeb981e\",\r\n" +
            "        \"name\": \"Untitled\",\r\n" +
            "        \"title\": \"Raleigh Multisprectral 200 meters\",\r\n" +
            "        \"latitude\": 35.8439646,\r\n" +
            "        \"longitude\": -78.7854862,\r\n" +
            "        \"status\": \"UPLOADING\"\r\n" +
            "    },\r\n" +
            "    {\r\n" +
            "        \"id\": \"505dd44d-df76-4cab-9f07-0a692f0e51e2\",\r\n" +
            "        \"name\": \"Untitled\",\r\n" +
            "        \"title\": \"New York\",\r\n" +
            "        \"latitude\": 35.8439646,\r\n" +
            "        \"longitude\": -78.7854862,\r\n" +
            "        \"status\": \"UPLOADING\"\r\n" +
            "    },\r\n" +
            "    {\r\n" +
            "        \"id\": \"505dd44d-df76-4cab-9f07-0a692f0e51e2\",\r\n" +
            "        \"name\": \"Untitled\",\r\n" +
            "        \"title\": \"New Jersey\",\r\n" +
            "        \"latitude\": 40.725581,\r\n" +
            "        \"longitude\": -73.998078,\r\n" +
            "        \"status\": \"UPLOADING\"\r\n" +
            "    },\r\n" +
            "    {\r\n" +
            "        \"id\": \"505dd44d-df76-4cab-9f07-0a692f0e51e2\",\r\n" +
            "        \"name\": \"Untitled\",\r\n" +
            "        \"title\": \"30 Broad St, New York\",\r\n" +
            "        \"latitude\": 40.706241,\r\n" +
            "        \"longitude\":-74.011284,\r\n" +
            "        \"status\": \"UPLOADING\"\r\n" +
            "    },\r\n" +
            "    {\r\n" +
            "        \"id\": \"505dd44d-df76-4cab-9f07-0a692f0e51e2\",\r\n" +
            "        \"name\": \"Untitled\",\r\n" +
            "        \"title\": \"Farmingdale\",\r\n" +
            "        \"latitude\":40.722294,\r\n" +
            "        \"longitude\": -73.418101,\r\n" +
            "        \"status\": \"UPLOADING\"\r\n" +
            "    },\r\n" +
             "    {\r\n" +
            "        \"id\": \"505dd44d-df76-4cab-9f07-0a692f0e51e2\",\r\n" +
            "        \"name\": \"Untitled\",\r\n" +
            "        \"title\": \"Whitestone\",\r\n" +
            "        \"latitude\":  40.789146,\r\n" +
            "        \"longitude\":-73.814068,\r\n" +
            "        \"status\": \"UPLOADING\"\r\n" +
            "    },\r\n" +
            "    {\r\n" +
            "        \"id\": \"505dd44d-df76-4cab-9f07-0a692f0e51e2\",\r\n" +
            "        \"name\": \"Untitled\",\r\n" +
            "        \"title\": \"Stamford\",\r\n" +
            "        \"latitude\": 41.090444,\r\n" +
            "        \"longitude\": -73.515406,\r\n" +
            "        \"status\": \"UPLOADING\"\r\n" +
            "    },\r\n" +
             "    {\r\n" +
            "        \"id\": \"505dd44d-df76-4cab-9f07-0a692f0e51e2\",\r\n" +
            "        \"name\": \"Untitled\",\r\n" +
            "        \"title\": \"Landing\",\r\n" +
            "        \"latitude\": 35.8439646,\r\n" +
            "        \"longitude\": -78.7854862,\r\n" +
            "        \"status\": \"UPLOADING\"\r\n" +
            "    },\r\n" +
            "    {\r\n" +
            "        \"id\": \"505dd44d-df76-4cab-9f07-0a692f0e51e2\",\r\n" +
            "        \"name\": \"Untitled\",\r\n" +
            "        \"title\": \"New Jersey\",\r\n" +
            "        \"latitude\": 35.8432,\r\n" +
            "        \"longitude\": -78.7834862,\r\n" +
            "        \"status\": \"UPLOADING\"\r\n" +
            "    },\r\n" +
            "    {\r\n" +
            "        \"id\": \"505dd44d-df76-4cab-9f07-0a692f0e51e2\",\r\n" +
            "        \"name\": \"Untitled\",\r\n" +
            "        \"title\": \"New York\",\r\n" +
            "        \"latitude\": 40.753072,\r\n" +
            "        \"longitude\": -73.997575,\r\n" +
            "        \"status\": \"UPLOADING\"\r\n" +
            "    },\r\n" +
            "    {\r\n" +
            "        \"id\": \"505dd44d-df76-4cab-9f07-0a692f0e51e2\",\r\n" +
            "        \"name\": \"Untitled\",\r\n" +
            "        \"title\": \"Detroit\",\r\n" +
            "        \"latitude\": 42.8439646,\r\n" +
            "        \"longitude\": -83.7254862,\r\n" +
            "        \"status\": \"UPLOADING\"\r\n" +
            "    },\r\n" +
            "    {\r\n" +
            "        \"id\": \"505dd44d-df76-4cab-9f07-0a692f0e51e2\",\r\n" +
            "        \"name\": \"Untitled\",\r\n" +
            "        \"title\": \"Chicago\",\r\n" +
            "        \"latitude\": 42.8439646,\r\n" +
            "        \"longitude\": -81.7854862,\r\n" +
            "        \"status\": \"UPLOADING\"\r\n" +
            "    },\r\n" +
            "    {\r\n" +
            "        \"id\": \"505dd44d-df76-4cab-9f07-0a692f0e51e2\",\r\n" +
            "        \"name\": \"Untitled\",\r\n" +
            "        \"title\": \"Columbus\",\r\n" +
            "        \"latitude\": 42.8439646,\r\n" +
            "        \"longitude\": -83.7854862,\r\n" +
            "        \"status\": \"UPLOADING\"\r\n" +
            "    },\r\n" +
            "    {\r\n" +
            "        \"id\": \"505dd44d-df76-4cab-9f07-0a692f0e51e2\",\r\n" +
            "        \"name\": \"Untitled\",\r\n" +
            "        \"title\": \"Chicago\",\r\n" +
            "        \"latitude\": 42.8439646,\r\n" +
            "        \"longitude\": -81.7854862,\r\n" +
            "        \"status\": \"UPLOADING\"\r\n" +
            "    },\r\n" +
            "    {\r\n" +
            "        \"id\": \"505dd44d-df76-4cab-9f07-0a692f0e51e2\",\r\n" +
            "        \"name\": \"Untitled\",\r\n" +
            "        \"title\": \"Mexico\",\r\n" +
            "        \"latitude\": 19.26,\r\n" +
            "        \"longitude\": -99.17,\r\n" +
            "        \"status\": \"UPLOADING\"\r\n" +
            "    }\r\n" +
            "  ]\r\n" +
            "}";
    }
}
