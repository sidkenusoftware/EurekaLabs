using Sidkenu.LogicaNegocio.Servicios.DTOs.Seguridad.Formulario;
using System.Reflection;

namespace SidkenuWF.Formularios.Base.Constantes
{
    public static class FormularioAssemblie
    {
        public static List<FormularioDTO> GetAllFormNames(Assembly[] assemblies)
        {
            var formularios = new List<FormularioDTO>();

            // Recorrer todos los ensamblajes
            foreach (var assembly in assemblies)
            {
                // Obtener todos los tipos (clases) del ensamblaje
                var types = assembly.GetTypes();

                // Recorrer todos los tipos
                foreach (var type in types)
                {
                    // Verificar si el tipo es un Form
                    if (type.IsSubclassOf(typeof(Form)))
                    {
                        // Obtener el nombre del Form
                        if (type.Name.Contains('_'))
                        {
                            // Agregar el nombre del Form a la lista
                            formularios.Add(new FormularioDTO
                            {
                                Codigo = type.Name.Substring(1, 5),
                                Descripcion = type.Name.Substring(7, type.Name.Length - 7),
                                DescripcionCompleta = type.Name,
                                EstaSeleccionado = false,
                                EstaVigente = true,
                                ExisteBase = false
                            });
                        }
                    }
                }
            }

            return formularios;
        }
    }
}
