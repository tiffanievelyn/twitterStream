using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tweetinvi;

namespace twitterStream
{
    class Program
    {
        public static void Main(string[] args)
        {
            Auth.SetUserCredentials("dCfWgNmcMiUsMmmZkc0uhkZbq", "xETVYjlj8SEuluKRp85BDN9Twn0xDeMLfwrzzlufrzkUjiwz3R", "862690063624192000-9YQ9UZYGlU1trIVxjkn5HIpljnbKLFi", "qCQEPDRdKRT6gSnOtlArAvXHw8BfVnvuECKfaptKwFzEU");
            var stream = Stream.CreateFilteredStream();
            stream.AddTrack("Wednesday");
            stream.MatchingTweetReceived += (sender, theTweet) =>
            {
                Console.WriteLine($"A tweet containing Wednesday has been found; the tweet is {theTweet.Tweet}");
            };
            stream.StartStreamMatchingAllConditions();
        }
    }
}
