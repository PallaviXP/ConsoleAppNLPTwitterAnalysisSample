using System;
using Google.Cloud.Language.V1;
using Tweetinvi;
using Tweetinvi.Events;
using Tweetinvi.Models;

namespace NaturalLanguageApiDemo1
{
    class Program
    {
        static void Main(string[] args)
        {

            AccessTwitterAccount();
        }
        private static void AccessTwitterAccount()
        {
            string consumerapikey = "vBxKtpyhRecA4H2dktO1Q3G31";
            string apisecret = "B8TcrqMTPyfnUSoHkVvFfYQ85p3VsZwccw4Z9i7Axl9fo85Iqb";
            string accesstoken = "186847510-lsaTaQ8V2z5L7qaXioki0L4dJhhZhzpNljM6QxTm";
            string accesstokensecret = "EFwSevSFzdB34dzcyK7FHpl8oebGbfw3jSWH0wis9l830";

            Auth.SetUserCredentials(consumerapikey, apisecret, accesstoken, accesstokensecret);
            var stream = Stream.CreateFilteredStream();
            stream.AddTrack("mySampleCompany");
            stream.AddTweetLanguageFilter(LanguageFilter.English);
            stream.MatchingTweetReceived += OnMatchedTweet_AnalyseUsing_GoogleCloudNLPAPI;
            stream.StartStreamMatchingAllConditions();

            Console.ReadLine();
        }
        private static void OnMatchedTweet_AnalyseUsing_GoogleCloudNLPAPI(object sender, MatchedTweetReceivedEventArgs args)
        {
            Console.WriteLine("**********************************New match tweet received*********************");
            var sanitized = args.Tweet.FullText;
            var client = LanguageServiceClient.Create();
            var response = client.AnalyzeSentiment(Document.FromPlainText(sanitized));
            var sentiment = response.DocumentSentiment;
            Console.WriteLine($"tweet :- {args.Tweet}");
            Console.WriteLine($"Score: {sentiment.Score}");
            Console.WriteLine($"Magnitude: {sentiment.Magnitude}");

            Console.WriteLine("---------------------------------------");



            Console.WriteLine("***********************************************************************");
        }

    }
}
