using System;

namespace Delegates
{
    public class UnpackService
    {
        public void OnFileDownloaded(object source, FileEventArgs e)
        {
            Console.WriteLine("UnpackerService: Unpacking the file..." + e.File.Title);
        }
    }
    
}
