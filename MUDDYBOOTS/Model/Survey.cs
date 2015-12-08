using System;
using Windows.Data.Json;

namespace MUDDYBOOTS.Model
{
    public class Survey
    {
        public string upload_date { get; set; }
        public string upload_complete_date { get; set; }
        public int num_images { get; set; }
        public int survey_size_in_bytes { get; set; }
        //public string status { get; set; }       

        private const string idKey = "id";
        private const string surveyKey = "surveys";
        private const string nameKey = "name";
        private const string statusKey = "status";

        private string id;
        private string name;
        private string status;

        public string Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                name = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("value");
                }
                status = value;
            }
        }

        public Survey()
        {
            Id = "";
            Name = "";
            Status = "";
        }

        /*Connect the porperties to keys*/
        public Survey(JsonObject jsonObject)
        {
            JsonObject schoolObject = jsonObject.GetNamedObject(surveyKey, null);
            if (schoolObject != null)
            {
                //If internal objects add here
            }
            Id = jsonObject.GetNamedString(idKey, "");
            Name = jsonObject.GetNamedString(nameKey, "");
            Status = jsonObject.GetNamedString(statusKey);

        }
    }
}
