using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace AddressBookSystem
{
    public class FileOperations
    {
        public void FileExits()
        {
            string path = @"D:\.Net program\AddressBookSystem_ThirdPartyLibrary\AddressBookSystem\AddressBook.txt";
            if (File.Exists(path))
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File Not Found");
            }

        }


    }
}