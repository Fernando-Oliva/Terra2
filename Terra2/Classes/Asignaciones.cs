using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Terra2.Classes
{
    public static class Asignaciones
    {
        public static string techAsing(int reino)
        {
            string tech;

            if (reino == 0 || reino == 3)
            {
                return tech = TechConstants.renacentista;
            }
            else if (reino == 1)
            {
               return tech = TechConstants.moderna;
            }
            else if (reino == 2 || reino == 4 || reino == 6 || reino == 7)
            {
                return tech = TechConstants.medieval;
            }
            else if (reino == 5 || reino == 14)
            {
                return tech = TechConstants.primitiva;
            }
            else if (reino == 8 || reino == 10 || reino == 13)
            {
                return tech = TechConstants.medieval;
            }
            else if (reino == 9 || reino == 12)
            {
                return tech = TechConstants.medieval;
            }
            else if (reino == 11)
            {
                return tech = TechConstants.medieval;
            }
            else
            {
                return tech = TechConstants.primitiva;
            }
        }

        public static string cultureAsing(int reino)
        {
            if (reino == 0 || reino == 3)
            {
                return CultureConstants.renacentista;
            }
            else if (reino == 1)
            {
                return CultureConstants.moderna;
            }
            else if (reino == 2 || reino == 4 || reino == 6 || reino == 7)
            {
                return CultureConstants.medieval;
            }
            else if (reino == 5 || reino == 14)
            {
                return  CultureConstants.tribal;
            }
            else if (reino == 8 || reino == 10 || reino == 13)
            {
                return CultureConstants.actual;
            }
            else if (reino == 9 || reino == 12)
            {
                return CultureConstants.tribal;
            }
            else if (reino == 11)
            {
                return CultureConstants.antigua;
            }
            else
            {
                return CultureConstants.antigua;
            }
        }

        public static void asignEspeciePriority(int especie, ComboBox a, ComboBox b, ComboBox c, ComboBox d)
        {
            if (especie == 0 || especie == 1 || especie == 4 || especie == 10 || especie == 19)
            {
                c.SelectedIndex = 0;
                a.Text = null;
                b.Text = null;
                d.Text = null;
            }
            else if (especie == 2 || especie == 13 || especie == 14 || especie == 18)
            {
                d.SelectedIndex = 0;
                a.Text = null;
                b.Text = null;
                c.Text = null;
            }
            else if (especie == 3 || especie == 7 || especie == 8 || especie == 9 || especie == 11 || especie == 16)
            {
                b.SelectedIndex = 0;
                a.Text = null;
                c.Text = null;
                d.Text = null;
            }
            else
            {
                a.SelectedIndex = 0;
                b.Text = null;
                c.Text = null;
                d.Text = null;
            }
        }

        public static void caracteristicasIni(int especie, TextBox tbCon, TextBox tbFri, TextBox tbImp, 
                                              TextBox tbVig, TextBox tbSen, TextBox tbPsi, TextBox tbCie, TextBox tbMot,
                                              TextBox tbPotencia, TextBox tbAguante, TextBox tbTempleE, TextBox tbTempleC,
                                              NumericUpDown nudEstancia, NumericUpDown nudCambio, Label ltamanio, Label lphi)
        {
            if (especie == 0)
            {
                tbCon.Text = "4";
                tbFri.Text = "4";
                tbImp.Text = "3";
                tbVig.Text = "3";
                tbSen.Text = "5";
                tbPsi.Text = "3";
                tbCie.Text = "2";
                tbMot.Text = "3";
                tbPotencia.Text = "2";
                tbAguante.Text = "2";
                tbTempleE.Text = "+1";
                tbTempleC.Text = "0";
                nudEstancia.Value = 6;
                nudCambio.Value = 4;
                ltamanio.Text = "Mediano";
                lphi.Text = "Guardianes";
                ltamanio.Visible = true;
                lphi.Visible = true;
            }
        }

        public static void elementoIni(TextBox tbTier, TextBox tbTini, TextBox tbIns, TextBox tbFue, TextBox tbAir,
                                       TextBox tbLu, TextBox tbCono, TextBox tbAg,
                                       TextBox tbCon, TextBox tbFri, TextBox tbImp, 
                                       TextBox tbVig, TextBox tbSen, TextBox tbPsi, TextBox tbCie, TextBox tbMot)
        {
            tbTier.Text = tbCon.Text;
            tbTini.Text = tbFri.Text;
            tbIns.Text = tbImp.Text;
            tbFue.Text = tbVig.Text;
            tbAir.Text = tbSen.Text;
            tbLu.Text = tbPsi.Text;
            tbCono.Text = tbCie.Text;
            tbAg.Text = tbMot.Text;
        }

        public static void elementoRecalculado(CheckBox cbHabilidad, TextBox tbElemento, TextBox tbAtributo)
        {
            Calculos calculos = new Calculos();

            if (cbHabilidad.Checked == true)
            {
                tbElemento.Text = Convert.ToString(calculos.calculoElemento(true, Convert.ToInt32(tbElemento.Text)));
            }
            else
            {
                tbElemento.Text = Convert.ToString(calculos.calculoElemento(false, Convert.ToInt32(tbElemento.Text)));
            }
        }

        public static void templePorHabilidad(TextBox tbHabilidadEstres, TextBox tbHabilidadCalma,TextBox tbHabilidadEstresTotal, 
                                              TextBox tbHabilidadCalmaTotal , TextBox tbEstres, TextBox tbCalma)
        {
            tbHabilidadEstres.Text = tbEstres.Text;
            tbHabilidadCalma.Text = tbCalma.Text;
            tbHabilidadEstresTotal.Text = tbHabilidadEstres.Text;
            tbHabilidadCalmaTotal.Text = tbHabilidadCalma.Text;
        }

        public static void bonosEstresCalma(CheckBox cbHabilidad, int temple, int caracteristica, TextBox tb)
        {
            Calculos calculos = new Calculos();

            if (cbHabilidad.Checked == true)
            {
                tb.Text = "+" + Convert.ToString(calculos.calculoHabilidadEC(true, temple, caracteristica));
            }
            else 
            {
                tb.Text = "+" + Convert.ToString(calculos.calculoHabilidadEC(false, temple, caracteristica));
            }
        }

        public static void verificadorAtributo(CheckBox cbHabilidad1Nivel6, CheckBox cbHabilidad2Nivel6, CheckBox cbHabilidad3Nivel6,
                                               TextBox tbAtributo, TextBox tbElemento)
        {
            Calculos calculos = new Calculos();

            if (cbHabilidad1Nivel6.Checked == true && cbHabilidad2Nivel6.Checked == true && cbHabilidad3Nivel6.Checked == true)
            {
                tbElemento.Text = Convert.ToString(calculos.subidaElementoPorAtributo(Convert.ToInt32(tbElemento.Text)));
                tbAtributo.Text = Convert.ToString(calculos.subidaAtributo(Convert.ToInt32(tbAtributo.Text)));
            }
            else if (cbHabilidad1Nivel6.Checked == false && cbHabilidad2Nivel6.Checked == true && cbHabilidad3Nivel6.Checked == true)
            {
                tbElemento.Text = Convert.ToString(calculos.bajadaElementoPorAtributo(Convert.ToInt32(tbElemento.Text)));
                tbAtributo.Text = Convert.ToString(calculos.bajadaAtributo(Convert.ToInt32(tbAtributo.Text)));
            }
        }

        public static void igualadorTotalesTemple(CheckBox cb1,CheckBox cb2, CheckBox cb3, TextBox tb1E, TextBox tb1C, 
                                                  TextBox tb2E, TextBox tb2C, TextBox tb3E, TextBox tb3C)
        {
            if (cb1.Checked == true && cb2.Checked == true && cb3.Checked == true)
            {
                tb2E.Text = tb1E.Text;
                tb2C.Text = tb1C.Text;

                tb3E.Text = tb1E.Text;
                tb3C.Text = tb1C.Text;
            }
            else if (cb1.Checked == false && cb2.Checked == true && cb3.Checked == true)
            {
                tb2E.Text = Convert.ToString(Convert.ToInt32(tb2E.Text) - 1);
                tb2C.Text = Convert.ToString(Convert.ToInt32(tb2C.Text) - 1);

                tb3E.Text = Convert.ToString(Convert.ToInt32(tb3E.Text) - 1);
                tb3C.Text = Convert.ToString(Convert.ToInt32(tb3C.Text) - 1);
            }
        }

        public static void totalesEstresCalma(CheckBox cbHabilidad, TextBox bonoEstresCalmaHabilidad, TextBox totalEstresCalmaHabilidad, TextBox atributo, int atributoAnterior , int nivelHabilidad)
        {
            if (cbHabilidad.Checked == true)
            {
                if (bonoEstresCalmaHabilidad.Text == "0")
                {
                    totalEstresCalmaHabilidad.Text = Convert.ToString(Convert.ToInt32(atributo.Text) + 0 + nivelHabilidad);
                }
                else if (bonoEstresCalmaHabilidad.Text == "+1")
                {
                    totalEstresCalmaHabilidad.Text = Convert.ToString(Convert.ToInt32(atributo.Text) + 2 + nivelHabilidad); //el primer 2 es por el temple, se aplica el siguiente rango
                }
            }
            else
            {
                if (Convert.ToInt32(atributo.Text) == atributoAnterior)
                {
                    totalEstresCalmaHabilidad.Text = Convert.ToString(Convert.ToInt32(totalEstresCalmaHabilidad.Text) - 2);
                }
                else
                {
                    int valor = atributoAnterior - Convert.ToInt32(atributo.Text);

                    totalEstresCalmaHabilidad.Text = Convert.ToString(Convert.ToInt32(totalEstresCalmaHabilidad.Text) - 2 - valor);
                }
            }
        }
        public static void totalesEstresCalmaEsp(CheckBox cbHabilidad, TextBox bonoEstresCalmaHabilidad, TextBox totalEstresCalmaHabilidad, TextBox atributo, int atributoAnterior, int nivelHabilidad)
        {
            if (cbHabilidad.Checked == true)
            {
                if (bonoEstresCalmaHabilidad.Text == "0")
                {
                    totalEstresCalmaHabilidad.Text = Convert.ToString(Convert.ToInt32(atributo.Text) + 0 + nivelHabilidad);
                }
                else if (bonoEstresCalmaHabilidad.Text == "+1")
                {
                    totalEstresCalmaHabilidad.Text = Convert.ToString(Convert.ToInt32(atributo.Text) + 4 + nivelHabilidad); //el primer 2 es por el temple, se aplica el siguiente rango
                }
            }
            else
            {
                if (Convert.ToInt32(atributo.Text) == atributoAnterior)
                {
                    totalEstresCalmaHabilidad.Text = Convert.ToString(Convert.ToInt32(totalEstresCalmaHabilidad.Text) - 4);
                }
                else
                {
                    int valor = atributoAnterior - Convert.ToInt32(atributo.Text);

                    totalEstresCalmaHabilidad.Text = Convert.ToString(Convert.ToInt32(totalEstresCalmaHabilidad.Text) - 4 - valor);
                }
            }
        }
    }
}
