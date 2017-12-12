using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NeoTech.ClassesAuxiliares;

namespace NeoTech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double orcamento = double.Parse(campoOrcamento.Text);
                double margemLucro = double.Parse(campoMargemLucro.Text);
                double taxaTributo = double.Parse(campoTaxaTributo.Text);

                //Valores negativos não são aceitos
                if (orcamento < 0 || margemLucro < 0 || taxaTributo < 0) { throw new UnderZeroException(); }

                //Tributo não pode ter valor superior a 100%
                if (taxaTributo > 100) { throw new OverValueException(); }

                //O valor do lucro é dado por uma porcentagem do orçamento inicial
                double lucro = orcamento * (margemLucro / 100);

                //O valor final é pensado levando em conta que, descontando o tributo,
                //reste o valor da soma do orçamento inicial com o lucro desejando
                //dessa forma consideramos que o valor final é o que será considerado
                //para os cálculos de tributação.
                //O valor final é dado pela soma do Orçamento Inicial com o lucro e o tributo.
                //Com tudo isto em mente considero que o valor desejado para a soma de lucro
                //com orçamento inicial seja igual a 100% do valor final subtraído da taxa tributária,
                //a partir disso basta aplicar regra de 3 para se obter o valor final necessário
                //para garantir que o restante(valor descontando o tributo) seja o valor desejado para a
                //soma de Orçamento inicial com lucro desejado.

                double valorDesejado = orcamento + lucro;
                double valorFinal = (100 * valorDesejado) / (100 - taxaTributo);

                //O valor do tributo é dado pela porcentagem do orçamento final
                double valorTributo = valorFinal * (taxaTributo / 100);

                campoValorLucro.Text = lucro.ToString("N2");
                campoValorTributo.Text = valorTributo.ToString("N2");
                campoOrcamentoFinal.Text = valorFinal.ToString("N2");
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Só são aceitos valores numéricos.\n"+fe.Message,"FORMATO INCORRETO!",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            catch (UnderZeroException uz)
            {
                MessageBox.Show("Orçamento, lucro e tributo não podem ser negativos.\n" + uz.ToString(), "VALOR INCORRETO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (OverValueException ov)
            {
                MessageBox.Show("Taxa tributária nunca pode ser superior a 100%.\n" + ov.ToString(), "VALOR INCORRETO!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
