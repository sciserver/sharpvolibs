﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Jhu.VO
{
    public class TestClassBase
    {
        /// <summary>
        /// Find the inmost directory with a solution file
        /// </summary>
        /// <returns></returns>
        protected static string GetSolutionDir()
        {
            var dir = Environment.CurrentDirectory;

            while (dir != null)
            {
                var files = Directory.GetFiles(dir, "*.sln");

                if (files != null && files.Length > 0)
                {
                    return dir;
                }

                dir = Directory.GetParent(dir)?.FullName;
            }

            return dir;
        }

        protected static string GetTestFilePath(string filename)
        {
            var sln = GetSolutionDir();
            return Path.Combine(sln, filename);
        }

        protected string GetTestFilePath(params string[] filename)
        {
            var sln = GetSolutionDir();
            return Path.Combine(sln, Path.Combine(filename));
        }
    }
}
