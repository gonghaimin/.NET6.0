using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Catch和Finally块中的Await
    {
        static void Main1(string[] args)
        {
            /*catch支持筛选条件*/
            try
            {
                throw new Exception();
            }
            catch (Exception ex) when (ex.HResult== -2146233088)
            {
                Console.WriteLine(ex.HResult);
                
            }
            Console.Read();
        }
        async Task Test()
        {
            /*catch和finally语句块中支持await*/
            var wc = new WebClient();
            try
            {
                await wc.DownloadDataTaskAsync("");
            }
            catch (Exception e) when (e.HResult == 0x800000C)  
            {
                await wc.DownloadDataTaskAsync("");
            }
            finally
            {
                await wc.DownloadDataTaskAsync("");
            }
        }
    }
}
