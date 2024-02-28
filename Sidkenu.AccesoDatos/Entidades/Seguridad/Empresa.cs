using Sidkenu.AccesoDatos.Entidades.Base;
using Sidkenu.AccesoDatos.Entidades.Core;

namespace Sidkenu.AccesoDatos.Entidades.Seguridad
{
    public class Empresa : EntidadBase
    {
        // Propiedades
        public Guid LocalidadId { get; set; }
        public Guid TipoResponsabilidadId { get; set; }
        public Guid IngresoBrutoId { get; set; }

        public int Codigo { get; set; }

        public string Abreviatura { get; set; }

        public string Descripcion { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Mail { get; set; }

        public string Referente { get; set; }

        public string Cuit { get; set; }

        public DateTime FechaInicioActividad { get; set; }

        public string NroIngresoBruto { get; set; }

        public byte[] Logo { get; set; }


        // Propiedades de Navegacion
        public virtual Localidad Localidad { get; set; }
        public virtual TipoResponsabilidad TipoResponsabilidad { get; set; }
        public virtual IngresoBruto IngresoBruto { get; set; }
        public virtual List<EmpresaPersona> EmpresasPersonas { get; set; }
        public virtual List<Grupo> Grupos { get; set; }
        public virtual List<Modulo> Modulos { get; set; }
        public virtual List<Deposito> Depositos { get; set; }
        public virtual List<Caja> Cajas { get; set; }
        public virtual List<TipoGasto> TipoGastos { get; set; }
        public virtual List<Gasto> Gastos { get; set; }
        public virtual List<Articulo> Articulos { get; set; }
        public virtual List<Familia> Familias { get; set; }
        public virtual List<Marca> Marcas { get; set; }
        public virtual List<UnidadMedida> UnidadMedidas { get; set; }
        public virtual List<Cliente> Clientes { get; set; }
        public virtual List<CondicionIva> CondicionIvas { get; set; }
        public virtual List<ListaPrecio> ListaPrecios { get; set; }
        public virtual List<Proveedor> Proveedores { get; set; }
        public virtual List<MotivoBaja> MotivoBajas { get; set; }
        public virtual List<Salon> Salones { get; set; }
        public virtual List<Contador> Contadores { get; set; }
        public virtual List<Variante> Variantes { get; set; }
        public virtual List<ConfiguracionCore> ConfiguracionCores { get; set; }
        public virtual List<MarcaListaPrecio> MarcaListaPrecios { get; set; }
        public virtual List<FamiliaListaPrecio> FamiliaListaPrecios { get; set; }
        public virtual List<OrdenFabricacion> OrdenFabricaciones { get; set; }
        public virtual List<CostoFabricacion> CostoFabricaciones { get; set; }
        public virtual List<ConfiguracionBalanza> ConfiguracionBalanzas { get; set; }
        public virtual List<Comprobante> Comprobantes { get; set;}
        public virtual List<MedioPago> MedioPagos { get; set; }
        public virtual List<PuestoTrabajo> Puestos { get; set; }
    }
}
