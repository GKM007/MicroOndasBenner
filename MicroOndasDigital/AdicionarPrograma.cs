using MicroOndasBenner.Dominio;
using MicroOndasBenner.Servico;
using MicroOndasBenner.Servico.Dtos;
using MicroOndasBenner.Servico.Interface;
using System;
using System.Windows.Forms;

namespace MicroOndasBenner
{
    public partial class AdicionarPrograma : Form
    {
        private IServico _servico;

        public AdicionarPrograma()
        {
            InitializeComponent();
        }

        private void GravarPrograma(object sender, EventArgs e)
        {
            int tempo, potencia;
            if (!int.TryParse(txtTempo.Text, out tempo))
            {
                lblMensagem.Text = Mensagens.MsgTempoInvalido;
                return;
            }

            if (!int.TryParse(txtPotencia.Text, out potencia))
            {
                lblMensagem.Text = Mensagens.MsgPotenciaInvalido;
                return;
            }

            if (string.IsNullOrEmpty(txtPrograma.Text))
            {
                lblMensagem.Text = Mensagens.MsgProgramaInvalido;
                return;
            }

            var tipoAquecimento = new DTOTipoAquecimento
            {
                Potencia = Convert.ToInt16(txtPotencia.Text),
                Tempo = Convert.ToInt16(txtTempo.Text),
                Nome = txtPrograma.Text
            };

            _servico = new Servico.ControllerMicroOndas();
            var programa = _servico.AdicionarNovoPrograma(tipoAquecimento);
            if (programa.EhValido)
            {
                Close();
            }
            else
            {
                lblMensagem.Text = programa.Mensagem;
            }
        }

        private void ValidaDadosPotencia(object sender, KeyPressEventArgs e)
        {
            PermitirApenasNumeros(e);
        }

        private void ValidarDadosTempo(object sender, KeyPressEventArgs e)
        {
            PermitirApenasNumeros(e);
        }

        private void PermitirApenasNumeros(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void AdicionarPrograma_Load(object sender, EventArgs e)
        {

        }
    }
}
