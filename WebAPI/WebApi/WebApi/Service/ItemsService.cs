using WebApi.Classes;
using WebApi.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Globalization;


namespace WebApi.Service
{
    public class ItemsService : IitemsInterface
    {
        private readonly string _filepath;
        public ItemsService(string filepath)   //will try to get file path
        {
            _filepath=filepath;
        }
        public ICollection<Items> GetItems()
        {
            try
            {
                string jsonData = File.ReadAllText(_filepath);
                ICollection<Items> items = JsonConvert.DeserializeObject<ICollection<Items>>(jsonData);
                return items;
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("error reading json file");
                return new List<Items>();
            }

        }

        
    }
}
