using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Tps_SIM
{
    public partial class Form1 : Form
    {
        private GeneradorVariables random;
        private double ancho;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            Inicio ventana1 = new Inicio(this);
            ventana1.ShowDialog();
            this.Show();
            random = new GeneradorVariables();
            // inicializarChart()
            CmbDistribuciones.SelectedIndex = -1;
            CmbDistribuciones.Focus();
        }

        private void BtnGenerar_Click(object sender, EventArgs e)
        {
            inicializarChart();
            BtnGenerar.Enabled = true;
            for (var index = 1; index <= int.Parse(txtCantidad.Text); index++)
            {
                if (CmbDistribuciones.SelectedIndex == 0)
                    ListaAleatorios.Items.Add(random.generarUniforme(int.Parse(txtA.Text), int.Parse(txtB.Text)));

                if (CmbDistribuciones.SelectedIndex == 1)
                    ListaAleatorios.Items.Add(random.generarExponencialNegativa(1 / (double.Parse(TxtLambda.Text.Replace(".", ",")))));

                if (CmbDistribuciones.SelectedIndex == 2)
                    ListaAleatorios.Items.Add(random.generarNormal(double.Parse(TxtMedia.Text.Replace(".", ",")), double.Parse(TxtDesv.Text.Replace(".", ","))));
            }

            graficar();
            BtnGenerar.Enabled = false;
        }
        // inicializarChart(): grafica las opciones generales del grafico, titulos y a agregar las frecuencias observadas 
        // para cada distribucion
        private void inicializarChart()
        {
            //grafico.ChartAreas.Clear();
            //grafico.ChartAreas.Add(0);
            //grafico.ChartAreas(0).Axes(0).MajorGrid.LineColor = Color.Transparent;
            //grafico.ChartAreas(0).Axes(0).MajorTickMark.LineColor = Color.Transparent;
            //grafico.ChartAreas(0).Axes(0).ScaleView.Size = 3;
            //grafico.ChartAreas(0).Axes(0).Title = "Intervalos";
            //grafico.ChartAreas(0).Axes(1).Title = "Frecuencias";

            // SERIE
            grafico.Series.Clear();
            grafico.Series.Add("Frecuencia Observada");
            //grafico.Series.Add("Frec. Observadas");
            //grafico.Series(0).CustomProperties = "PointWidth=1";
            //grafico.Series(0).BorderColor = Color.Black; 
        }

        // graficar(): esta funcion va a llamar a las funciones de graficar distribucion, segun el combo de distribuciones
        // que haya seleccionado el usuario
        private void graficar()
        {
            switch (CmbDistribuciones.SelectedIndex)
            {
                case 0:
                    {
                        graficarDistribucionesUniforme(double.Parse(txtA.Text), double.Parse(txtB.Text), false);
                        break;
                    }

                case 1:
                    {
                        graficarDistribucionesExponencial(0, obtenerMax(), false);
                        break;
                    }

                case 2:
                    {
                        // graficarDistribucionesNormal(obtenerMin(), obtenerMax(), False, Double.Parse(TxtMedia.Text), Double.Parse(TxtDesv.Text))
                        graficarDistribucionesNormal(obtenerMin(), obtenerMax(), false, media(), desviacionEstandar());
                        break;
                    }
            }
        }

        // graficarDistribucionesUniforme(): funcion que nos ayuda a graficar la distribucion Uniforme y a llenar la tabla
        // de datos de las frecuencias y los limites. Recibe como parametros el minimo,
        // maximo y el boolean sinIntervalos
        private void graficarDistribucionesUniforme(double min, double max, bool sinIntervalos)
        {
            double minimo = min;
            double maximo = max;
            string fd = "-";
            int acum;
            double a = Math.Round(double.Parse(txtA.Text), 4);
            double b = Math.Round(double.Parse(txtB.Text), 4);
            double fe = Math.Round(((a + b) / 2), 4);


            if (sinIntervalos == false)
            {
                // la variable sim es para delimitar el final de los limites en el grafico
                string sim = ")";
                ancho = Math.Round((maximo - minimo) / double.Parse(CmbIntervalos.Text), 4);


                for (var index = 0; index <= double.Parse(CmbIntervalos.Text) - 1; index++)
                {
                    acum = 0; // son las frecuencias observadas
                    double num = (ancho * index) + minimo;

                    foreach (double item in ListaAleatorios.Items)
                    {
                        if ((index < double.Parse(CmbIntervalos.Text) - 1))
                        {
                            if ((num <= item) & ((num + ancho) > item))
                                acum += 1;
                        }
                        else if ((num <= item) & ((num + ancho) >= item))
                        {
                            acum += 1;
                            sim = "]";
                        }
                    }

                    grafico.Series["Frecuencia Observada"].Points.AddXY("[ " + string.Format("{0:C4}", num).Replace("$", "").Replace("€", "") + " _ " + string.Format("{0:C4}", (num + ancho)).Replace("$", "").Replace("€", "") + sim, acum);
                    TablaDatos.Rows.Add(num, num + ancho, acum, fd, fe);
                }
            }
            else
                for (var index = min; index <= max; index++)
                {
                    acum = 0;
                    foreach (int item in ListaAleatorios.Items)
                    {
                        if (item == index)
                            acum += 1;
                    }

                    //grafico.Series(0).Points.AddXY(index, acum);
                }
            //for (var index = 0; index <= grafico.Series(0).Points.Count - 1; index++)
                //grafico.Series(0).Points(index).Label = grafico.Series(0).Points(index).YValues(0);
        }



        private void graficarDistribucionesExponencial(double min, double max, bool sinIntervalos)
        {
            double minimo = min;
            double maximo = max;
            int acum;
            double n = double.Parse(txtCantidad.Text);
            double lambda = double.Parse(TxtLambda.Text);
            double marca;
            //grafico.Series.Add("Frecuencia Observada"); //Agrega la serie para luego cargarle la fo

            if (sinIntervalos == false)
            {
                string sim = ")";
                ancho = Math.Round((maximo - minimo) / double.Parse(CmbIntervalos.Text), 4);


                for (var index = 0; index <= double.Parse(CmbIntervalos.Text) - 1; index++)
                {
                    acum = 0;
                    // num es el limite inferior
                    double num = (ancho * index) + minimo;

                    foreach (double item in ListaAleatorios.Items)
                    {
                        if ((index < double.Parse(CmbIntervalos.Text) - 1))
                        {
                            if ((num <= item) & ((num + ancho) > item))
                                acum += 1;
                        }
                        else if ((num <= item) & ((num + ancho) >= item))
                        {
                            acum += 1;
                            sim = "]";
                        }
                    }
                    // num+ancho es el limite superior
                    marca = Math.Round((num + num + ancho) / 2, 4);
                    double fd = Math.Round(((lambda * Math.Pow(Math.E, (-lambda * marca))) * ancho), 4);
                    double fa = ((1 - Math.Pow(Math.E, -lambda * (num + ancho))) - (1 - Math.Pow(Math.E, -lambda * num)));
                    double fe = Math.Round(fa * n, 4);
                    //grafico.Series["Frecuencia Observada"].Points.AddXY(num,acum);
                    
                    grafico.Series["Frecuencia Observada"].Points.AddXY("[ " + string.Format("{0:C4}", num).Replace("$", "").Replace("€", "") + " _ " + string.Format("{0:C4}", (num + ancho)).Replace("$", "").Replace("€", "") + sim, acum);
                    TablaDatos.Rows.Add(num, num + ancho, acum, fd, fe);
                }
            }
            else
                for (var index = min; index <= max; index++)
                {
                    acum = 0;
                    foreach (int item in ListaAleatorios.Items)
                    {
                        if (item == index)
                            acum += 1;
                    }

                   // grafico.Series(0).Points.AddXY(index, acum);
                }
            //for (var index = 0; index <= grafico.Series(0).Points.Count - 1; index++)
              //  grafico.Series(0).Points(index).Label = grafico.Series(0).Points(index).YValues(0);
        }

        private void graficarDistribucionesNormal(double min, double max, bool sinIntervalos, double media, double desviacion)
        {
            double minimo = min;
            double maximo = max;
            int acum;
            double marca; // = (maximo + minimo) / 2
            double n = double.Parse(txtCantidad.Text) - 1;
            double m = media;
            double desv = desviacion;
            double numerador;
            double denominador = (desv * Math.Sqrt(2 * Math.PI));
            double fd;
            double fe;

            if (sinIntervalos == false)
            {
                string sim = ")";
                ancho = Math.Round((maximo - minimo) / double.Parse(CmbIntervalos.Text), 4);

                for (var index = 0; index <= double.Parse(CmbIntervalos.Text) - 1; index++)
                {
                    acum = 0; // fo
                    double num = Math.Round((ancho * index) + minimo, 4);

                    foreach (double item in ListaAleatorios.Items)
                    {
                        if ((index < double.Parse(CmbIntervalos.Text) - 1))
                        {
                            if ((num <= item) & ((num + ancho) > item))
                                acum += 1;
                        }
                        else if ((num <= item) & ((num + ancho) >= item))
                        {
                            acum += 1;
                            sim = "]";
                        }
                    }

                    marca = Math.Round((num + num + ancho) / 2, 4); // (limInf + limSup) / 2
                    numerador = Math.Exp(-0.5) * Math.Pow((marca - m) / desv, 2);
                    
                    grafico.Series["Frecuencia Observada"].Points.AddXY("[ " + string.Format("{0:C4}", num).Replace("$", "").Replace("€", "") + " _ " + string.Format("{0:C4}", (num + ancho)).Replace("$", "").Replace("€", "") + sim, acum);
                    fd = Math.Round(((numerador / denominador) * ancho), 4); // es P() -> Func. de Densidad
                    fe = Math.Round((n + 1) * fd, 4);
                    TablaDatos.Rows.Add(num, num + ancho, acum, fd, fe);
                }
            }
            else
                for (var index = min; index <= max; index++)
                {
                    acum = 0;
                    foreach (int item in ListaAleatorios.Items)
                    {
                        if (item == index)
                            acum += 1;
                    }

                    //grafico.Series(0).Points.AddXY(index, acum);
                }
            //for (var index = 0; index <= grafico.Series(0).Points.Count - 1; index++)
                //grafico.Series(0).Points(index).Label = grafico.Series(0).Points(index).YValues(0);
        }

        private void CmbDistribuciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            limpiarCmb();
            inicializarChart();
            ListaAleatorios.Items.Clear();
            BtnGenerar.Enabled = true;
            txtCantidad.Enabled = true;
            CmbIntervalos.Enabled = true;
            switch (CmbDistribuciones.SelectedIndex)
            {
                case 0:
                    {
                        txtA.Enabled = true;
                        txtA.Focus();
                        txtB.Enabled = true;
                        TxtLambda.Enabled = false;
                        TxtMedia.Enabled = false;
                        TxtDesv.Enabled = false;
                        break;
                    }

                case 1:
                    {
                        TxtLambda.Enabled = true;
                        TxtLambda.Focus();
                        txtA.Enabled = false;
                        txtB.Enabled = false;
                        TxtMedia.Enabled = false;
                        TxtDesv.Enabled = false;
                        break;
                    }

                case 2:
                    {
                        TxtMedia.Enabled = true;
                        TxtDesv.Enabled = true;
                        TxtMedia.Focus();
                        txtA.Enabled = false;
                        txtB.Enabled = false;
                        TxtLambda.Enabled = false;
                        break;
                    }
            }
        }
        private void limpiarCmb()
        {
            txtA.Text = "";
            txtB.Text = "";
            txtCantidad.Text = "";
            TxtDesv.Text = "";
            TxtLambda.Text = "";
            TxtMedia.Text = "";
            CmbIntervalos.SelectedIndex = -1;
            TablaDatos.Rows.Clear();
        }
        private double obtenerMax()
        {
            double max = ListaAleatorios.SelectedIndex;//(0);

            foreach (double item in ListaAleatorios.Items)
            {
                if ((item > max))
                    max = item;
            }
            return max;
        }

        private double obtenerMin()
        {
            double min = ListaAleatorios.SelectedIndex;// (0);

            foreach (double item in ListaAleatorios.Items)
            {
                if ((item < min))
                    min = item;
            }
            return min;
        }

        private double desviacionEstandar()
        {
            double m = media();
            double sumatoria=0;
            double cantidad = double.Parse(txtCantidad.Text) - 1;
            double resta;
            double desvEst;
            foreach (double item in ListaAleatorios.Items)
            {
                resta = item - m;
                sumatoria = Math.Pow(resta, 2);
            }
            desvEst = Math.Round(sumatoria / cantidad, 4);
            return desvEst;
        }

        private double media()
        {
            double acum=0;
            double cantidad = double.Parse(txtCantidad.Text);
            double m;
            foreach (double item in ListaAleatorios.Items)
                acum = +item;
            m = Math.Round((acum / cantidad), 4);
            return m;
        }
    }
}
