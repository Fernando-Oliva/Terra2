using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Terra2.Classes;

namespace Terra2
{
    public partial class Form1 : Form
    {
        Classes.Calculos calculos = new Calculos();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void cbKingdom_SelectedIndexChanged(object sender, EventArgs e)
        {   
            int reino = cbKingdom.SelectedIndex;

            tbTech.Text = Asignaciones.techAsing(reino);
            tbCulture.Text = Asignaciones.cultureAsing(reino);
        }

        private void cbSpecies_SelectedIndexChanged(object sender, EventArgs e)
        {
            Asignaciones.asignEspeciePriority(cbSpecies.SelectedIndex, cbPriorityA, cbPriorityB, cbPriorityC, cbPriorityD);
            Asignaciones.caracteristicasIni(cbSpecies.SelectedIndex, tbConst, tbFrialdad, tbImpulso, tbVigor, tbSentidos, tbPsique, tbCiencia, tbMotricidad,
                                            tbPotencia, tbAguante, tbTempleE, tbTempleC, nudStance, nudChange, lTamano, lPhi);
            Asignaciones.elementoIni(tbTierra, tbTinieblas, tbInstinto, tbFuego, tbAire, tbLuz, tbConocimiento, tbAgua, 
                                     tbConst, tbFrialdad, tbImpulso, tbVigor, tbSentidos, tbPsique, tbCiencia, tbMotricidad);
            #region TIERRA
            Asignaciones.templePorHabilidad(tbFatigaBE, tbFatigaBC,tbFatigaTE, tbFatigaTC, tbTempleE, tbTempleC);
            Asignaciones.templePorHabilidad(tbSupervivBE, tbSupervivBC, tbSupervivTE, tbSupervivTC, tbTempleE, tbTempleC);
            Asignaciones.templePorHabilidad(tbRudezaBE, tbRudezaBC, tbRudezaTE, tbRudezaTC, tbTempleE, tbTempleC);
            Asignaciones.templePorHabilidad(tbResistBE, tbResistBC, tbResistTE, tbResistTC, tbTempleE, tbTempleC);
            #endregion

            #region AIRE
            Asignaciones.templePorHabilidad(tbObservarBE, tbObservarBC, tbObservarTE, tbObservarTC, tbTempleE, tbTempleC);
            Asignaciones.templePorHabilidad(tbEscucharBE, tbEscucharBC, tbEscucharTE, tbEscucharTC, tbTempleE, tbTempleC);
            Asignaciones.templePorHabilidad(tbEmpatiaBE, tbEmpatiaBC, tbEmpatiaTE, tbEmpatiaTC, tbTempleE, tbTempleC);
            Asignaciones.templePorHabilidad(tbOlfatoBE, tbOlfatoBC, tbOlfatoTE, tbOlfatoTC, tbTempleE, tbTempleC);
            #endregion

            #region LUZ
            Asignaciones.templePorHabilidad(tbSubterfBE, tbSubterfBC, tbSubterfTE, tbSubterfTC, tbTempleE, tbTempleC);
            Asignaciones.templePorHabilidad(tbCarismaBE, tbCarismaBC, tbCarismaTE, tbCarismaTC, tbTempleE, tbTempleC);
            Asignaciones.templePorHabilidad(tbLiderazBE, tbLiderazBC, tbLiderazTE, tbLiderazTC, tbTempleE, tbTempleC);
            Asignaciones.templePorHabilidad(tbBastionBE, tbBastionBC, tbBastionTE, tbBastionTC, tbTempleE, tbTempleC);
            #endregion

            #region INSTINTO
            Asignaciones.templePorHabilidad(tbRastrearBE, tbRastrearBC, tbRastrearTE, tbRastrearTC, tbTempleE, tbTempleC);
            Asignaciones.templePorHabilidad(tbOrientaBE, tbOrientaBC, tbOrientaTE, tbOrientaTC, tbTempleE, tbTempleC);
            Asignaciones.templePorHabilidad(tbFerocBE, tbFerocBC, tbFerocTE, tbFerocTC, tbTempleE, tbTempleC);
            Asignaciones.templePorHabilidad(tbPredadBE, tbPredadBC, tbPredadTE, tbPredadTC, tbTempleE, tbTempleC);
            #endregion

            #region CONOCIMIENTO
            Asignaciones.templePorHabilidad(tbSaberBE, tbSaberBC, tbSaberTE, tbSaberTC, tbTempleE, tbTempleC);
            Asignaciones.templePorHabilidad(tbCulturaBE, tbCulturaBC, tbCulturaTE, tbCulturaTC, tbTempleE, tbTempleC);
            Asignaciones.templePorHabilidad(tbTecnicaBE, tbTecnicaBC, tbTecnicaTE, tbTecnicaTC, tbTempleE, tbTempleC);
            Asignaciones.templePorHabilidad(tbMisticBE, tbMisticBC, tbMisticTE, tbMisticTC, tbTempleE, tbTempleC);
            #endregion

            #region FUEGO
            Asignaciones.templePorHabilidad(tbProezaBE, tbProezaBC, tbProezaTE, tbProezaTC, tbTempleE, tbTempleC);
            Asignaciones.templePorHabilidad(tbPeleaBE, tbPeleaBC, tbPeleaTE, tbPeleaTC, tbTempleE, tbTempleC);
            Asignaciones.templePorHabilidad(tbPrecisionBE, tbPrecisionBC, tbPrecisionTE, tbPrecisionTC, tbTempleE, tbTempleC);
            Asignaciones.templePorHabilidad(tbFuriaBE, tbFuriaBC, tbFuriaTE, tbFuriaTC, tbTempleE, tbTempleC);
            #endregion

        }

        

        private void lPhi_MouseHover(object sender, EventArgs e)
        {
            tbPhi.Text = "Guardianes. Pocas cosas se escapan de la percepción de un cánido. Suma 2 al Temple de todas las Habilidades" +
                         " de la Caracteristica Sentidos.";
            tbPhi.Visible = true;
        }

        private void lPhi_MouseLeave(object sender, EventArgs e)
        {
            tbPhi.Visible = false;
            tbPhi.Text = "";
        }

        #region TIERRA
        private void cbFatiga2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);

