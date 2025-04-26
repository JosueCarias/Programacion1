using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.Versioning;
using System.Threading.Tasks;

namespace SegundoParcial
{
    public class csVenta
    {
        private string nombreArticulo;
        private double precioVenta;
        private string tipoDePago;
        private double dineroPresentado;

        public csVenta(string nombreArticulo,double precioVenta,string tipoDePago,double dineroPresentado){
            this.nombreArticulo=nombreArticulo;
            this.precioVenta=precioVenta;
            this.tipoDePago=tipoDePago;
            this.dineroPresentado=dineroPresentado;
        }

        public string NombreArticulo{
            get{
                return nombreArticulo;
            }
            set{
                nombreArticulo=value;
            }
        }
        public double PrecioVenta{
            get{
                return precioVenta;
            }
            set{
                precioVenta=value;
            }
        }
        public string TipoDePago{
            get{
                return tipoDePago;
            }
            set{
                tipoDePago=value;
            }
        }
        public double DineroPresentado{
            get{
                return dineroPresentado;
            }
            set{
                dineroPresentado=value;
            }
        }

        public double calcularIva(){
            return PrecioVenta*1.15;
        }
        public string retonarRespuesta(){
            if(TipoDePago=="Efectivo"){
                if(DineroPresentado>=calcularIva()){
                    return $"Su Vuelto Es De: {DineroPresentado-calcularIva()}";
                }else{
                    return $"El Dinero Presentado No Alcanza, La Venta No Se Puede Realizar";
                }
            }else{
                Console.WriteLine("Ingrese Los 16 Numero De La Tarjeta");
                Console.ReadLine();
                return $"Transacion realizada exitosamente";
            }
        }
    }
}