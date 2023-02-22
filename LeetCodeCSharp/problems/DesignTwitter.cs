using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeCSharp.problems
{
    internal class Twitter
    {

        private Stack<int> tweets = new();
        private Dictionary<int, int> tweetUserMap = new();
        private Dictionary<int, HashSet<int>> userFollowersMap = new();

        public Twitter()
        {
        }

        public void PostTweet(int userId, int tweetId)
        {
            CreateUserIfDoesNotExist(userId);
            tweetUserMap.Add(tweetId, userId);
            tweets.Push(tweetId);
        }

        public IList<int> GetNewsFeed(int userId)
        {
            CreateUserIfDoesNotExist(userId);

            List<int> feed = new();
            Stack<int> tweetsCopy = new(tweets.Reverse());

            while (feed.Count < 10 && tweetsCopy.Count > 0)
            {
                int tweet = tweetsCopy.Pop();
                int user = tweetUserMap[tweet];

                if (userFollowersMap[userId].Contains(user))
                {
                    feed.Add(tweet);
                }
            }
            return feed;
        }

        public void Follow(int followerId, int followeeId)
        {
            CreateUserIfDoesNotExist(followerId, followeeId);
            userFollowersMap[followerId].Add(followeeId);
        }

        public void Unfollow(int followerId, int followeeId)
        {
            userFollowersMap[followerId].Remove(followeeId);
        }

        private void CreateUserIfDoesNotExist(params int[] userIds)
        {
            foreach (int userId in userIds)
            {
                userFollowersMap.TryAdd(userId, new HashSet<int> { userId });
            }
        }
    }
}
