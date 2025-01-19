using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace LibRegex
{
    public class RenameFileToCorrespondingClass
    {

        private Regex _regex;
        private string _path;
        private string _pattern;
        private string _mainExtension;
        private string _slaveExtension;

        public string Path()
        { return _path; }

        public string Pattern()
        {
            return _pattern;
        }
        public string MainExtension()
        {
            return _mainExtension;
        }
        public string SlaveExtension()
        {
            return _slaveExtension;
        }

        public void SetPath(string path)
        { _path = path; }

        public void SetPattern(string pattern)
        {
            _pattern = pattern;
        }
        public void SetMainExtension(string mainExtension)
        {
            _mainExtension = mainExtension;
        }
        public void SetSlaveExtension(string slaveExtension)
        {
            _slaveExtension = slaveExtension;
        }


        public RenameFileToCorrespondingClass(string path, string pattern, string mainExtension = "mkv", string slaveExtension = "srt", RegexOptions options = RegexOptions.IgnoreCase)
        {
            _path = path;
            _pattern = pattern;
            _mainExtension = mainExtension;
            _slaveExtension = slaveExtension;
            _regex = new Regex(pattern, options);
        }
        public void RenameFileRegex()
        {
            DirectoryInfo dir_info = new DirectoryInfo(_path);
            IEnumerable<FileInfo> files = dir_info.EnumerateFiles();
            IList<FileInfo> ListSlave = new List<FileInfo>();
            IList<FileInfo> ListMain = new List<FileInfo>();
            foreach (FileInfo file in files)
            {
                if (file.Exists)
                {
                    if (file.Extension.Contains(_slaveExtension))
                    {
                        ListSlave.Add(file);
                    }
                    if (file.Extension.Contains(_mainExtension))
                    {
                        ListMain.Add(file);
                    }
                }
            }
            foreach (FileInfo fileMain in ListMain)
            {
                foreach (FileInfo fileSlave in ListSlave)
                {
                    RenameWithRegex(_path, fileMain, fileSlave);

                    //RenameSemRegex(path, fileMain, fileSTR);

                }
            }
        }
        public List<string[]> RenameFileName()
        {
            List<string[]> list = new List<string[]>();

            DirectoryInfo dir_info = new DirectoryInfo(_path);
            IEnumerable<FileInfo> files = dir_info.EnumerateFiles();
            IList<FileInfo> ListSlave = new List<FileInfo>();
            IList<FileInfo> ListMain = new List<FileInfo>();
            foreach (FileInfo file in files)
            {
                if (file.Exists)
                {
                    if (file.Extension.Contains(_slaveExtension))
                    {
                        ListSlave.Add(file);
                    }
                    if (file.Extension.Contains(_mainExtension))
                    {
                        ListMain.Add(file);
                    }
                }
            }
            foreach (FileInfo fileMain in ListMain)
            {
                foreach (FileInfo fileSlave in ListSlave)
                {
                    if (RenameWithRegex(_path, fileMain, fileSlave))
                    {
                        string[] filesArray = new string[2];
                        filesArray[0] = fileMain.Name;
                        filesArray[1] = fileSlave.Name;
                        list.Add(filesArray);
                    }
                    //RenameSemRegex(path, fileMain, fileSTR);
                }
            }
            return list;
        }
        private bool RenameWithRegex(string path, FileInfo fileMain, FileInfo fileSlave)
        {

            string nomeSlave = _regex.Match(fileSlave.Name).Value;
            string nomeMain = _regex.Match(fileMain.Name).Value;
            string originalPath;
            string newPath;
            try
            {
                //Regex reg = new Regex("(s\\d{2}e\\d{2})", RegexOptions.IgnoreCase);


                if (nomeSlave.ToUpper() == nomeMain.ToUpper())
                {
                    originalPath = path + "\\" + fileSlave.Name;
                    newPath = path + "\\" + fileMain.Name.Replace(fileMain.Extension, "") + fileSlave.Extension;
                    if (File.Exists(originalPath) && !File.Exists(newPath))
                    {
                        File.Move(originalPath, newPath);
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private bool RenameSemRegex(string path, FileInfo fileMain, FileInfo fileSlave)
        {
            string nomeSlave = fileSlave.Name.Substring(0, 15).ToLower();
            string nomeMain = fileMain.Name.Substring(0, 15).ToLower();
            if (nomeSlave == nomeMain)
            {
                string originalPath = path + "\\" + fileSlave.Name;
                string newPath = path + "\\" + fileMain.Name.Replace(fileMain.Extension, "") + fileSlave.Extension;

                File.Move(originalPath, newPath);
                return true;
            }
            return false;
        }
    }
}
