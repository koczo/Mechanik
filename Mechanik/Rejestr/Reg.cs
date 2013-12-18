using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace Mechanik.Rejestr
{
    class Reg
    {
        private string _path;
        public string Path 
        { 
            get
            {
                return _path = Odczytaj();   
            }

            set 
            {
                _path = Zapisz(value);
            }
        }
        const string regPath = "Software\\Mechanik";
        RegistryKey key = Registry.CurrentUser.OpenSubKey(regPath, true);

        public bool KeyExist()
        {
            
            return key != null;

        }

        public string Zapisz(string path)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(regPath, true);
            if (!KeyExist())
            {
                key = Registry.CurrentUser.CreateSubKey(regPath);
            }
               
            key.SetValue("path", path);
            key.Close();

            return path;
            
        }

        public string Odczytaj()
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey(regPath, true);
            string s = "";
            if (KeyExist())
            {
                 s = (string)key.GetValue("path");
                 key.Close();
            }
            
            if (s != "")
                return s;
            else
                return null;
            
        }



    }
}
