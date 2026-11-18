using System;
using System.IO;

namespace GreenLifeOrganicStore.Utils
{

    public static class FileHelper
    {

        public static string GetDataPath(string fileName)
        {
            string folderPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Data");
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            return Path.Combine(folderPath, fileName);
        }
    }
}
