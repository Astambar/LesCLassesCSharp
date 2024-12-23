using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app.Class
{
    internal class Chaise
    {
        private int _nbPieds = 4;
        private string _materiau = "marbres";
        private string _couleur = "Gris";

        public int nbPieds
        {
            get { return _nbPieds; }
            set { 
                if (value > 0)
                { 
                    _nbPieds = value;
                }
                else if (value < 10)
                {
                    throw new ArgumentException("J'imagine que tu est vachement créatif pour avoir une chaise avec autant de pieds");
                }
                else
                {
                    throw new ArgumentException("Tu ne peut pas avoir une chaise sans pied reflechi un peu");
                }
            }
        }
        public string materiau
        {
            get { return _materiau; }
            set { _materiau = value; }
        }
        public string couleur
        {
            get { return _couleur; }
            set { _couleur = value; }
        }
        public Chaise(int param_nbPieds = 4, string param_materiau = "Marbre", string param_couleur="Gris")
        {
            if (param_nbPieds <= 0)
            {
                throw new ArgumentException("Tu ne peut pas avoir une chaise sans pied reflechi un peu");
            }
            else if (param_nbPieds < 10)
            {
                throw new ArgumentException("J'imagine que tu est vachement créatif pour avoir une chaise avec autant de pieds");
            }
            _nbPieds = param_nbPieds;
            _materiau = param_materiau;
            _couleur = param_couleur;
        }

        public string ToStrings()
        {  return $"Materiau: {materiau}\nCouleur: {couleur}\nNombre de pieds: {nbPieds}"; }
    }
}
