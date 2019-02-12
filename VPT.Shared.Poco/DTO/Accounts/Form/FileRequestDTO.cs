using System;
using Newtonsoft.Json;
using System.IO;

namespace VPT.Shared.Poco.DTO.Accounts.Form
{
    public class FileRequestDTO
    {
        public FileRequestDTO(string creatorId, byte[] content, string fileName)
        {
            CreatorId = creatorId;
            Content = content;
            SetFileName(fileName);
        }

        public string Name { get; set; }

        public string Extension { get; set; }
        public byte[] Content { get; set; }

        public string CreatorId { get; set; }

        public string FullName
        {
            get
            {
                return string.Format("{0}.{1}", Name, Extension);
            }
        }

        protected void SetFileName(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                return;
            }

            Extension = Path.GetExtension(fileName).TrimStart('.');
            Name = Path.GetFileNameWithoutExtension(fileName).TrimEnd('.');
        }
    }
}
