using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaCeiba.Models
{
    static class TOOLS
    {
        //Funcion para agragar imagen a un pictureBox
        public static void SeleccionarImagen(PictureBox pictureBox)
        {
            var FileDialog = new OpenFileDialog();
            FileDialog.Filter = "Imagenes|*.png;*.jpg;*.jpeg|All files(*.*)|*.*";
            var result = FileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                pictureBox.Image = new Bitmap(FileDialog.FileName);
                //MessageBox.Show(FileDialog.FileName);
            }


        }

        //Funcion que convierte Imagen a binario
        public static byte[] ConvertirImagenBinario(Bitmap pictureBox)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Guardar la imagen del PictureBox en el flujo de memoria
                pictureBox.Save(memoryStream, pictureBox.RawFormat);

                // Convertir la imagen a un array de bytes
                return memoryStream.ToArray();
            }
        }

        //Funcion que convierte binario a imagen
        public static Image ConvertirBinarioImagen(byte[] byteArray)
        {
            using (MemoryStream memoryStream = new MemoryStream(byteArray))
            {
                // Crear una imagen desde el array de bytes
                Image imagen = Image.FromStream(memoryStream);
                return imagen;
            }
        }
    }
}
