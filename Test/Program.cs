﻿using System;
using Masuit.Tools.Html;

namespace Test
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            //FileStream fs = new FileStream(@"D:\boot.vmdk", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //{
            //    fs.CopyToFileAsync(@"D:\1.bak");
            //    string md5 = fs.GetFileMD5Async().Result;//获取文件的MD5
            //}
            //Console.WriteLine("复制完成");

            //bool isUrl;
            //var match = "//music.163.com/#/search/m/?%23%2Fmy%2Fm%2Fmusic%2Fempty=&s=fade&type=1!k".MatchUrl(out isUrl);
            //Console.WriteLine(isUrl);
            //foreach (Group g in match.Groups)
            //{
            //    if (g.Captures.Count > 0)
            //    {
            //        foreach (Capture c in g.Captures)
            //        {
            //            Console.WriteLine(c.Index + " : " + c.Value);
            //        }
            //    }
            //    else
            //    {
            //        Console.WriteLine(g.Index + " : " + g.Value);
            //    }
            //}

            //bool b1 = "512002199509230611".MatchIdentifyCard();//False
            //bool b2 = "140108197705058894".MatchIdentifyCard();//True
            //Console.WriteLine(b1 + "----" + b2);

            //bool isIP;
            //"114.114.256.114".MatchInetAddress(out isIP);//False
            //"114.114.114.114".MatchInetAddress(out isIP);//True
            //Console.WriteLine(isIP);
            //Console.WriteLine(WindowsCommand.Execute("help"));
            string match = "</span><img src='/upload/8ddb8887-3e84-4936-9921-51beb25351fe/index.004.png'  width=\"237\" height=\"77\"></p></span><img src='/upload/8ddb8887-3e84-4936-9921-51beb25351fe/index.003.png'  width=\"237\" height=\"77\"></p></span><img src='/upload/8ddb8887-3e84-4936-9921-51beb25351fe/index.002.png'  width=\"237\" height=\"77\"></p></span><img src='/upload/8ddb8887-3e84-4936-9921-51beb25351fe/index.001.png'  width=\"237\" height=\"77\"></p>".MatchRandomImgSrc();
            Console.WriteLine(match);
            Console.ReadKey();
        }
    }
}
