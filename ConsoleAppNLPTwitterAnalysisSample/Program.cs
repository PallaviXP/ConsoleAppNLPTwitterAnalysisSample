using SimpleNetNlp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Tweetinvi;
using Tweetinvi.Events;
using Tweetinvi.Models;

namespace ConsoleAppNLPTwitterAnalysisSample
{
    class Program
    {
        static void Main(string[] args)
        {
            string consumerapikey = "FtJETokHdm8RuKViYGojugUOQ";
            string apisecret = "R0BmETX8RyfBiy6mJKoAPsbMyYb5YDBvb2ikFQewxQvDloGExi";
            string accesstoken = "186847510-Y9NmApSEnts7v5O0gumaq1bt7CEOVEXdjT0q2y7H";
            string accesstokensecret = "rBlqGU352mX6RrCgvD3QlD0rARtbuDHT73iIJsBjONYjd";

            Auth.SetUserCredentials(consumerapikey, apisecret, accesstoken, accesstokensecret);
            var stream = Stream.CreateFilteredStream();
            stream.AddTrack("cryptocurrencies");
            //stream.AddTrack("bitcoin");
            //stream.AddTrack("ether");
            //stream.AddTrack("Litecoin");
            stream.AddTweetLanguageFilter(LanguageFilter.English);
            stream.MatchingTweetReceived += OnMatchedTweet;
            stream.StartStreamMatchingAllConditions();

            Console.ReadLine();

        }
        private static void OnMatchedTweet(object sender, MatchedTweetReceivedEventArgs args)
        {
            Console.WriteLine("**********************************New match tweet received");
            Console.WriteLine($"{args.ToJson()}");

            var sanitized = sanitize(args.Tweet.FullText);
            var sentence = new Sentence(sanitized);

            Console.WriteLine("---------------------------------------");
            Console.WriteLine($"sentence :- {sentence.ToString()}");
            Console.WriteLine(sentence.Sentiment + "|" + args.Tweet);
            Console.WriteLine("**********************************");


        }

        private static string sanitize(string raw)
        {
            return Regex.Replace(raw, @"(@[A-Za-z0-9]+)|([^0-9A-Za-z \t])|(\w+:\/\/\S+)", " ").ToString();
        }
    }
}
