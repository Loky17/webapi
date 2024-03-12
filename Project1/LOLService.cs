using Microsoft.AspNetCore.Identity;
using Newtonsoft.Json; 
using RiotSharp;
using RiotSharp.Endpoints.SummonerEndpoint;
using RiotSharp.Interfaces;
using RiotSharp.Misc;
using System;


namespace Project1
{
    public class LOLService
    {
        RiotApi Api { get; set; }
        public LOLService()
        {
            Api = RiotApi.GetDevelopmentInstance(File.ReadAllText("ApiKey/Apikey.ini"));
        }
        public async Task<Summoner> GetSummonerAsync(string username, Region region)
        {
            Summoner nome = new();
            return await Api.Summoner.GetSummonerByNameAsync(region,username);
        }
    }
}
