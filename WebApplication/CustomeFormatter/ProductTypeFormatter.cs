using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web;

namespace WebApplication.CustomeFormatter
{

    public class Product
    {
        [Required]
        public string Name { get; set; }
        [Required]
        [Range(0, 99)]
        public string Description { get; set; }
    }



    public class ProductTypeFormatter : BufferedMediaTypeFormatter
    {
        public ProductTypeFormatter()
        {
            SupportedMediaTypes.Add(new System.Net.Http.Headers.MediaTypeHeaderValue("text/csv"));
        }

        public override bool CanReadType(Type type)
        {
            throw new NotImplementedException();
        }

        public override bool CanWriteType(Type type)
        {
            if (type == typeof(Product))
            {
                return true;
            }
            else
            {
                // not matching
                return false;
            }
        }
    }
}