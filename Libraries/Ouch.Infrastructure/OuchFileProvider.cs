using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.FileProviders;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.AccessControl;
using System.Text;

namespace Ouch.Core.Infrastructure
{
    /// <summary>
    /// IO functions using the on-disk file system
    /// </summary>
    public class OuchFileProvider : PhysicalFileProvider, IOuchFileProvider
    {
        #region Ctor

        public OuchFileProvider(IWebHostEnvironment hostingEnvironment)
            : base(File.Exists(hostingEnvironment.WebRootPath) ? Path.GetDirectoryName(hostingEnvironment.WebRootPath) : hostingEnvironment.WebRootPath)

        {
            var path = hostingEnvironment.ContentRootPath ?? string.Empty;
            if (File.Exists(path))
                path = Path.GetDirectoryName(path);

            BaseDirectory = path;
        }

        #endregion

        #region Methods

        public string Combine(params string[] paths)
        {
            throw new NotImplementedException();
        }

        public void CreateDirectory(string path)
        {
            throw new NotImplementedException();
        }

        public void CreateFile(string path)
        {
            throw new NotImplementedException();
        }

        public void DeleteDirectory(string path)
        {
            throw new NotImplementedException();
        }

        public void DeleteFile(string filePath)
        {
            throw new NotImplementedException();
        }

        public bool DirectoryExists(string path)
        {
            throw new NotImplementedException();
        }

        public void DirectoryMove(string sourceDirName, string destDirName)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> EnumerateFiles(string directoryPath, string searchPattern, bool topDirectoryOnly = true)
        {
            throw new NotImplementedException();
        }

        public void FileCopy(string sourceFileName, string destFileName, bool overwrite = false)
        {
            throw new NotImplementedException();
        }

        public bool FileExists(string filePath)
        {
            throw new NotImplementedException();
        }

        public long FileLength(string path)
        {
            throw new NotImplementedException();
        }

        public void FileMove(string sourceFileName, string destFileName)
        {
            throw new NotImplementedException();
        }

        public string GetAbsolutePath(params string[] paths)
        {
            throw new NotImplementedException();
        }

        public DirectorySecurity GetAccessControl(string path)
        {
            throw new NotImplementedException();
        }

        public DateTime GetCreationTime(string path)
        {
            throw new NotImplementedException();
        }

        public string[] GetDirectories(string path, string searchPattern = "", bool topDirectoryOnly = true)
        {
            throw new NotImplementedException();
        }

        public string GetDirectoryName(string path)
        {
            throw new NotImplementedException();
        }

        public string GetDirectoryNameOnly(string path)
        {
            throw new NotImplementedException();
        }

        public string GetFileExtension(string filePath)
        {
            throw new NotImplementedException();
        }

        public string GetFileName(string path)
        {
            throw new NotImplementedException();
        }

        public string GetFileNameWithoutExtension(string filePath)
        {
            throw new NotImplementedException();
        }

        public string[] GetFiles(string directoryPath, string searchPattern = "", bool topDirectoryOnly = true)
        {
            throw new NotImplementedException();
        }

        public DateTime GetLastAccessTime(string path)
        {
            throw new NotImplementedException();
        }

        public DateTime GetLastWriteTime(string path)
        {
            throw new NotImplementedException();
        }

        public DateTime GetLastWriteTimeUtc(string path)
        {
            throw new NotImplementedException();
        }

        public string GetParentDirectory(string directoryPath)
        {
            throw new NotImplementedException();
        }

        public string GetVirtualPath(string path)
        {
            throw new NotImplementedException();
        }

        public bool IsDirectory(string path)
        {
            throw new NotImplementedException();
        }

        public string MapPath(string path)
        {
            throw new NotImplementedException();
        }

        public byte[] ReadAllBytes(string filePath)
        {
            throw new NotImplementedException();
        }

        public string ReadAllText(string path, Encoding encoding)
        {
            throw new NotImplementedException();
        }

        public void SetLastWriteTimeUtc(string path, DateTime lastWriteTimeUtc)
        {
            throw new NotImplementedException();
        }

        public void WriteAllBytes(string filePath, byte[] bytes)
        {
            throw new NotImplementedException();
        }

        public void WriteAllText(string path, string contents, Encoding encoding)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region properties

        protected string BaseDirectory { get; }

        #endregion
    }
}
