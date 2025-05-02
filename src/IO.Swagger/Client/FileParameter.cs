using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IO.Swagger.Client
{
    public class FileParameter
    {
        public string Name { get; set; }

        public byte[] Data { get; set; }

        public string FileName { get; set; }

        public string ContentType { get; set; }

        public static FileParameter Create(string name, byte[] data, string fileName = null, string contentType = null)
        {
            return new FileParameter
            {
                Name = name,
                Data = data,
                FileName = fileName ?? "no_file_name_provided",
                ContentType = contentType ?? "application/octet-stream"
            };
        }
    }
}
