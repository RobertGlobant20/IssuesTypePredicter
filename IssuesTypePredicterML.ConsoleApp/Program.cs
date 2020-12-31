// This file was auto-generated by ML.NET Model Builder. 

using System;
using IssuesTypePredicterML.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace IssuesTypePredicterML.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(args.Length);
            int isWishList = -1;

            if (args.Length > 0)
            {
                //Console.WriteLine(args[0]);
                IssueData issue = null;

                try
                {
                    var obj = JToken.Parse(args[0]);
                }
                catch (JsonReaderException jex)
                {
                    //Exception in parsing json
                    Console.WriteLine(jex.Message);
                }
                catch (Exception ex) //some other exception
                {
                    Console.WriteLine(ex.ToString());
                }

                try
                {
                    issue = JsonConvert.DeserializeObject<IssueData>(args[0]);
                    // Create single instance of sample data from first line of dataset for model input
                    ModelInput sampleData = new ModelInput()
                    {
                        Title = issue.Title,
                        Description = issue.Description,
                    };

                    // Make a single prediction on the sample data and print results
                    var predictionResult2 = ConsumeModel.Predict(sampleData);

                    isWishList = int.Parse(predictionResult2.Prediction);
                    Console.WriteLine(isWishList);
                }
                catch (JsonReaderException ex)
                {
                    Console.WriteLine(args[0]);
                    Console.WriteLine(ex.Message);
                }                       
            }
            else
            {
                Console.WriteLine("No Arguments Provided");
            }
        }
    }
}
