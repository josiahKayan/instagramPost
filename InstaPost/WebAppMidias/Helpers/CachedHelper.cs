using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace WebAppMidias.Helpers
{
    public class CachedHelper
    {

        readonly static List<string> CachedFiles = new List<string>();
        public static void AddFile(string path)
        {
            CachedFiles.Add(path);
        }
        public static void DeleteCachedFiles()
        {
            try
            {
                foreach (var item in CachedFiles)
                    if (File.Exists(item))
                        File.Delete(item);
                System.Threading.Thread.Sleep(150);
                CachedFiles.Clear();
            }
            catch { }
        }

    }
}