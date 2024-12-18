using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace RandomSelection{
    public static class Operation{
        public static string DbPath { get; set; } = $"{AppDomain.CurrentDomain.BaseDirectory}\\Caches.dll";
        public static void SaveToDb<T>(T t){
            var json = JsonConvert.SerializeObject(t);
            using(var sw = new StreamWriter(DbPath, false, Encoding.UTF8)) {
                sw.Write(json);
                sw.Close();
            }
        }
        public static T LoadFoDb<T>(){
            if (!File.Exists(DbPath)) return default(T);
            using(var sr = new StreamReader(DbPath, Encoding.UTF8)) {
                var json = sr.ReadToEnd();
                var t    = JsonConvert.DeserializeObject<T>(json);
                sr.Close();
                return t;
            }
        }
        public static string[][] LoadFoCsv(string path, int colCount = 0, bool skipT1 = true, char colSeparator = ','){
            var array = new List<string[]>();
            using (var sr = new StreamReader(path, Encoding.UTF8))
            {
                var line ="-";
                var i = 0;
                while (line != null)
                {
                    i++;
                    Console.WriteLine(i);
                    line = sr.ReadLine();
                    if (skipT1 && i == 1) continue;
                    if(line == null) continue;
                    var cols = line.Split(colSeparator);
                    if (colCount > 0 && colCount != cols.Length) continue;
                    array.Add(cols);
                }
                sr.Close();
            }
            return array.ToArray();
        }
        public static List<Organ> GetOrgans(string[][] array){
            return array.Select(items=>new Organ(items)).ToList();
        }
    }
}