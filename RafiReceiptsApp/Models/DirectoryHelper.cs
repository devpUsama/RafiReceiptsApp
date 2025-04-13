using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RafiReceiptsApp.Models
{
    public static class DirectoryHelper
    {
        public static bool IsDirectoryWritable(string dirPath)
        {
            try
            {
                string testFile = Path.Combine(dirPath, Path.GetRandomFileName());
                using (FileStream fs = File.Create(testFile, 1, FileOptions.DeleteOnClose))
                {
                    // If we can create and dispose a file, the folder is writable.
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

