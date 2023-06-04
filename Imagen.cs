using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresa
{
    class Imagen
    {
        public string urlImage { set; get; }
        public string nombreImagen { set; get; }

        public Imagen(string urlImage, string nombreImagen)
        {
            this.urlImage = urlImage;
            this.nombreImagen = nombreImagen;
        }

        public Imagen()
        {
        }
    }
}
