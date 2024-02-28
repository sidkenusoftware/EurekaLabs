using System.Management;

namespace Sidkenu.AccesoDatos.Constantes
{
    public static class Serial
    {
        public static string Obtener()
        {
            return $"{ObtenerNombreVolumenDiscoDuro}-{ObtenerNumeroSerie}";
        }

        private static string ObtenerNumeroSerie()
        {
            string serial = string.Empty;

            try
            {
                ManagementObjectSearcher searcher = new("SELECT SerialNumber FROM Win32_BIOS");

                ManagementObjectCollection collection = searcher.Get();

                foreach (ManagementObject obj in collection)
                {
                    serial = obj["SerialNumber"].ToString().Trim();
                }
            }
            catch (Exception ex)
            {
                // Manejar excepciones según sea necesario
                Console.WriteLine("Error al obtener el serial de la PC: " + ex.Message);
            }

            return serial;
        }

        private static string ObtenerNombreVolumenDiscoDuro()
        {
            // Obtiene el identificador único del disco duro (Volume Serial Number)
            DriveInfo drive = new DriveInfo(Path.GetPathRoot(Environment.SystemDirectory));

            return drive.VolumeLabel.ToString();
        }
    }
}
