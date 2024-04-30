using Newtonsoft.Json;
using WebApi.Classes;
using WebApi.Interfaces;

namespace WebApi.Service
{
   
        public class UserinfoService : UserdataInterface
        {
            private readonly string _Userfilepath;
            public UserinfoService(string filepath)   //will try to get file path
            {
                _Userfilepath = filepath;
            }
            public ICollection<userdata> GetUserdatas()
            {
                try
                {
                    string jsonData = File.ReadAllText(_Userfilepath);
                    ICollection<userdata> userdata = JsonConvert.DeserializeObject<ICollection<userdata>>(jsonData);
                    return userdata;

                }
                catch (Exception ex)
                {
                    Console.WriteLine("error reading json file");
                    return new List<userdata>();
                }

            }


        }
    }

