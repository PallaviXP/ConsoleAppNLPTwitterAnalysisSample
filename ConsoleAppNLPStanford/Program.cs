using SimpleNetNlp;
using System;
using System.Text.RegularExpressions;
using Tweetinvi;
using Tweetinvi.Events;
using Tweetinvi.Models;

namespace ConsoleAppNLPStanford
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
            stream.MatchingTweetReceived += OnMatchedTweet_AnalyseUsing_SimpleNetNlp;
            stream.StartStreamMatchingAllConditions();

            Console.ReadLine();
        }

        private static void OnMatchedTweet_AnalyseUsing_SimpleNetNlp(object sender, MatchedTweetReceivedEventArgs args)
        {
            Console.WriteLine("**********************************New match tweet received*********************");
            var sanitized = sanitize(args.Tweet.FullText);
            var sentence = new Sentence(sanitized);
           
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"sentence :- {sentence.ToString()}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"tweet :- {args.Tweet}");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"Statement's sentiments are :----- {sentence.Sentiment}");
            Console.WriteLine("***********************************************************************");
        }

        private static string sanitize(string raw)
        {
            return Regex.Replace(raw, @"(@[A-Za-z0-9]+)|([^0-9A-Za-z \t])|(\w+:\/\/\S+)", " ").ToString();
        }
    }
}
