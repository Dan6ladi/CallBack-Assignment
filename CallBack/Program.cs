namespace CallBack
{
    public delegate void Download(int a);
   
    internal class Program
    {
        

        static void Main(string[] args)
        {
            File file = new File();
            Download download = new Download(file.CallBack);
            file.FileDownload(download);
           
            Console.ReadLine();
        }
    }

    public class File
    {
        public void FileDownload(Download download) 
        {
            for (int i = 0; i < 1000  ; i++) 
            {
                Console.WriteLine($"The file has been downloaded");

            }
        }
        public void CallBack(int i) 
        {
            Console.WriteLine($"The File download has been completed {i} times");
        }
    }
}