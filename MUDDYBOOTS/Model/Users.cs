using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Data.Json;

namespace MUDDYBOOTS.Model
{
    class Users
    {
        /*1*/
        private const string surveyKey = "surveys";
        /*2*/
        private ObservableCollection<Survey> survey;
        /*3*/
        public ObservableCollection<Survey> Survey
        {
            get
            {
                return survey;
            }
        }

        public Users()
        {
            survey = new ObservableCollection<Survey>();
        }
        /*Make Speacial Construtor*/
        public Users(string jsonString) : this()
        {
            JsonObject jsonObject = JsonObject.Parse(jsonString);

            foreach (IJsonValue jsonValue in jsonObject.GetNamedArray(surveyKey, new JsonArray()))
            {
                if (jsonValue.ValueType == JsonValueType.Object)
                {
                    Survey.Add(new Survey(jsonValue.GetObject()));
                }
            }
        }
    }
}
