using System;
using System.IO;
using System.Net;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Text;
using static MainClass.person;
using Newtonsoft.Json.Linq;
using System.Linq;

class MainClass
{

    static void Main()
    {

       
        var result = JsonConvert.DeserializeObject<person>("{\"name\":{\"first\":\"Robert\",\"middle\":\"\",\"last\":\"Smith\"},\"age\":25,\"DOB\":\"-\",\"hobbies\":[\"running\",\"coding\",\"-\"],\"education\":{\"highschool\":\"N\\/A\",\"college\":\"Yale\"}}");

        Console.WriteLine(result.ToString());

    }


    public class person
    {
       

        public class name
        {
            public string first { get; set; }
            public string middle { get; set; }
            public string last { get; set; }
        }
        public int? age { get; set; }
        public string DOB { get; set; }
        public string[] hobbies { get; set; }
        public class education
        {
            public string highschool { get; set; }
            public string college { get; set; }


        }
        public name Name { get; set; }
        public education EducationDetails { get; set; }

        public override string ToString()
        {
            if (this.EducationDetails is not null)
            {
                if (this.EducationDetails.college == string.Empty || this.EducationDetails.college == "-" || this.EducationDetails.college == "N/A")
                {
                    this.EducationDetails.college = null;
                }
                if (this.EducationDetails.highschool == string.Empty || this.EducationDetails.highschool == "-" || this.EducationDetails.highschool == "N/A")
                {
                    this.EducationDetails.highschool = null;
                }
            }

            if (this.Name is not null)
            {
                if (this.Name.first == string.Empty || this.Name.first == "-" || this.Name.first == "N/A")
                {
                    this.Name.first = null;
                }
                if (this.Name.middle == string.Empty || this.Name.middle == "-" || this.Name.middle == "N/A")
                {
                    this.Name.middle = null;
                }
                if (this.Name.last == string.Empty || this.Name.last == "-" || this.Name.last == "N/A")
                {
                    this.Name.last = null;
                }
            }

            if (this.DOB == string.Empty || this.DOB == "-" || this.DOB == "N/A")
            {
                this.DOB = null;
            }
            this.hobbies = (this.hobbies?.Where(y => !((y == string.Empty) || (y == "-") || (y == "N/A")))).ToArray();
            if (this.hobbies.Length >0 == false)
            {
                this.hobbies = null;

            }
            return JsonConvert.SerializeObject(this, Formatting.None,
                   new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}