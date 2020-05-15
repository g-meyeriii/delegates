using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace Delegates
{
    public class FileEventArgs: EventArgs
    {
        public File File { get; set; }
    }

    public class DownloadHelper
    {   // step 1 create a delegate
        //public delegate void FileDownloadedEventHandler(object source, FileEventArgs args);

       

        //step 2 create an event based on that delegate
        public event EventHandler<FileEventArgs> FileDownloaded;

        //Step 3 raise the event

        protected virtual void OnFileDownloaded(File file)
        {
            if (FileDownloaded != null)
            {
                FileDownloaded(this, new FileEventArgs(){ File = file});
            }
        }

        public void Download(File file)
        {
            Console.WriteLine("Downloading file...");
            Thread.Sleep(4000);

            // step 3.1
            OnFileDownloaded(file) ;
            

            
        }
    }
}
