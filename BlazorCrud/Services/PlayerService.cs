using BlazorCrud.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace BlazorCrud.Services
{
    public class PlayerService
    {
        private readonly IMongoCollection<Player> _roster;
        public PlayerService(IBballDbSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);
            
            _roster = database.GetCollection<Player>(settings.RosterCollectionName);
        }
        public List<Player> GetRoster() => _roster.Find(player => true).ToList();
        public Player GetPlayer(string id)
        {
            return _roster.Find(player => player.Id == id).FirstOrDefault();
        }
        public Player AddPlayer(Player player)
        {
            _roster.InsertOne(player);
            return player;
        }
        public void Update(string id, Player playerIn)
        {
            _roster.ReplaceOne(player => player.Id == id, playerIn);
        }
        public void Remove(string id)
        {
            _roster.DeleteOne(player => player.Id == id);
        }
    }
}