            Asignaciones.elementoRecalculado(cbFatiga2, tbTierra, tbConst);
            Asignaciones.totalesEstresCalma(cbFatiga2, tbFatigaBE, tbFatigaTE, tbConst, atrib, 2);
            Asignaciones.totalesEstresCalma(cbFatiga2, tbFatigaBC, tbFatigaTC, tbConst, atrib, 2);
        }

        private void cbFatiga4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);

            Asignaciones.elementoRecalculado(cbFatiga4, tbTierra, tbConst);
            Asignaciones.totalesEstresCalma(cbFatiga4, tbFatigaBE, tbFatigaTE, tbConst, atrib, 4);
            Asignaciones.totalesEstresCalma(cbFatiga4, tbFatigaBC, tbFatigaTC, tbConst, atrib, 4);
        }

        private void cbFatiga6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbFatiga6, cbSuperv6, cbRudeza6, tbConst, tbTierra);

            Asignaciones.elementoRecalculado(cbFatiga6, tbTierra, tbConst);
            Asignaciones.totalesEstresCalma(cbFatiga6, tbFatigaBE, tbFatigaTE, tbConst, atrib, 6);
            Asignaciones.totalesEstresCalma(cbFatiga6, tbFatigaBC, tbFatigaTC, tbConst, atrib, 6);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbFatiga6, cbSuperv6, cbRudeza6, tbFatigaTE, tbFatigaTC, tbSupervivTE, tbSupervivTC, tbRudezaTE, tbRudezaTC);
        }

        private void cbFatiga8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);

            Asignaciones.elementoRecalculado(cbFatiga8, tbTierra, tbConst);
            Asignaciones.totalesEstresCalma(cbFatiga8, tbFatigaBE, tbFatigaTE, tbConst, atrib, 8);
            Asignaciones.totalesEstresCalma(cbFatiga8, tbFatigaBC, tbFatigaTC, tbConst, atrib, 8);
        }

        private void cbFatiga10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);

            Asignaciones.elementoRecalculado(cbFatiga10, tbTierra, tbConst);
            Asignaciones.totalesEstresCalma(cbFatiga10, tbFatigaBE, tbFatigaTE, tbConst, atrib, 10);
            Asignaciones.totalesEstresCalma(cbFatiga10, tbFatigaBC, tbFatigaTC, tbConst, atrib, 10);         
        }

        private void cbFatiga12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);

            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbFatiga12, cbSuperv12, cbRudeza12, tbConst, tbTierra);

            Asignaciones.elementoRecalculado(cbFatiga12, tbTierra, tbConst);
            Asignaciones.totalesEstresCalma(cbFatiga12, tbFatigaBE, tbFatigaTE, tbConst, atrib, 12);
            Asignaciones.totalesEstresCalma(cbFatiga12, tbFatigaBC, tbFatigaTC, tbConst, atrib, 12);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbFatiga12, cbSuperv12, cbRudeza12, tbFatigaTE, tbFatigaTC, tbSupervivTE, tbSupervivTC, tbRudezaTE, tbRudezaTC);
        }

        private void cbSuperv2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);

            Asignaciones.elementoRecalculado(cbSuperv2, tbTierra, tbConst);
            Asignaciones.totalesEstresCalma(cbSuperv2, tbSupervivBE, tbSupervivTE, tbConst, atrib, 2);
            Asignaciones.totalesEstresCalma(cbSuperv2, tbSupervivBC, tbSupervivTC, tbConst, atrib, 2);
        }

        private void cbSuperv4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);

            Asignaciones.elementoRecalculado(cbSuperv4, tbTierra, tbConst);
            Asignaciones.totalesEstresCalma(cbSuperv4, tbSupervivBE, tbSupervivTE, tbConst, atrib, 4);
            Asignaciones.totalesEstresCalma(cbSuperv4, tbSupervivBC, tbSupervivTC, tbConst, atrib, 4);
        }

        private void cbSuperv6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbSuperv6, cbFatiga6, cbRudeza6, tbConst, tbTierra);

            Asignaciones.elementoRecalculado(cbSuperv6, tbTierra, tbConst);
            Asignaciones.totalesEstresCalma(cbSuperv6, tbSupervivBE, tbSupervivTE, tbConst, atrib, 6);
            Asignaciones.totalesEstresCalma(cbSuperv6, tbSupervivBC, tbSupervivTC, tbConst, atrib, 6);

            //llamada a igualador
            Asignaciones.igualadorTotalesTemple(cbSuperv6, cbFatiga6, cbRudeza6, tbSupervivTE, tbSupervivTC, tbFatigaTE, tbFatigaTC, tbRudezaTE, tbRudezaTC);
        }

        private void cbSuperv8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);

            Asignaciones.elementoRecalculado(cbSuperv8, tbTierra, tbConst);
            Asignaciones.totalesEstresCalma(cbSuperv8, tbSupervivBE, tbSupervivTE, tbConst, atrib, 8);
            Asignaciones.totalesEstresCalma(cbSuperv8, tbSupervivBC, tbSupervivTC, tbConst, atrib, 8);
        }

        private void cbSuperv10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);

            Asignaciones.elementoRecalculado(cbSuperv10, tbTierra, tbConst);
            Asignaciones.totalesEstresCalma(cbSuperv10, tbSupervivBE, tbSupervivTE, tbConst, atrib, 10);
            Asignaciones.totalesEstresCalma(cbSuperv10, tbSupervivBC, tbSupervivTC, tbConst, atrib, 10);
        }

        private void cbSuperv12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbFatiga12, cbSuperv12, cbRudeza12, tbConst, tbTierra);

            Asignaciones.elementoRecalculado(cbSuperv12, tbTierra, tbConst);
            Asignaciones.totalesEstresCalma(cbSuperv12, tbSupervivBE, tbSupervivTE, tbConst, atrib, 12);
            Asignaciones.totalesEstresCalma(cbSuperv12, tbSupervivBC, tbSupervivTC, tbConst, atrib, 12);

            //llamada a igualador
            Asignaciones.igualadorTotalesTemple(cbSuperv12, cbFatiga12, cbRudeza12, tbSupervivTE, tbSupervivTC, tbFatigaTE, tbFatigaTC, tbRudezaTE, tbRudezaTC);
        }

        private void cbRudeza2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);

            Asignaciones.elementoRecalculado(cbRudeza2, tbTierra, tbConst);
            Asignaciones.totalesEstresCalma(cbRudeza2, tbRudezaBE, tbRudezaTE, tbConst, atrib, 2);
            Asignaciones.totalesEstresCalma(cbRudeza2, tbRudezaBC, tbRudezaTC, tbConst, atrib, 2);
        }

        private void cbRudeza4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text); 

            Asignaciones.elementoRecalculado(cbRudeza4, tbTierra, tbConst);
            Asignaciones.totalesEstresCalma(cbRudeza4, tbRudezaBE, tbRudezaTE, tbConst, atrib, 4);
            Asignaciones.totalesEstresCalma(cbRudeza4, tbRudezaBC, tbRudezaTC, tbConst, atrib, 4);
        }

        private void cbRudeza6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbRudeza6, cbFatiga6, cbSuperv6, tbConst, tbTierra);

            Asignaciones.elementoRecalculado(cbRudeza6, tbTierra, tbConst);
            Asignaciones.totalesEstresCalma(cbRudeza6, tbRudezaBE, tbRudezaTE, tbConst, atrib, 6);
            Asignaciones.totalesEstresCalma(cbRudeza6, tbRudezaBC, tbRudezaTC, tbConst, atrib, 6);

            //llamada a igualador
            Asignaciones.igualadorTotalesTemple(cbRudeza6, cbFatiga6, cbSuperv6, tbRudezaTE, tbRudezaTC, tbFatigaTE, tbFatigaTC, tbSupervivTE, tbSupervivTC);
        }

        private void cbRudeza8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);
            Asignaciones.elementoRecalculado(cbRudeza8, tbTierra, tbConst);
            Asignaciones.totalesEstresCalma(cbRudeza8, tbRudezaBE, tbRudezaTE, tbConst, atrib, 8);
            Asignaciones.totalesEstresCalma(cbRudeza8, tbRudezaBC, tbRudezaTC, tbConst, atrib, 8);
        }

        private void cbRudeza10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);

            Asignaciones.elementoRecalculado(cbRudeza10, tbTierra, tbConst);
            Asignaciones.totalesEstresCalma(cbRudeza10, tbRudezaBE, tbRudezaTE, tbConst, atrib, 10);
            Asignaciones.totalesEstresCalma(cbRudeza10, tbRudezaBC, tbRudezaTC, tbConst, atrib, 10);
        }

        private void cbRudeza12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbFatiga12, cbSuperv12, cbRudeza12, tbConst, tbTierra);

            Asignaciones.elementoRecalculado(cbRudeza12, tbTierra, tbConst);
            Asignaciones.totalesEstresCalma(cbRudeza12, tbRudezaBE, tbRudezaTE, tbConst, atrib, 12);
            Asignaciones.totalesEstresCalma(cbRudeza12, tbRudezaBC, tbRudezaTC, tbConst, atrib, 12);

            //llamada a igualador
            Asignaciones.igualadorTotalesTemple(cbRudeza12, cbFatiga12, cbSuperv12, tbRudezaTE, tbRudezaTC, tbFatigaTE, tbFatigaTC, tbSupervivTE, tbSupervivTC);
        }

        private void cbResist2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);

            Asignaciones.totalesEstresCalma(cbResist2, tbResistBE, tbResistTE, tbConst, atrib, 2);
            Asignaciones.totalesEstresCalma(cbResist2, tbResistBC, tbResistTC, tbConst, atrib, 2);
        }

        private void cbResist4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);

            Asignaciones.totalesEstresCalma(cbResist4, tbResistBE, tbResistTE, tbConst, atrib, 4);
            Asignaciones.totalesEstresCalma(cbResist4, tbResistBC, tbResistTC, tbConst, atrib, 4);
        }

        private void cbResist6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);

            Asignaciones.totalesEstresCalma(cbResist6, tbResistBE, tbResistTE, tbConst, atrib, 6);
            Asignaciones.totalesEstresCalma(cbResist6, tbResistBC, tbResistTC, tbConst, atrib, 6);
        }

        private void cbResist8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);

            Asignaciones.totalesEstresCalma(cbResist8, tbResistBE, tbResistTE, tbConst, atrib, 8);
            Asignaciones.totalesEstresCalma(cbResist8, tbResistBC, tbResistTC, tbConst, atrib, 8);
        }

        private void cbResist10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);

            Asignaciones.totalesEstresCalma(cbResist10, tbResistBE, tbResistTE, tbConst, atrib, 10);
            Asignaciones.totalesEstresCalma(cbResist10, tbResistBC, tbResistTC, tbConst, atrib, 10);
        }

        private void cbResist12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbConst.Text);

            Asignaciones.totalesEstresCalma(cbResist12, tbResistBE, tbResistTE, tbConst, atrib, 12);
            Asignaciones.totalesEstresCalma(cbResist12, tbResistBC, tbResistTC, tbConst, atrib, 12);
        }
        #endregion

        #region AIRE
        private void cbObserv2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);

            Asignaciones.elementoRecalculado(cbObserv2, tbAire, tbSentidos);
            Asignaciones.totalesEstresCalma(cbObserv2, tbObservarBE, tbObservarTE, tbSentidos, atrib, 2);
            Asignaciones.totalesEstresCalma(cbObserv2, tbObservarBC, tbObservarTC, tbSentidos, atrib, 2);
        }

        private void cbObserv4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);

            Asignaciones.elementoRecalculado(cbObserv4, tbAire, tbSentidos);
            Asignaciones.totalesEstresCalma(cbObserv4, tbObservarBE, tbObservarTE, tbSentidos, atrib, 4);
            Asignaciones.totalesEstresCalma(cbObserv4, tbObservarBC, tbObservarTC, tbSentidos, atrib, 4);
        }

        private void cbObserv6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbObserv6, cbEscuchar6, cbEmpatia6, tbSentidos, tbAire);

            Asignaciones.elementoRecalculado(cbObserv6, tbAire, tbSentidos);
            Asignaciones.totalesEstresCalma(cbObserv6, tbObservarBE, tbObservarTE, tbSentidos, atrib, 6);
            Asignaciones.totalesEstresCalma(cbObserv6, tbObservarBC, tbObservarTC, tbSentidos, atrib, 6);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbObserv6, cbEscuchar6, cbEmpatia6, tbObservarTE, tbObservarTC, tbEscucharTE, tbEscucharTC, tbEmpatiaTE, tbEmpatiaTC);
        }

        private void cbObserv8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);

            Asignaciones.elementoRecalculado(cbObserv8, tbAire, tbSentidos);
            Asignaciones.totalesEstresCalma(cbObserv8, tbObservarBE, tbObservarTE, tbSentidos, atrib, 8);
            Asignaciones.totalesEstresCalma(cbObserv8, tbObservarBC, tbObservarTC, tbSentidos, atrib, 8);
        }

        private void cbObserv10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);

            Asignaciones.elementoRecalculado(cbObserv10, tbAire, tbSentidos);
            Asignaciones.totalesEstresCalma(cbObserv10, tbObservarBE, tbObservarTE, tbSentidos, atrib, 10);
            Asignaciones.totalesEstresCalma(cbObserv10, tbObservarBC, tbObservarTC, tbSentidos, atrib, 10);
        }

        private void cbObserv12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbObserv12, cbEscuchar12, cbEmpatia12, tbSentidos, tbAire);

            Asignaciones.elementoRecalculado(cbObserv12, tbAire, tbSentidos);
            Asignaciones.totalesEstresCalma(cbObserv12, tbObservarBE, tbObservarTE, tbSentidos, atrib, 12);
            Asignaciones.totalesEstresCalma(cbObserv12, tbObservarBC, tbObservarTC, tbSentidos, atrib, 12);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbObserv12, cbEscuchar12, cbEmpatia12, tbObservarTE, tbObservarTC, tbEscucharTE, tbEscucharTC, tbEmpatiaTE, tbEmpatiaTC);
        }

        private void cbEscuchar2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);

            Asignaciones.elementoRecalculado(cbEscuchar2, tbAire, tbSentidos);
            Asignaciones.totalesEstresCalma(cbEscuchar2, tbEscucharBE, tbEscucharTE, tbSentidos, atrib, 2);
            Asignaciones.totalesEstresCalma(cbEscuchar2, tbEscucharBC, tbEscucharTC, tbSentidos, atrib, 2);
        }

        private void cbEscuchar4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);

            Asignaciones.elementoRecalculado(cbEscuchar4, tbAire, tbSentidos);
            Asignaciones.totalesEstresCalma(cbEscuchar4, tbEscucharBE, tbEscucharTE, tbSentidos, atrib, 4);
            Asignaciones.totalesEstresCalma(cbEscuchar4, tbEscucharBC, tbEscucharTC, tbSentidos, atrib, 4);
        }

        private void cbEscuchar6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbEscuchar6, cbObserv6, cbEmpatia6, tbSentidos, tbAire);

            Asignaciones.elementoRecalculado(cbEscuchar6, tbAire, tbSentidos);
            Asignaciones.totalesEstresCalma(cbEscuchar6, tbEscucharBE, tbEscucharTE, tbSentidos, atrib, 6);
            Asignaciones.totalesEstresCalma(cbEscuchar6, tbEscucharBC, tbEscucharTC, tbSentidos, atrib, 6);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbEscuchar6, cbObserv6, cbEmpatia6, tbEscucharTE, tbEscucharTC, tbObservarTE, tbObservarTC, tbEmpatiaTE, tbEmpatiaTC);
        }

        private void cbEscuchar8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);

            Asignaciones.elementoRecalculado(cbEscuchar8, tbAire, tbSentidos);
            Asignaciones.totalesEstresCalma(cbEscuchar8, tbEscucharBE, tbEscucharTE, tbSentidos, atrib, 8);
            Asignaciones.totalesEstresCalma(cbEscuchar8, tbEscucharBC, tbEscucharTC, tbSentidos, atrib, 8);
        }

        private void cbEscuchar10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);

            Asignaciones.elementoRecalculado(cbEscuchar10, tbAire, tbSentidos);
            Asignaciones.totalesEstresCalma(cbEscuchar10, tbEscucharBE, tbEscucharTE, tbSentidos, atrib, 10);
            Asignaciones.totalesEstresCalma(cbEscuchar10, tbEscucharBC, tbEscucharTC, tbSentidos, atrib, 10);
        }

        private void cbEscuchar12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbEscuchar12, cbObserv12, cbEmpatia12, tbSentidos, tbAire);

            Asignaciones.elementoRecalculado(cbEscuchar12, tbAire, tbSentidos);
            Asignaciones.totalesEstresCalma(cbEscuchar12, tbEscucharBE, tbEscucharTE, tbSentidos, atrib, 12);
            Asignaciones.totalesEstresCalma(cbEscuchar12, tbEscucharBC, tbEscucharTC, tbSentidos, atrib, 12);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbEscuchar12, cbObserv12, cbEmpatia12, tbEscucharTE, tbEscucharTC, tbObservarTE, tbObservarTC, tbEmpatiaTE, tbEmpatiaTC);
        }

        private void cbEmpatia2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);

            Asignaciones.elementoRecalculado(cbEmpatia2, tbAire, tbSentidos);
            Asignaciones.totalesEstresCalma(cbEmpatia2, tbEmpatiaBE, tbEmpatiaTE, tbSentidos, atrib, 2);
            Asignaciones.totalesEstresCalma(cbEmpatia2, tbEmpatiaBC, tbEmpatiaTC, tbSentidos, atrib, 2);
        }

        private void cbEmpatia4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);

            Asignaciones.elementoRecalculado(cbEmpatia4, tbAire, tbSentidos);
            Asignaciones.totalesEstresCalma(cbEmpatia4, tbEmpatiaBE, tbEmpatiaTE, tbSentidos, atrib, 4);
            Asignaciones.totalesEstresCalma(cbEmpatia4, tbEmpatiaBC, tbEmpatiaTC, tbSentidos, atrib, 4);
        }

        private void cbEmpatia6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbEmpatia6, cbObserv6, cbEscuchar6, tbSentidos, tbAire);

            Asignaciones.elementoRecalculado(cbEmpatia6, tbAire, tbSentidos);
            Asignaciones.totalesEstresCalma(cbEmpatia6, tbEmpatiaBE, tbEmpatiaTE, tbSentidos, atrib, 6);
            Asignaciones.totalesEstresCalma(cbEmpatia6, tbEmpatiaBC, tbEmpatiaTC, tbSentidos, atrib, 6);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbEmpatia6, cbEscuchar6, cbObserv6, tbEmpatiaTE, tbEmpatiaTC, tbObservarTE, tbObservarTC, tbEscucharTE, tbEscucharTC);
        }

        private void cbEmpatia8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);

            Asignaciones.elementoRecalculado(cbEmpatia8, tbAire, tbSentidos);
            Asignaciones.totalesEstresCalma(cbEmpatia8, tbEmpatiaBE, tbEmpatiaTE, tbSentidos, atrib, 8);
            Asignaciones.totalesEstresCalma(cbEmpatia8, tbEmpatiaBC, tbEmpatiaTC, tbSentidos, atrib, 8);
        }

        private void cbEmpatia10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);

            Asignaciones.elementoRecalculado(cbEmpatia10, tbAire, tbSentidos);
            Asignaciones.totalesEstresCalma(cbEmpatia10, tbEmpatiaBE, tbEmpatiaTE, tbSentidos, atrib, 10);
            Asignaciones.totalesEstresCalma(cbEmpatia10, tbEmpatiaBC, tbEmpatiaTC, tbSentidos, atrib, 10);
        }

        private void cbEmpatia12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbEmpatia12, cbObserv12, cbEscuchar12, tbSentidos, tbAire);

            Asignaciones.elementoRecalculado(cbEmpatia12, tbAire, tbSentidos);
            Asignaciones.totalesEstresCalma(cbEmpatia12, tbEmpatiaBE, tbEmpatiaTE, tbSentidos, atrib, 12);
            Asignaciones.totalesEstresCalma(cbEmpatia12, tbEmpatiaBC, tbEmpatiaTC, tbSentidos, atrib, 12);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbEmpatia12, cbEscuchar12, cbObserv12, tbEmpatiaTE, tbEmpatiaTC, tbObservarTE, tbObservarTC, tbEscucharTE, tbEscucharTC);
        }

        private void cbOlfato2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);

            Asignaciones.totalesEstresCalma(cbOlfato2, tbOlfatoBE, tbOlfatoTE, tbSentidos, atrib, 2);
            Asignaciones.totalesEstresCalma(cbOlfato2, tbOlfatoBC, tbOlfatoTC, tbSentidos, atrib, 2);
        }

        private void cbOlfato4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);

            Asignaciones.totalesEstresCalma(cbOlfato4, tbOlfatoBE, tbOlfatoTE, tbSentidos, atrib, 4);
            Asignaciones.totalesEstresCalma(cbOlfato4, tbOlfatoBC, tbOlfatoTC, tbSentidos, atrib, 4);
        }

        private void cbOlfato6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);

            Asignaciones.totalesEstresCalma(cbOlfato6, tbOlfatoBE, tbOlfatoTE, tbSentidos, atrib, 6);
            Asignaciones.totalesEstresCalma(cbOlfato6, tbOlfatoBC, tbOlfatoTC, tbSentidos, atrib, 6);
        }

        private void cbOlfato8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);

            Asignaciones.totalesEstresCalma(cbOlfato8, tbOlfatoBE, tbOlfatoTE, tbSentidos, atrib, 8);
            Asignaciones.totalesEstresCalma(cbOlfato8, tbOlfatoBC, tbOlfatoTC, tbSentidos, atrib, 8);
        }

        private void cbOlfato10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);

            Asignaciones.totalesEstresCalma(cbOlfato10, tbOlfatoBE, tbOlfatoTE, tbSentidos, atrib, 10);
            Asignaciones.totalesEstresCalma(cbOlfato10, tbOlfatoBC, tbOlfatoTC, tbSentidos, atrib, 10);
        }

        private void cbOlfato12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbSentidos.Text);

            Asignaciones.totalesEstresCalma(cbOlfato12, tbOlfatoBE, tbOlfatoTE, tbSentidos, atrib, 12);
            Asignaciones.totalesEstresCalma(cbOlfato12, tbOlfatoBC, tbOlfatoTC, tbSentidos, atrib, 12);
        }
        #endregion

        #region PSIQUE
        private void cbSubterf2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);

            Asignaciones.elementoRecalculado(cbSubterf2, tbLuz, tbPsique);
            Asignaciones.totalesEstresCalma(cbSubterf2, tbSubterfBE, tbSubterfTE, tbPsique, atrib, 2);
            Asignaciones.totalesEstresCalma(cbSubterf2, tbSubterfBC, tbSubterfTC, tbPsique, atrib, 2);
        }

        private void cbSubterf4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);

            Asignaciones.elementoRecalculado(cbSubterf4, tbLuz, tbPsique);
            Asignaciones.totalesEstresCalma(cbSubterf4, tbSubterfBE, tbSubterfTE, tbPsique, atrib, 4);
            Asignaciones.totalesEstresCalma(cbSubterf4, tbSubterfBC, tbSubterfTC, tbPsique, atrib, 4);
        }

        private void cbSubterf6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbSubterf6, cbCarisma6, cbLideraz6, tbPsique, tbLuz);

            Asignaciones.elementoRecalculado(cbSubterf6, tbLuz, tbPsique);
            Asignaciones.totalesEstresCalma(cbSubterf6, tbSubterfBE, tbSubterfTE, tbPsique, atrib, 6);
            Asignaciones.totalesEstresCalma(cbSubterf6, tbSubterfBC, tbSubterfTC, tbPsique, atrib, 6);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbSubterf6, cbCarisma6, cbLideraz6, tbSubterfTE, tbSubterfTC, tbCarismaTE, tbCarismaTC, tbLiderazTE, tbLiderazTC);
        }

        private void cbSubterf8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);

            Asignaciones.elementoRecalculado(cbSubterf8, tbLuz, tbPsique);
            Asignaciones.totalesEstresCalma(cbSubterf8, tbSubterfBE, tbSubterfTE, tbPsique, atrib, 8);
            Asignaciones.totalesEstresCalma(cbSubterf8, tbSubterfBC, tbSubterfTC, tbPsique, atrib, 8);
        }

        private void cbSubterf10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);

            Asignaciones.elementoRecalculado(cbSubterf10, tbLuz, tbPsique);
            Asignaciones.totalesEstresCalma(cbSubterf10, tbSubterfBE, tbSubterfTE, tbPsique, atrib, 10);
            Asignaciones.totalesEstresCalma(cbSubterf10, tbSubterfBC, tbSubterfTC, tbPsique, atrib, 10);
        }

        private void cbSubterf12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbSubterf12, cbCarisma12, cbLideraz12, tbPsique, tbLuz);

            Asignaciones.elementoRecalculado(cbSubterf12, tbLuz, tbPsique);
            Asignaciones.totalesEstresCalma(cbSubterf12, tbSubterfBE, tbSubterfTE, tbPsique, atrib, 12);
            Asignaciones.totalesEstresCalma(cbSubterf12, tbSubterfBC, tbSubterfTC, tbPsique, atrib, 12);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbSubterf12, cbCarisma12, cbLideraz12, tbSubterfTE, tbSubterfTC, tbCarismaTE, tbCarismaTC, tbLiderazTE, tbLiderazTC);
        }
        

        private void cbCarisma2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);

            Asignaciones.elementoRecalculado(cbCarisma2, tbLuz, tbPsique);
            Asignaciones.totalesEstresCalma(cbCarisma2, tbCarismaBE, tbCarismaTE, tbPsique, atrib, 2);
            Asignaciones.totalesEstresCalma(cbCarisma2, tbCarismaBC, tbCarismaTC, tbPsique, atrib, 2);
        }

        private void cbCarisma4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);

            Asignaciones.elementoRecalculado(cbCarisma4, tbLuz, tbPsique);
            Asignaciones.totalesEstresCalma(cbCarisma4, tbCarismaBE, tbCarismaTE, tbPsique, atrib, 4);
            Asignaciones.totalesEstresCalma(cbCarisma4, tbCarismaBC, tbCarismaTC, tbPsique, atrib, 4);
        }

        private void cbCarisma6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbCarisma6, cbSubterf6, cbLideraz6, tbPsique, tbLuz);

            Asignaciones.elementoRecalculado(cbCarisma6, tbLuz, tbPsique);
            Asignaciones.totalesEstresCalma(cbCarisma6, tbCarismaBE, tbCarismaTE, tbPsique, atrib, 6);
            Asignaciones.totalesEstresCalma(cbCarisma6, tbCarismaBC, tbCarismaTC, tbPsique, atrib, 6);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbCarisma6, cbSubterf6, cbLideraz6, tbCarismaTE, tbCarismaTC, tbSubterfTE, tbSubterfTC, tbLiderazTE, tbLiderazTC);
        }

        private void cbCarisma8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);

            Asignaciones.elementoRecalculado(cbCarisma8, tbLuz, tbPsique);
            Asignaciones.totalesEstresCalma(cbCarisma8, tbCarismaBE, tbCarismaTE, tbPsique, atrib, 8);
            Asignaciones.totalesEstresCalma(cbCarisma8, tbCarismaBC, tbCarismaTC, tbPsique, atrib, 8);
        }

        private void cbCarisma10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);

            Asignaciones.elementoRecalculado(cbCarisma10, tbLuz, tbPsique);
            Asignaciones.totalesEstresCalma(cbCarisma10, tbCarismaBE, tbCarismaTE, tbPsique, atrib, 10);
            Asignaciones.totalesEstresCalma(cbCarisma10, tbCarismaBC, tbCarismaTC, tbPsique, atrib, 10);
        }

        private void cbCarisma12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbCarisma12, cbSubterf12, cbLideraz12, tbPsique, tbLuz);

            Asignaciones.elementoRecalculado(cbCarisma12, tbLuz, tbPsique);
            Asignaciones.totalesEstresCalma(cbCarisma12, tbCarismaBE, tbCarismaTE, tbPsique, atrib, 12);
            Asignaciones.totalesEstresCalma(cbCarisma12, tbCarismaBC, tbCarismaTC, tbPsique, atrib, 12);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbCarisma12, cbSubterf12, cbLideraz12, tbCarismaTE, tbCarismaTC, tbSubterfTE, tbSubterfTC, tbLiderazTE, tbLiderazTC);
        }

        private void cbLideraz2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);

            Asignaciones.elementoRecalculado(cbLideraz2, tbLuz, tbPsique);
            Asignaciones.totalesEstresCalma(cbLideraz2, tbLiderazBE, tbLiderazTE, tbPsique, atrib, 2);
            Asignaciones.totalesEstresCalma(cbLideraz2, tbLiderazBC, tbLiderazTC, tbPsique, atrib, 2);
        }

        private void cbLideraz4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);

            Asignaciones.elementoRecalculado(cbLideraz4, tbLuz, tbPsique);
            Asignaciones.totalesEstresCalma(cbLideraz4, tbLiderazBE, tbLiderazTE, tbPsique, atrib, 4);
            Asignaciones.totalesEstresCalma(cbLideraz4, tbLiderazBC, tbLiderazTC, tbPsique, atrib, 4);
        }

        private void cbLideraz6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbLideraz6, cbCarisma6, cbSubterf6, tbPsique, tbLuz);

            Asignaciones.elementoRecalculado(cbLideraz6, tbLuz, tbPsique);
            Asignaciones.totalesEstresCalma(cbLideraz6, tbLiderazBE, tbLiderazTE, tbPsique, atrib, 6);
            Asignaciones.totalesEstresCalma(cbLideraz6, tbLiderazBC, tbLiderazTC, tbPsique, atrib, 6);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbLideraz6, cbCarisma6, cbSubterf6, tbLiderazTE, tbLiderazTC, tbCarismaTE, tbCarismaTC, tbSubterfTE, tbSubterfTC);
        }

        private void cbLideraz8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);

            Asignaciones.elementoRecalculado(cbLideraz8, tbLuz, tbPsique);
            Asignaciones.totalesEstresCalma(cbLideraz8, tbLiderazBE, tbLiderazTE, tbPsique, atrib, 8);
            Asignaciones.totalesEstresCalma(cbLideraz8, tbLiderazBC, tbLiderazTC, tbPsique, atrib, 8);
        }

        private void cbLideraz10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);

            Asignaciones.elementoRecalculado(cbLideraz10, tbLuz, tbPsique);
            Asignaciones.totalesEstresCalma(cbLideraz10, tbLiderazBE, tbLiderazTE, tbPsique, atrib, 10);
            Asignaciones.totalesEstresCalma(cbLideraz10, tbLiderazBC, tbLiderazTC, tbPsique, atrib, 10);
        }

        private void cbLideraz12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbLideraz12, cbCarisma12, cbSubterf12, tbPsique, tbLuz);

            Asignaciones.elementoRecalculado(cbLideraz12, tbLuz, tbPsique);
            Asignaciones.totalesEstresCalma(cbLideraz12, tbLiderazBE, tbLiderazTE, tbPsique, atrib, 12);
            Asignaciones.totalesEstresCalma(cbLideraz12, tbLiderazBC, tbLiderazTC, tbPsique, atrib, 12);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbLideraz12, cbCarisma12, cbSubterf12, tbLiderazTE, tbLiderazTC, tbCarismaTE, tbCarismaTC, tbSubterfTE, tbSubterfTC);
        }

        private void cbBastion2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);

            Asignaciones.totalesEstresCalma(cbBastion2, tbBastionBE, tbBastionTE, tbPsique, atrib, 2);
            Asignaciones.totalesEstresCalma(cbBastion2, tbBastionBC, tbBastionTC, tbPsique, atrib, 2);
        }

        private void cbBastion4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);

            Asignaciones.totalesEstresCalma(cbBastion4, tbBastionBE, tbBastionTE, tbPsique, atrib, 4);
            Asignaciones.totalesEstresCalma(cbBastion4, tbBastionBC, tbBastionTC, tbPsique, atrib, 4);
        }

        private void cbBastion6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);

            Asignaciones.totalesEstresCalma(cbBastion6, tbBastionBE, tbBastionTE, tbPsique, atrib, 6);
            Asignaciones.totalesEstresCalma(cbBastion6, tbBastionBC, tbBastionTC, tbPsique, atrib, 6);
        }

        private void cbBastion8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);

            Asignaciones.totalesEstresCalma(cbBastion8, tbBastionBE, tbBastionTE, tbPsique, atrib, 8);
            Asignaciones.totalesEstresCalma(cbBastion8, tbBastionBC, tbBastionTC, tbPsique, atrib, 8);
        }

        private void cbBastion10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);

            Asignaciones.totalesEstresCalma(cbBastion10, tbBastionBE, tbBastionTE, tbPsique, atrib, 10);
            Asignaciones.totalesEstresCalma(cbBastion10, tbBastionBC, tbBastionTC, tbPsique, atrib, 10);
        }

        private void cbBastion12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbPsique.Text);

            Asignaciones.totalesEstresCalma(cbBastion12, tbBastionBE, tbBastionTE, tbPsique, atrib, 12);
            Asignaciones.totalesEstresCalma(cbBastion12, tbBastionBC, tbBastionTC, tbPsique, atrib, 12);
        }
        #endregion

        #region CIENCIA

        private void cbSaber2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);

            Asignaciones.elementoRecalculado(cbSaber2, tbConocimiento, tbCiencia);
            Asignaciones.totalesEstresCalma(cbSaber2, tbSaberBE, tbSaberTE, tbCiencia, atrib, 2);
            Asignaciones.totalesEstresCalma(cbSaber2, tbSaberBC, tbSaberTC, tbCiencia, atrib, 2);
        }

        private void cbSaber4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);

            Asignaciones.elementoRecalculado(cbSaber4, tbConocimiento, tbCiencia);
            Asignaciones.totalesEstresCalma(cbSaber4, tbSaberBE, tbSaberTE, tbCiencia, atrib, 4);
            Asignaciones.totalesEstresCalma(cbSaber4, tbSaberBC, tbSaberTC, tbCiencia, atrib, 4);
        }

        private void cbSaber6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbSaber6, cbCultura6, cbTecnica6, tbCiencia, tbConocimiento);

            Asignaciones.elementoRecalculado(cbSaber6, tbConocimiento, tbCiencia);
            Asignaciones.totalesEstresCalma(cbSaber6, tbSaberBE, tbSaberTE, tbCiencia, atrib, 6);
            Asignaciones.totalesEstresCalma(cbSaber6, tbSaberBC, tbSaberTC, tbCiencia, atrib, 6);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbSaber6, cbCultura6, cbTecnica6, tbSaberTE, tbSaberTC, tbCulturaTE, tbCulturaTC, tbTecnicaTE, tbTecnicaTC);
        }

        private void cbSaber8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);

            Asignaciones.elementoRecalculado(cbSaber8, tbConocimiento, tbCiencia);
            Asignaciones.totalesEstresCalma(cbSaber8, tbSaberBE, tbSaberTE, tbCiencia, atrib, 8);
            Asignaciones.totalesEstresCalma(cbSaber8, tbSaberBC, tbSaberTC, tbCiencia, atrib, 8);
        }

        private void cbSaber10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);

            Asignaciones.elementoRecalculado(cbSaber10, tbConocimiento, tbCiencia);
            Asignaciones.totalesEstresCalma(cbSaber10, tbSaberBE, tbSaberTE, tbCiencia, atrib, 10);
            Asignaciones.totalesEstresCalma(cbSaber10, tbSaberBC, tbSaberTC, tbCiencia, atrib, 10);
        }

        private void cbSaber12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbSaber12, cbCultura12, cbTecnica12, tbCiencia, tbConocimiento);

            Asignaciones.elementoRecalculado(cbSaber12, tbConocimiento, tbCiencia);
            Asignaciones.totalesEstresCalma(cbSaber12, tbSaberBE, tbSaberTE, tbCiencia, atrib, 12);
            Asignaciones.totalesEstresCalma(cbSaber12, tbSaberBC, tbSaberTC, tbCiencia, atrib, 12);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbSaber12, cbCultura12, cbTecnica12, tbSaberTE, tbSaberTC, tbCulturaTE, tbCulturaTC, tbTecnicaTE, tbTecnicaTC);
        }
        

        private void cbCultura2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);

            Asignaciones.elementoRecalculado(cbCultura2, tbConocimiento, tbCiencia);
            Asignaciones.totalesEstresCalma(cbCultura2, tbCulturaBE, tbCulturaTE, tbCiencia, atrib, 2);
            Asignaciones.totalesEstresCalma(cbCultura2, tbCulturaBC, tbCulturaTC, tbCiencia, atrib, 2);
        }

        private void cbCultura4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);

            Asignaciones.elementoRecalculado(cbCultura4, tbConocimiento, tbCiencia);
            Asignaciones.totalesEstresCalma(cbCultura4, tbCulturaBE, tbCulturaTE, tbCiencia, atrib, 4);
            Asignaciones.totalesEstresCalma(cbCultura4, tbCulturaBC, tbCulturaTC, tbCiencia, atrib, 4);
        }

        private void cbCultura6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbCultura6, cbSaber6, cbTecnica6, tbCiencia, tbConocimiento);

            Asignaciones.elementoRecalculado(cbCultura6, tbConocimiento, tbCiencia);
            Asignaciones.totalesEstresCalma(cbCultura6, tbCulturaBE, tbCulturaTE, tbCiencia, atrib, 6);
            Asignaciones.totalesEstresCalma(cbCultura6, tbCulturaBC, tbCulturaTC, tbCiencia, atrib, 6);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbCultura6, cbSaber6, cbTecnica6, tbCulturaTE, tbCulturaTC, tbSaberTE, tbSaberTC, tbTecnicaTE, tbTecnicaTC);
        }

        private void cbCultura8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);

            Asignaciones.elementoRecalculado(cbCultura8, tbConocimiento, tbCiencia);
            Asignaciones.totalesEstresCalma(cbCultura8, tbCulturaBE, tbCulturaTE, tbCiencia, atrib, 8);
            Asignaciones.totalesEstresCalma(cbCultura8, tbCulturaBC, tbCulturaTC, tbCiencia, atrib, 8);
        }

        private void cbCultura10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);

            Asignaciones.elementoRecalculado(cbCultura10, tbConocimiento, tbCiencia);
            Asignaciones.totalesEstresCalma(cbCultura10, tbCulturaBE, tbCulturaTE, tbCiencia, atrib, 10);
            Asignaciones.totalesEstresCalma(cbCultura10, tbCulturaBC, tbCulturaTC, tbCiencia, atrib, 10);
        }

        private void cbCultura12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbCultura12, cbSaber12, cbTecnica12, tbCiencia, tbConocimiento);

            Asignaciones.elementoRecalculado(cbCultura12, tbConocimiento, tbCiencia);
            Asignaciones.totalesEstresCalma(cbCultura12, tbCulturaBE, tbCulturaTE, tbCiencia, atrib, 12);
            Asignaciones.totalesEstresCalma(cbCultura12, tbCulturaBC, tbCulturaTC, tbCiencia, atrib, 12);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbCultura12, cbSaber12, cbTecnica12, tbCulturaTE, tbCulturaTC, tbSaberTE, tbSaberTC, tbTecnicaTE, tbTecnicaTC);
        }

        private void cbTecnica2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);

            Asignaciones.elementoRecalculado(cbTecnica2, tbConocimiento, tbCiencia);
            Asignaciones.totalesEstresCalma(cbTecnica2, tbTecnicaBE, tbTecnicaTE, tbCiencia, atrib, 2);
            Asignaciones.totalesEstresCalma(cbTecnica2, tbTecnicaBC, tbTecnicaTC, tbCiencia, atrib, 2);
        }

        private void cbTecnica4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);

            Asignaciones.elementoRecalculado(cbTecnica4, tbConocimiento, tbCiencia);
            Asignaciones.totalesEstresCalma(cbTecnica4, tbTecnicaBE, tbTecnicaTE, tbCiencia, atrib, 4);
            Asignaciones.totalesEstresCalma(cbTecnica4, tbTecnicaBC, tbTecnicaTC, tbCiencia, atrib, 4);
        }

        private void cbTecnica6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbTecnica6, cbCultura6, cbSaber6, tbCiencia, tbConocimiento);

            Asignaciones.elementoRecalculado(cbTecnica6, tbConocimiento, tbCiencia);
            Asignaciones.totalesEstresCalma(cbTecnica6, tbTecnicaBE, tbTecnicaTE, tbCiencia, atrib, 6);
            Asignaciones.totalesEstresCalma(cbTecnica6, tbTecnicaBC, tbTecnicaTC, tbCiencia, atrib, 6);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbTecnica6, cbCultura6, cbSaber6, tbTecnicaTE, tbTecnicaTC, tbCulturaTE, tbCulturaTC, tbSaberTE, tbSaberTC);
        }

        private void cbTecnica8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);

            Asignaciones.elementoRecalculado(cbTecnica8, tbConocimiento, tbCiencia);
            Asignaciones.totalesEstresCalma(cbTecnica8, tbTecnicaBE, tbTecnicaTE, tbCiencia, atrib, 8);
            Asignaciones.totalesEstresCalma(cbTecnica8, tbTecnicaBC, tbTecnicaTC, tbCiencia, atrib, 8);
        }

        private void cbTecnica10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);

            Asignaciones.elementoRecalculado(cbTecnica10, tbConocimiento, tbCiencia);
            Asignaciones.totalesEstresCalma(cbTecnica10, tbTecnicaBE, tbTecnicaTE, tbCiencia, atrib, 10);
            Asignaciones.totalesEstresCalma(cbTecnica10, tbTecnicaBC, tbTecnicaTC, tbCiencia, atrib, 10);
        }

        private void cbTecnica12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbTecnica12, cbCultura12, cbSaber12, tbCiencia, tbConocimiento);

            Asignaciones.elementoRecalculado(cbTecnica12, tbConocimiento, tbCiencia);
            Asignaciones.totalesEstresCalma(cbTecnica12, tbTecnicaBE, tbTecnicaTE, tbCiencia, atrib, 12);
            Asignaciones.totalesEstresCalma(cbTecnica12, tbTecnicaBC, tbTecnicaTC, tbCiencia, atrib, 12);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbTecnica12, cbCultura12, cbSaber12, tbTecnicaTE, tbTecnicaTC, tbCulturaTE, tbCulturaTC, tbSaberTE, tbSaberTC);
        }

        private void cbMistic2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);

            Asignaciones.totalesEstresCalma(cbMistic2, tbMisticBE, tbMisticTE, tbCiencia, atrib, 2);
            Asignaciones.totalesEstresCalma(cbMistic2, tbMisticBC, tbMisticTC, tbCiencia, atrib, 2);
        }

        private void cbMistic4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);

            Asignaciones.totalesEstresCalma(cbMistic4, tbMisticBE, tbMisticTE, tbCiencia, atrib, 4);
            Asignaciones.totalesEstresCalma(cbMistic4, tbMisticBC, tbMisticTC, tbCiencia, atrib, 4);
        }

        private void cbMistic6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);

            Asignaciones.totalesEstresCalma(cbMistic6, tbMisticBE, tbMisticTE, tbCiencia, atrib, 6);
            Asignaciones.totalesEstresCalma(cbMistic6, tbMisticBC, tbMisticTC, tbCiencia, atrib, 6);
        }

        private void cbMistic8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);

            Asignaciones.totalesEstresCalma(cbMistic8, tbMisticBE, tbMisticTE, tbCiencia, atrib, 8);
            Asignaciones.totalesEstresCalma(cbMistic8, tbMisticBC, tbMisticTC, tbCiencia, atrib, 8);
        }

        private void cbMistic10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);

            Asignaciones.totalesEstresCalma(cbMistic10, tbMisticBE, tbMisticTE, tbCiencia, atrib, 10);
            Asignaciones.totalesEstresCalma(cbMistic10, tbMisticBC, tbMisticTC, tbCiencia, atrib, 10);
        }

        private void cbMistic12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbCiencia.Text);

            Asignaciones.totalesEstresCalma(cbMistic12, tbMisticBE, tbMisticTE, tbCiencia, atrib, 12);
            Asignaciones.totalesEstresCalma(cbMistic12, tbMisticBC, tbMisticTC, tbCiencia, atrib, 12);
        }
        #endregion

        #region FRIALDAD
        private void cbCoraje2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbFrialdad.Text);

            Asignaciones.elementoRecalculado(cbCoraje2, tbTinieblas, tbFrialdad);
            Asignaciones.totalesEstresCalma(cbCoraje2, tbCorajeBE, tbCorajeTE, tbFrialdad, atrib, 2);
            Asignaciones.totalesEstresCalma(cbCoraje2, tbCorajeBC, tbCorajeTC, tbFrialdad, atrib, 2);
        }
        

        private void cbCoraje4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbFrialdad.Text);

            Asignaciones.elementoRecalculado(cbCoraje4, tbTinieblas, tbFrialdad);
            Asignaciones.totalesEstresCalma(cbCoraje4, tbCorajeBE, tbCorajeTE, tbFrialdad, atrib, 4);
            Asignaciones.totalesEstresCalma(cbCoraje4, tbCorajeBC, tbCorajeTC, tbFrialdad, atrib, 4);
        }

        private void cbCoraje6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbFrialdad.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbCoraje6, cbSigilo6, cbReaccion12, tbFrialdad, tbTinieblas);

            Asignaciones.elementoRecalculado(cbCoraje6, tbTinieblas, tbFrialdad);
            Asignaciones.totalesEstresCalma(cbCoraje6, tbCorajeBE, tbCorajeTE, tbFrialdad, atrib, 6);
            Asignaciones.totalesEstresCalma(cbCoraje6, tbCorajeBC, tbCorajeTC, tbFrialdad, atrib, 6);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbCoraje6, cbSigilo6, cbReaccion12, tbCorajeTE, tbCorajeTC, tbSigiloTE, tbSigiloTC, tbReaccionTE, tbReaccionTC);
        }

        private void cbCoraje8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbFrialdad.Text);

            Asignaciones.elementoRecalculado(cbCoraje8, tbTinieblas, tbFrialdad);
            Asignaciones.totalesEstresCalma(cbCoraje8, tbCorajeBE, tbCorajeTE, tbFrialdad, atrib, 8);
            Asignaciones.totalesEstresCalma(cbCoraje8, tbCorajeBC, tbCorajeTC, tbFrialdad, atrib, 8);
        }

        private void cbCoraje10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbFrialdad.Text);

            Asignaciones.elementoRecalculado(cbCoraje10, tbTinieblas, tbFrialdad);
            Asignaciones.totalesEstresCalma(cbCoraje10, tbCorajeBE, tbCorajeTE, tbFrialdad, atrib, 10);
            Asignaciones.totalesEstresCalma(cbCoraje10, tbCorajeBC, tbCorajeTC, tbFrialdad, atrib, 10);
        }

        private void cbCoraje12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbFrialdad.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbCoraje12, cbSigilo12, cbReaccion24, tbFrialdad, tbTinieblas);

            Asignaciones.elementoRecalculado(cbCoraje12, tbTinieblas, tbFrialdad);
            Asignaciones.totalesEstresCalma(cbCoraje12, tbCorajeBE, tbCorajeTE, tbFrialdad, atrib, 12);
            Asignaciones.totalesEstresCalma(cbCoraje12, tbCorajeBC, tbCorajeTC, tbFrialdad, atrib, 12);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbCoraje12, cbSigilo12, cbReaccion24, tbCorajeTE, tbCorajeTC, tbSigiloTE, tbSigiloTC, tbReaccionTE, tbReaccionTC);
        }
        

        private void cbSigilo2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbFrialdad.Text);

            Asignaciones.elementoRecalculado(cbSigilo2, tbTinieblas, tbFrialdad);
            Asignaciones.totalesEstresCalma(cbSigilo2, tbSigiloBE, tbSigiloTE, tbFrialdad, atrib, 2);
            Asignaciones.totalesEstresCalma(cbSigilo2, tbSigiloBC, tbSigiloTC, tbFrialdad, atrib, 2);
        }

        private void cbSigilo4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbFrialdad.Text);

            Asignaciones.elementoRecalculado(cbSigilo4, tbTinieblas, tbFrialdad);
            Asignaciones.totalesEstresCalma(cbSigilo4, tbSigiloBE, tbSigiloTE, tbFrialdad, atrib, 4);
            Asignaciones.totalesEstresCalma(cbSigilo4, tbSigiloBC, tbSigiloTC, tbFrialdad, atrib, 4);
        }

        private void cbSigilo6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbFrialdad.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbSigilo6, cbCoraje6, cbReaccion12, tbFrialdad, tbTinieblas);

            Asignaciones.elementoRecalculado(cbSigilo6, tbTinieblas, tbFrialdad);
            Asignaciones.totalesEstresCalma(cbSigilo6, tbSigiloBE, tbSigiloTE, tbFrialdad, atrib, 6);
            Asignaciones.totalesEstresCalma(cbSigilo6, tbSigiloBC, tbSigiloTC, tbFrialdad, atrib, 6);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbSigilo6, cbCoraje6, cbReaccion12, tbSigiloTE, tbSigiloTC, tbCorajeTE, tbCorajeTC, tbReaccionTE, tbReaccionTC);
        }

        private void cbSigilo8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbFrialdad.Text);

            Asignaciones.elementoRecalculado(cbSigilo8, tbTinieblas, tbFrialdad);
            Asignaciones.totalesEstresCalma(cbSigilo8, tbSigiloBE, tbSigiloTE, tbFrialdad, atrib, 8);
            Asignaciones.totalesEstresCalma(cbSigilo8, tbSigiloBC, tbSigiloTC, tbFrialdad, atrib, 8);
        }

        private void cbSigilo10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbFrialdad.Text);

            Asignaciones.elementoRecalculado(cbSigilo10, tbTinieblas, tbFrialdad);
            Asignaciones.totalesEstresCalma(cbSigilo10, tbSigiloBE, tbSigiloTE, tbFrialdad, atrib, 10);
            Asignaciones.totalesEstresCalma(cbSigilo10, tbSigiloBC, tbSigiloTC, tbFrialdad, atrib, 10);
        }

        private void cbSigilo12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbFrialdad.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbSigilo12, cbCoraje12, cbReaccion24, tbFrialdad, tbTinieblas);

            Asignaciones.elementoRecalculado(cbSigilo12, tbTinieblas, tbFrialdad);
            Asignaciones.totalesEstresCalma(cbSigilo12, tbSigiloBE, tbSigiloTE, tbFrialdad, atrib, 12);
            Asignaciones.totalesEstresCalma(cbSigilo12, tbSigiloBC, tbSigiloTC, tbFrialdad, atrib, 12);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbSigilo12, cbCoraje12, cbReaccion24, tbSigiloTE, tbSigiloTC, tbCorajeTE, tbCorajeTC, tbReaccionTE, tbReaccionTC);
        }
        //TO-DO reaccion!!!!!
        //TO-DO estoicismo!!!!
        #endregion

        #region IMPULSO

        private void cbRastrear2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);

            Asignaciones.elementoRecalculado(cbRastrear2, tbInstinto, tbImpulso);
            Asignaciones.totalesEstresCalma(cbRastrear2, tbRastrearBE, tbRastrearTE, tbImpulso, atrib, 2);
            Asignaciones.totalesEstresCalma(cbRastrear2, tbRastrearBC, tbRastrearTC, tbImpulso, atrib, 2);
        }

        private void cbRastrear4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);

            Asignaciones.elementoRecalculado(cbRastrear4, tbInstinto, tbImpulso);
            Asignaciones.totalesEstresCalma(cbRastrear4, tbRastrearBE, tbRastrearTE, tbImpulso, atrib, 4);
            Asignaciones.totalesEstresCalma(cbRastrear4, tbRastrearBC, tbRastrearTC, tbImpulso, atrib, 4);
        }

        private void cbRastrear6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbRastrear6, cbOrientacion6, cbFerocidad6, tbImpulso, tbInstinto);

            Asignaciones.elementoRecalculado(cbRastrear6, tbInstinto, tbImpulso);
            Asignaciones.totalesEstresCalma(cbRastrear6, tbRastrearBE, tbRastrearTE, tbImpulso, atrib, 6);
            Asignaciones.totalesEstresCalma(cbRastrear6, tbRastrearBC, tbRastrearTC, tbImpulso, atrib, 6);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbRastrear6, cbOrientacion6, cbFerocidad6, tbRastrearTE, tbRastrearTC, tbOrientaTE, tbOrientaTC, tbFerocTE, tbFerocTC);
        }

        private void cbRastrear8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);

            Asignaciones.elementoRecalculado(cbRastrear8, tbInstinto, tbImpulso);
            Asignaciones.totalesEstresCalma(cbRastrear8, tbRastrearBE, tbRastrearTE, tbImpulso, atrib, 8);
            Asignaciones.totalesEstresCalma(cbRastrear8, tbRastrearBC, tbRastrearTC, tbImpulso, atrib, 8);
        }

        private void cbRastrear10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);

            Asignaciones.elementoRecalculado(cbRastrear10, tbInstinto, tbImpulso);
            Asignaciones.totalesEstresCalma(cbRastrear10, tbRastrearBE, tbRastrearTE, tbImpulso, atrib, 10);
            Asignaciones.totalesEstresCalma(cbRastrear10, tbRastrearBC, tbRastrearTC, tbImpulso, atrib, 10);
        }

        private void cbRastrear12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbRastrear12, cbOrientacion12, cbFerocidad12, tbImpulso, tbInstinto);

            Asignaciones.elementoRecalculado(cbRastrear12, tbInstinto, tbImpulso);
            Asignaciones.totalesEstresCalma(cbRastrear12, tbRastrearBE, tbRastrearTE, tbImpulso, atrib, 12);
            Asignaciones.totalesEstresCalma(cbRastrear12, tbRastrearBC, tbRastrearTC, tbImpulso, atrib, 12);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbRastrear12, cbOrientacion12, cbFerocidad12, tbRastrearTE, tbRastrearTC, tbOrientaTE, tbOrientaTC, tbFerocTE, tbFerocTC);
        }
        

        private void cbOrientacion2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);

            Asignaciones.elementoRecalculado(cbOrientacion2, tbInstinto, tbImpulso);
            Asignaciones.totalesEstresCalma(cbOrientacion2, tbOrientaBE, tbOrientaTE, tbImpulso, atrib, 2);
            Asignaciones.totalesEstresCalma(cbOrientacion2, tbOrientaBC, tbOrientaTC, tbImpulso, atrib, 2);
        }

        private void cbOrientacion4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);

            Asignaciones.elementoRecalculado(cbOrientacion4, tbInstinto, tbImpulso);
            Asignaciones.totalesEstresCalma(cbOrientacion4, tbOrientaBE, tbOrientaTE, tbImpulso, atrib, 4);
            Asignaciones.totalesEstresCalma(cbOrientacion4, tbOrientaBC, tbOrientaTC, tbImpulso, atrib, 4);
        }

        private void cbOrientacion6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbOrientacion6, cbRastrear6, cbFerocidad6, tbImpulso, tbInstinto);

            Asignaciones.elementoRecalculado(cbOrientacion6, tbInstinto, tbImpulso);
            Asignaciones.totalesEstresCalma(cbOrientacion6, tbOrientaBE, tbOrientaTE, tbImpulso, atrib, 6);
            Asignaciones.totalesEstresCalma(cbOrientacion6, tbOrientaBC, tbOrientaTC, tbImpulso, atrib, 6);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbOrientacion6, cbRastrear6, cbFerocidad6, tbOrientaTE, tbOrientaTC, tbRastrearTE, tbRastrearTC, tbFerocTE, tbFerocTC);
        }

        private void cbOrientacion8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);

            Asignaciones.elementoRecalculado(cbOrientacion8, tbInstinto, tbImpulso);
            Asignaciones.totalesEstresCalma(cbOrientacion8, tbOrientaBE, tbOrientaTE, tbImpulso, atrib, 8);
            Asignaciones.totalesEstresCalma(cbOrientacion8, tbOrientaBC, tbOrientaTC, tbImpulso, atrib, 8);
        }

        private void cbOrientacion10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);

            Asignaciones.elementoRecalculado(cbOrientacion10, tbInstinto, tbImpulso);
            Asignaciones.totalesEstresCalma(cbOrientacion10, tbOrientaBE, tbOrientaTE, tbImpulso, atrib, 10);
            Asignaciones.totalesEstresCalma(cbOrientacion10, tbOrientaBC, tbOrientaTC, tbImpulso, atrib, 10);
        }

        private void cbOrientacion12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbOrientacion12, cbRastrear12, cbFerocidad12, tbImpulso, tbInstinto);

            Asignaciones.elementoRecalculado(cbOrientacion12, tbInstinto, tbImpulso);
            Asignaciones.totalesEstresCalma(cbOrientacion12, tbOrientaBE, tbOrientaTE, tbImpulso, atrib, 12);
            Asignaciones.totalesEstresCalma(cbOrientacion12, tbOrientaBC, tbOrientaTC, tbImpulso, atrib, 12);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbOrientacion12, cbRastrear12, cbFerocidad12, tbOrientaTE, tbOrientaTC, tbRastrearTE, tbRastrearTC, tbFerocTE, tbFerocTC);
        }
        

        private void cbFerocidad2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);

            Asignaciones.elementoRecalculado(cbFerocidad2, tbInstinto, tbImpulso);
            Asignaciones.totalesEstresCalma(cbFerocidad2, tbFerocBE, tbFerocTE, tbImpulso, atrib, 2);
            Asignaciones.totalesEstresCalma(cbFerocidad2, tbFerocBC, tbFerocTC, tbImpulso, atrib, 2);
        }

        private void cbFerocidad4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);

            Asignaciones.elementoRecalculado(cbFerocidad4, tbInstinto, tbImpulso);
            Asignaciones.totalesEstresCalma(cbFerocidad4, tbFerocBE, tbFerocTE, tbImpulso, atrib, 4);
            Asignaciones.totalesEstresCalma(cbFerocidad4, tbFerocBC, tbFerocTC, tbImpulso, atrib, 4);
        }

        private void cbFerocidad6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbFerocidad6, cbOrientacion6, cbRastrear6, tbImpulso, tbInstinto);

            Asignaciones.elementoRecalculado(cbFerocidad6, tbInstinto, tbImpulso);
            Asignaciones.totalesEstresCalma(cbFerocidad6, tbFerocBE, tbFerocTE, tbImpulso, atrib, 6);
            Asignaciones.totalesEstresCalma(cbFerocidad6, tbFerocBC, tbFerocTC, tbImpulso, atrib, 6);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbFerocidad6, cbOrientacion6, cbRastrear6, tbFerocTE, tbFerocTC, tbOrientaTE, tbOrientaTC, tbRastrearTE, tbRastrearTC);
        }

        private void cbFerocidad8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);

            Asignaciones.elementoRecalculado(cbFerocidad8, tbInstinto, tbImpulso);
            Asignaciones.totalesEstresCalma(cbFerocidad8, tbFerocBE, tbFerocTE, tbImpulso, atrib, 8);
            Asignaciones.totalesEstresCalma(cbFerocidad8, tbFerocBC, tbFerocTC, tbImpulso, atrib, 8);
        }

        private void cbFerocidad10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);

            Asignaciones.elementoRecalculado(cbFerocidad10, tbInstinto, tbImpulso);
            Asignaciones.totalesEstresCalma(cbFerocidad10, tbFerocBE, tbFerocTE, tbImpulso, atrib, 10);
            Asignaciones.totalesEstresCalma(cbFerocidad10, tbFerocBC, tbFerocTC, tbImpulso, atrib, 10);
        }

        private void cbFerocidad12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbFerocidad12, cbOrientacion12, cbRastrear12, tbImpulso, tbInstinto);

            Asignaciones.elementoRecalculado(cbFerocidad12, tbInstinto, tbImpulso);
            Asignaciones.totalesEstresCalma(cbFerocidad12, tbFerocBE, tbFerocTE, tbImpulso, atrib, 12);
            Asignaciones.totalesEstresCalma(cbFerocidad12, tbFerocBC, tbFerocTC, tbImpulso, atrib, 12);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbFerocidad12, cbOrientacion12, cbRastrear12, tbFerocTE, tbFerocTC, tbOrientaTE, tbOrientaTC, tbRastrearTE, tbRastrearTC);
        }

        

        private void cbPredador4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);

            Asignaciones.totalesEstresCalmaEsp(cbPredador4, tbPredadBE, tbPredadTE, tbImpulso, atrib, 4);
            Asignaciones.totalesEstresCalmaEsp(cbPredador4, tbPredadBC, tbPredadTC, tbImpulso, atrib, 4);
        }

        private void cbPredador8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);

            Asignaciones.totalesEstresCalmaEsp(cbPredador8, tbPredadBE, tbPredadTE, tbImpulso, atrib, 8);
            Asignaciones.totalesEstresCalmaEsp(cbPredador8, tbPredadBC, tbPredadTC, tbImpulso, atrib, 8);
        }

        private void cbPredador12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);

            Asignaciones.totalesEstresCalmaEsp(cbPredador12, tbPredadBE, tbPredadTE, tbImpulso, atrib, 12);
            Asignaciones.totalesEstresCalmaEsp(cbPredador12, tbPredadBC, tbPredadTC, tbImpulso, atrib, 12);
        }

        private void cbPredador16_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);

            Asignaciones.totalesEstresCalma(cbPredador16, tbPredadBE, tbPredadTE, tbImpulso, atrib, 16);
            Asignaciones.totalesEstresCalma(cbPredador16, tbPredadBC, tbPredadTC, tbImpulso, atrib, 16);
        }

        private void cbPredador20_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);

            Asignaciones.totalesEstresCalmaEsp(cbPredador20, tbPredadBE, tbPredadTE, tbImpulso, atrib, 20);
            Asignaciones.totalesEstresCalmaEsp(cbPredador20, tbPredadBC, tbPredadTC, tbImpulso, atrib, 20);
        }

        private void cbPredador24_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbImpulso.Text);

            Asignaciones.totalesEstresCalmaEsp(cbPredador24, tbPredadBE, tbPredadTE, tbImpulso, atrib, 24);
            Asignaciones.totalesEstresCalmaEsp(cbPredador24, tbPredadBC, tbPredadTC, tbImpulso, atrib, 24);
        }
        #endregion

        #region VIGOR

        private void cbProeza2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);

            Asignaciones.elementoRecalculado(cbProeza2, tbFuego, tbVigor);
            Asignaciones.totalesEstresCalma(cbProeza2, tbProezaBE, tbProezaTE, tbVigor, atrib, 2);
            Asignaciones.totalesEstresCalma(cbProeza2, tbProezaBC, tbProezaTC, tbVigor, atrib, 2);
        }

        private void cbProeza4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);

            Asignaciones.elementoRecalculado(cbProeza4, tbFuego, tbVigor);
            Asignaciones.totalesEstresCalma(cbProeza4, tbProezaBE, tbProezaTE, tbVigor, atrib, 4);
            Asignaciones.totalesEstresCalma(cbProeza4, tbProezaBC, tbProezaTC, tbVigor, atrib, 4);
        }

        private void cbProeza6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbProeza6, cbPelea6, cbPrecision6, tbVigor, tbFuego);

            Asignaciones.elementoRecalculado(cbProeza6, tbFuego, tbVigor);
            Asignaciones.totalesEstresCalma(cbProeza6, tbProezaBE, tbProezaTE, tbVigor, atrib, 6);
            Asignaciones.totalesEstresCalma(cbProeza6, tbProezaBC, tbProezaTC, tbVigor, atrib, 6);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbProeza6, cbPelea6, cbPrecision6, tbProezaTE, tbProezaTC, tbPeleaTE, tbPeleaTC, tbPrecisionTE, tbPrecisionTC);
        }

        private void cbProeza8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);

            Asignaciones.elementoRecalculado(cbProeza8, tbFuego, tbVigor);
            Asignaciones.totalesEstresCalma(cbProeza8, tbProezaBE, tbProezaTE, tbVigor, atrib, 8);
            Asignaciones.totalesEstresCalma(cbProeza8, tbProezaBC, tbProezaTC, tbVigor, atrib, 8);
        }

        private void cbProeza10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);

            Asignaciones.elementoRecalculado(cbProeza10, tbFuego, tbVigor);
            Asignaciones.totalesEstresCalma(cbProeza10, tbProezaBE, tbProezaTE, tbVigor, atrib, 10);
            Asignaciones.totalesEstresCalma(cbProeza10, tbProezaBC, tbProezaTC, tbVigor, atrib, 10);
        }

        private void cbProeza12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbProeza12, cbPelea12, cbPrecision12, tbVigor, tbFuego);

            Asignaciones.elementoRecalculado(cbProeza12, tbFuego, tbVigor);
            Asignaciones.totalesEstresCalma(cbProeza12, tbProezaBE, tbProezaTE, tbVigor, atrib, 12);
            Asignaciones.totalesEstresCalma(cbProeza12, tbProezaBC, tbProezaTC, tbVigor, atrib, 12);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbProeza12, cbPelea12, cbPrecision12, tbProezaTE, tbProezaTC, tbPeleaTE, tbPeleaTC, tbPrecisionTE, tbPrecisionTC);
        }

        private void cbPelea2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);

            Asignaciones.elementoRecalculado(cbPelea2, tbFuego, tbVigor);
            Asignaciones.totalesEstresCalma(cbPelea2, tbPeleaBE, tbPeleaTE, tbVigor, atrib, 2);
            Asignaciones.totalesEstresCalma(cbPelea2, tbPeleaBC, tbPeleaTC, tbVigor, atrib, 2);
        }

        private void cbPelea4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);

            Asignaciones.elementoRecalculado(cbPelea4, tbFuego, tbVigor);
            Asignaciones.totalesEstresCalma(cbPelea4, tbPeleaBE, tbPeleaTE, tbVigor, atrib, 4);
            Asignaciones.totalesEstresCalma(cbPelea4, tbPeleaBC, tbPeleaTC, tbVigor, atrib, 4);
        }

        private void cbPelea6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbPelea6, cbProeza6, cbPrecision6, tbVigor, tbFuego);

            Asignaciones.elementoRecalculado(cbPelea6, tbFuego, tbVigor);
            Asignaciones.totalesEstresCalma(cbPelea6, tbPeleaBE, tbPeleaTE, tbVigor, atrib, 6);
            Asignaciones.totalesEstresCalma(cbPelea6, tbPeleaBC, tbPeleaTC, tbVigor, atrib, 6);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbPelea6, cbProeza6, cbPrecision6, tbPeleaTE, tbPeleaTC, tbProezaTE, tbProezaTC, tbPrecisionTE, tbPrecisionTC);
        }

        private void cbPelea8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);

            Asignaciones.elementoRecalculado(cbPelea8, tbFuego, tbVigor);
            Asignaciones.totalesEstresCalma(cbPelea8, tbPeleaBE, tbPeleaTE, tbVigor, atrib, 8);
            Asignaciones.totalesEstresCalma(cbPelea8, tbPeleaBC, tbPeleaTC, tbVigor, atrib, 8);
        }

        private void cbPelea10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);

            Asignaciones.elementoRecalculado(cbPelea10, tbFuego, tbVigor);
            Asignaciones.totalesEstresCalma(cbPelea10, tbPeleaBE, tbPeleaTE, tbVigor, atrib, 10);
            Asignaciones.totalesEstresCalma(cbPelea10, tbPeleaBC, tbPeleaTC, tbVigor, atrib, 10);
        }

        private void cbPelea12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbPelea12, cbProeza12, cbPrecision12, tbVigor, tbFuego);

            Asignaciones.elementoRecalculado(cbPelea12, tbFuego, tbVigor);
            Asignaciones.totalesEstresCalma(cbPelea12, tbPeleaBE, tbPeleaTE, tbVigor, atrib, 12);
            Asignaciones.totalesEstresCalma(cbPelea12, tbPeleaBC, tbPeleaTC, tbVigor, atrib, 12);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbPelea12, cbProeza12, cbPrecision12, tbPeleaTE, tbPeleaTC, tbProezaTE, tbProezaTC, tbPrecisionTE, tbPrecisionTC);
        }
        

        private void cbPrecision2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);

            Asignaciones.elementoRecalculado(cbPrecision2, tbFuego, tbVigor);
            Asignaciones.totalesEstresCalma(cbPrecision2, tbPrecisionBE, tbPrecisionTE, tbVigor, atrib, 2);
            Asignaciones.totalesEstresCalma(cbPrecision2, tbPrecisionBC, tbPrecisionTC, tbVigor, atrib, 2);
        }

        private void cbPrecision4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);

            Asignaciones.elementoRecalculado(cbPrecision4, tbFuego, tbVigor);
            Asignaciones.totalesEstresCalma(cbPrecision4, tbPrecisionBE, tbPrecisionTE, tbVigor, atrib, 4);
            Asignaciones.totalesEstresCalma(cbPrecision4, tbPrecisionBC, tbPrecisionTC, tbVigor, atrib, 4);
        }

        private void cbPrecision6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbPrecision6, cbProeza6, cbPelea6, tbVigor, tbFuego);

            Asignaciones.elementoRecalculado(cbPrecision6, tbFuego, tbVigor);
            Asignaciones.totalesEstresCalma(cbPrecision6, tbPrecisionBE, tbPrecisionTE, tbVigor, atrib, 6);
            Asignaciones.totalesEstresCalma(cbPrecision6, tbPrecisionBC, tbPrecisionTC, tbVigor, atrib, 6);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbPrecision6, cbPelea6, cbProeza6, tbPrecisionTE, tbPrecisionTC, tbPeleaTE, tbPeleaTC, tbProezaTE, tbProezaTC);
        }

        private void cbPrecision8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);

            Asignaciones.elementoRecalculado(cbPrecision8, tbFuego, tbVigor);
            Asignaciones.totalesEstresCalma(cbPrecision8, tbPrecisionBE, tbPrecisionTE, tbVigor, atrib, 8);
            Asignaciones.totalesEstresCalma(cbPrecision8, tbPrecisionBC, tbPrecisionTC, tbVigor, atrib, 8);
        }

        private void cbPrecision10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);

            Asignaciones.elementoRecalculado(cbPrecision10, tbFuego, tbVigor);
            Asignaciones.totalesEstresCalma(cbPrecision10, tbPrecisionBE, tbPrecisionTE, tbVigor, atrib, 10);
            Asignaciones.totalesEstresCalma(cbPrecision10, tbPrecisionBC, tbPrecisionTC, tbVigor, atrib, 10);
        }

        private void cbPrecision12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);
            //llamada a verificador del atributo
            Asignaciones.verificadorAtributo(cbPrecision12, cbProeza12, cbPelea12, tbVigor, tbFuego);

            Asignaciones.elementoRecalculado(cbPrecision12, tbFuego, tbVigor);
            Asignaciones.totalesEstresCalma(cbPrecision12, tbPrecisionBE, tbPrecisionTE, tbVigor, atrib, 12);
            Asignaciones.totalesEstresCalma(cbPrecision12, tbPrecisionBC, tbPrecisionTC, tbVigor, atrib, 12);

            //llamada a igualador?
            Asignaciones.igualadorTotalesTemple(cbPrecision12, cbPelea12, cbProeza12, tbPrecisionTE, tbPrecisionTC, tbPeleaTE, tbPeleaTC, tbProezaTE, tbProezaTC);
        }

        private void cbFuria2_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);

            Asignaciones.totalesEstresCalmaEsp(cbFuria2, tbFuriaBE, tbFuriaTE, tbVigor, atrib, 2);
            Asignaciones.totalesEstresCalmaEsp(cbFuria2, tbFuriaBC, tbFuriaTC, tbVigor, atrib, 2);
        }

        private void cbFuria4_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);

            Asignaciones.totalesEstresCalmaEsp(cbFuria4, tbFuriaBE, tbFuriaTE, tbVigor, atrib, 4);
            Asignaciones.totalesEstresCalmaEsp(cbFuria4, tbFuriaBC, tbFuriaTC, tbVigor, atrib, 4);
        }

        private void cbFuria6_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);

            Asignaciones.totalesEstresCalmaEsp(cbFuria6, tbFuriaBE, tbFuriaTE, tbVigor, atrib, 6);
            Asignaciones.totalesEstresCalmaEsp(cbFuria6, tbFuriaBC, tbFuriaTC, tbVigor, atrib, 6);
        }

        private void cbFuria8_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);

            Asignaciones.totalesEstresCalmaEsp(cbFuria8, tbFuriaBE, tbFuriaTE, tbVigor, atrib, 8);
            Asignaciones.totalesEstresCalmaEsp(cbFuria8, tbFuriaBC, tbFuriaTC, tbVigor, atrib, 8);
        }

        private void cbFuria10_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);

            Asignaciones.totalesEstresCalmaEsp(cbFuria10, tbFuriaBE, tbFuriaTE, tbVigor, atrib, 10);
            Asignaciones.totalesEstresCalmaEsp(cbFuria10, tbFuriaBC, tbFuriaTC, tbVigor, atrib, 10);
        }

        private void cbFuria12_CheckedChanged(object sender, EventArgs e)
        {
            int atrib = Convert.ToInt32(tbVigor.Text);

            Asignaciones.totalesEstresCalmaEsp(cbFuria12, tbFuriaBE, tbFuriaTE, tbVigor, atrib, 12);
            Asignaciones.totalesEstresCalmaEsp(cbFuria12, tbFuriaBC, tbFuriaTC, tbVigor, atrib, 12);
        }
        #endregion
    }
}
