using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;

namespace TorneioDeLuta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            WebRequest webRequest = WebRequest.Create("http://177.36.237.87/lutadores/api/competidores");
            var response = webRequest.GetResponse();
            var rawJson = new StreamReader(response.GetResponseStream()).ReadToEnd();
            var fighters = JsonConvert.DeserializeObject<List<Fighter>>(rawJson);


            //Lutador 1
            lutador1.Text = fighters[0].nome;
            lblIdade1.Text = fighters[0].idade.ToString();
            lblLutas1.Text = fighters[0].lutas.ToString();
            lblDerrotas1.Text = fighters[0].derrotas.ToString();
            lblVitorias1.Text = fighters[0].vitorias.ToString();
            lblArtesMarciais1.Text = fighters[0].artesMarciais.Count.ToString();

            //Lutador 2
            lutador2.Text = fighters[1].nome;
            lblIdade2.Text = fighters[1].idade.ToString();
            lblLutas2.Text = fighters[1].lutas.ToString();
            lblDerrotas2.Text = fighters[1].derrotas.ToString();
            lblVitorias2.Text = fighters[1].vitorias.ToString();
            lblArtesMarciais2.Text = fighters[1].artesMarciais.Count.ToString();

            //Lutador 3
            lutador3.Text = fighters[2].nome;
            lblIdade3.Text = fighters[2].idade.ToString();
            lblLutas3.Text = fighters[2].lutas.ToString();
            lblDerrotas3.Text = fighters[2].derrotas.ToString();
            lblVitorias3.Text = fighters[2].vitorias.ToString();
            lblArtesMarciais3.Text = fighters[2].artesMarciais.Count.ToString();

            //Lutador 4
            lutador4.Text = fighters[3].nome;
            lblIdade4.Text = fighters[3].idade.ToString();
            lblLutas4.Text = fighters[3].lutas.ToString();
            lblDerrotas4.Text = fighters[3].derrotas.ToString();
            lblVitorias4.Text = fighters[3].vitorias.ToString();
            lblArtesMarciais4.Text = fighters[3].artesMarciais.Count.ToString();

            //Lutador 5
            lutador5.Text = fighters[4].nome;
            lblIdade5.Text = fighters[4].idade.ToString();
            lblLutas5.Text = fighters[4].lutas.ToString();
            lblDerrotas5.Text = fighters[4].derrotas.ToString();
            lblVitorias5.Text = fighters[4].vitorias.ToString();
            lblArtesMarciais5.Text = fighters[4].artesMarciais.Count.ToString();

            //Lutador 6
            lutador6.Text = fighters[5].nome;
            lblIdade6.Text = fighters[5].idade.ToString();
            lblLutas6.Text = fighters[5].lutas.ToString();
            lblDerrotas6.Text = fighters[5].derrotas.ToString();
            lblVitorias6.Text = fighters[5].vitorias.ToString();
            lblArtesMarciais6.Text = fighters[5].artesMarciais.Count.ToString();

            //Lutador 7
            lutador7.Text = fighters[6].nome;
            lblIdade7.Text = fighters[6].idade.ToString();
            lblLutas7.Text = fighters[6].lutas.ToString();
            lblDerrotas7.Text = fighters[6].derrotas.ToString();
            lblVitorias7.Text = fighters[6].vitorias.ToString();
            lblArtesMarciais7.Text = fighters[6].artesMarciais.Count.ToString();

            //Lutador 8
            lutador8.Text = fighters[7].nome;
            lblIdade8.Text = fighters[7].idade.ToString();
            lblLutas8.Text = fighters[7].lutas.ToString();
            lblDerrotas8.Text = fighters[7].derrotas.ToString();
            lblVitorias8.Text = fighters[7].vitorias.ToString();
            lblArtesMarciais8.Text = fighters[7].artesMarciais.Count.ToString();

            //Lutador 9
            lutador9.Text = fighters[8].nome;
            lblIdade9.Text = fighters[8].idade.ToString();
            lblLutas9.Text = fighters[8].lutas.ToString();
            lblDerrotas9.Text = fighters[8].derrotas.ToString();
            lblVitorias9.Text = fighters[8].vitorias.ToString();
            lblArtesMarciais9.Text = fighters[8].artesMarciais.Count.ToString();

            //Lutador 10
            lutador10.Text = fighters[9].nome;
            lblIdade10.Text = fighters[9].idade.ToString();
            lblLutas10.Text = fighters[9].lutas.ToString();
            lblDerrotas10.Text = fighters[9].derrotas.ToString();
            lblVitorias10.Text = fighters[9].vitorias.ToString();
            lblArtesMarciais10.Text = fighters[9].artesMarciais.Count.ToString();

            //Lutador 11
            lutador11.Text = fighters[10].nome;
            lblIdade11.Text = fighters[10].idade.ToString();
            lblLutas11.Text = fighters[10].lutas.ToString();
            lblDerrotas11.Text = fighters[10].derrotas.ToString();
            lblVitorias11.Text = fighters[10].vitorias.ToString();
            lblArtesMarciais11.Text = fighters[10].artesMarciais.Count.ToString();

            //Lutador 12
            lutador12.Text = fighters[11].nome;
            lblIdade12.Text = fighters[11].idade.ToString();
            lblLutas12.Text = fighters[11].lutas.ToString();
            lblDerrotas12.Text = fighters[11].derrotas.ToString();
            lblVitorias12.Text = fighters[11].vitorias.ToString();
            lblArtesMarciais12.Text = fighters[11].artesMarciais.Count.ToString();

            //Lutador 13
            lutador13.Text = fighters[12].nome;
            lblIdade13.Text = fighters[12].idade.ToString();
            lblLutas13.Text = fighters[12].lutas.ToString();
            lblDerrotas13.Text = fighters[12].derrotas.ToString();
            lblVitorias13.Text = fighters[12].vitorias.ToString();
            lblArtesMarciais13.Text = fighters[12].artesMarciais.Count.ToString();

            //Lutador 14
            lutador14.Text = fighters[13].nome;
            lblIdade14.Text = fighters[13].idade.ToString();
            lblLutas14.Text = fighters[13].lutas.ToString();
            lblDerrotas14.Text = fighters[13].derrotas.ToString();
            lblVitorias14.Text = fighters[13].vitorias.ToString();
            lblArtesMarciais14.Text = fighters[13].artesMarciais.Count.ToString();

            //Lutador 15
            lutador15.Text = fighters[14].nome;
            lblIdade15.Text = fighters[14].idade.ToString();
            lblLutas15.Text = fighters[14].lutas.ToString();
            lblDerrotas15.Text = fighters[14].derrotas.ToString();
            lblVitorias15.Text = fighters[14].vitorias.ToString();
            lblArtesMarciais15.Text = fighters[14].artesMarciais.Count.ToString();

            //Lutador 16
            lutador16.Text = fighters[15].nome;
            lblIdade16.Text = fighters[15].idade.ToString();
            lblLutas16.Text = fighters[15].lutas.ToString();
            lblDerrotas16.Text = fighters[15].derrotas.ToString();
            lblVitorias16.Text = fighters[15].vitorias.ToString();
            lblArtesMarciais16.Text = fighters[15].artesMarciais.Count.ToString();
        }

        private Fighter luta(Fighter fighter1 , Fighter fighter2)
        {
            int winPercF1 = ((fighter1.vitorias / fighter1.lutas) * 100);
            int winPercF2 = ((fighter2.vitorias / fighter2.lutas) * 100);

            if (winPercF1 == winPercF2)
            {
                if(fighter1.artesMarciais.Count == fighter2.artesMarciais.Count)
                {
                    if (fighter1.lutas > fighter2.lutas)
                    {
                        return fighter1;
                    }
                    else
                    {
                        return fighter2;
                    }
                }
                else
                {
                    if (fighter1.artesMarciais.Count > fighter2.artesMarciais.Count)
                    {
                        return fighter1;
                    }
                    else
                    {
                        return fighter2;
                    }
                }
            }
            else
            {
                if (winPercF1 > winPercF2)
                {
                    return fighter1;
                }
                else
                {
                    return fighter2;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (lutador1.Checked && lutador2.Checked && lutador3.Checked && lutador4.Checked &&
                lutador5.Checked && lutador6.Checked && lutador7.Checked && lutador8.Checked &&
                lutador9.Checked && lutador10.Checked && lutador11.Checked && lutador12.Checked &&
                lutador13.Checked && lutador14.Checked && lutador15.Checked && lutador16.Checked)
            {
                WebRequest webRequest = WebRequest.Create("http://177.36.237.87/lutadores/api/competidores");
                var response = webRequest.GetResponse();
                var rawJson = new StreamReader(response.GetResponseStream()).ReadToEnd();
                var fighters = JsonConvert.DeserializeObject<List<Fighter>>(rawJson);

                fighters = fighters.OrderBy(f => f.idade).ToList();

                //Oitavas de final
                List<Fighter> oitavas = new List<Fighter>();
                oitavas.Add(luta(fighters[0], fighters[1]));
                oitavas.Add(luta(fighters[2], fighters[3]));
                oitavas.Add(luta(fighters[4], fighters[5]));
                oitavas.Add(luta(fighters[6], fighters[7]));
                oitavas.Add(luta(fighters[8], fighters[9]));
                oitavas.Add(luta(fighters[10], fighters[11]));
                oitavas.Add(luta(fighters[12], fighters[13]));
                oitavas.Add(luta(fighters[14], fighters[15]));
                oitavas = oitavas.OrderBy(o => o.idade).ToList();

                //Quartas de final
                List<Fighter> quartas = new List<Fighter>();
                quartas.Add(luta(oitavas[0], oitavas[1]));
                quartas.Add(luta(oitavas[2], oitavas[3]));
                quartas.Add(luta(oitavas[4], oitavas[5]));
                quartas.Add(luta(oitavas[6], oitavas[7]));

                //Semifinais
                List<Fighter> semifinal = new List<Fighter>();
                semifinal.Add(luta(quartas[0], quartas[1]));
                semifinal.Add(luta(quartas[2], quartas[3]));

                //Final
                Fighter vencedor = luta(semifinal[0], semifinal[1]);
                Form2 form2 = new Form2(vencedor);
                form2.Show();
            }
            else
            {
                MessageBox.Show("Só é possível iniciar após selecionar exatamente 16 competidores.");
                return;
            }
        }
    }
}
