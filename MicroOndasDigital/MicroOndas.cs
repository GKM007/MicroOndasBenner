using MicroOndasBenner.Dominio;
using MicroOndasBenner.Servico;
using MicroOndasBenner.Servico.Dtos;
using MicroOndasBenner.Servico.Interface;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace MicroOndasBenner
{
    public partial class MicroOndas : Form
    {
        int _tempo;
        private IServico _servico;


        //Primeiro passo para iniciar o Programa.
        public MicroOndas()
        {
            InitializeComponent();
        }

        private void InstanciaServico()
        {
            _servico = new Servico.ControllerMicroOndas();
        }

        private void IniciarPrograma(object sender, EventArgs e)
        {
            txtPotencia.Text = ParametroAquecimento.PotenciaPadrao.ToString();
            CriarListaPrograma();
            LimparDadosdaInterface();
        }

        //Criar lista de programas conforme dados já definidos.
        private void CriarListaPrograma()
        {
            InstanciaServico();
            //Armazenar dados de tipo de aquecimento pre definidos
            var listaProgramas = _servico.ListarTiposAquecimento();

            cmbPrograma.DataSource = null;
            cmbPrograma.ValueMember = "Id";
            cmbPrograma.DisplayMember = "Nome";
            cmbPrograma.DataSource = listaProgramas;
            cmbPrograma.SelectedIndex = -1;
        }

        private void LigarMicroOndasPorPrograma(int idPrograma)
        {
            InstanciaServico();
            var tipoAquecimento = _servico.BuscarTipoAquecimento(idPrograma);
            IniciarCronometro(tipoAquecimento.Tempo);
        }

        //Botão de Ligar microondas
        private void LigarMicroondas(object sender, EventArgs e)
        {
            if (cmbPrograma.SelectedIndex != -1)
            {
                var idPrograma = (int)cmbPrograma.SelectedValue;
                LigarMicroOndasPorPrograma(idPrograma);
                return;
            }

            //Validação dos paramentros informados na interface
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

            var iniciarMicroOndas = _servico.IniciarMicroOndas(tempo, potencia);

            if (iniciarMicroOndas.EhValido)
            {
                IniciarCronometro(iniciarMicroOndas.Tempo);
            }
            else
            {
                lblMensagem.Text = iniciarMicroOndas.Mensagem;
            }
        }

        private void PausarAquecimento(object sender, EventArgs e)
        {
            if (button_pausar.Text == "Pausar")
            {
                tmpTempo.Stop();
                button_pausar.Text = "Continuar";
            }
            else
            {
                tmpTempo.Start();
                button_pausar.Text = "Pausar";
            }
        }

        private void CancelarAquecimento(object sender, EventArgs e)
        {
            tmpTempo.Stop();
            MessageBox.Show(Mensagens.MsgCancelaraquecimento);
            LimparDadosdaInterface();
        }
        //Iniciar o microondas rapido conforme paramentros pre definidos.
        private void InicioRapido(object sender, EventArgs e)
        {
            InstanciaServico();
            var inicioRapido = _servico.InicioRapido();
            
            //Depara de paramentro
            txtTempo.Text = inicioRapido.Tempo.ToString();
            txtPotencia.Text = inicioRapido.Potencia.ToString();

            //Iniciar Cronometro
            IniciarCronometro(inicioRapido.Tempo);
        }

        private void TxtPotencia_KeyPress(object sender, KeyPressEventArgs e)
        {
            PermitirApenasNumeros(e);
        }

        //Validação da informação inserida no campo de Tempo
        private void ValidaDadosTempo(object sender, KeyPressEventArgs e)
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

        private void TempoPrograma(object sender, EventArgs e)
        {
            _tempo--;

            lblMensagem.Text = Convert.ToString(_tempo);
            lblPonto.Visible = true;

            var potencia = Convert.ToInt16(txtPotencia.Text);
            var pontoIncremento = new string('.', potencia);

            lblPonto.Text = lblPonto.Text + pontoIncremento;

            if (_tempo == 0)
            {
                tmpTempo.Stop();
                MessageBox.Show(Mensagens.MsgStatusAquecido);
                LimparDadosdaInterface();
            }
        }

        // Limpar dados da interface
        private void LimparDadosdaInterface()
        {
            lblMensagem.Text = string.Empty;
            txtTempo.Text = string.Empty;
            txtPotencia.Text = ParametroAquecimento.PotenciaPadrao.ToString();
            _tempo = 0;
            cmbPrograma.SelectedIndex = -1;
            lblPonto.Text = string.Empty;
        }

        // Inicia cronometro de tempo
        private void IniciarCronometro(int tempo)
        {
            _tempo = tempo;
            tmpTempo.Start();
        }
        //Buscar programas pre definidos e parametros
        private void RecuperarPrograma(object sender, EventArgs e)
        {
            if (cmbPrograma.SelectedIndex != -1)
            {
                InstanciaServico();
                var idPrograma = (int)cmbPrograma.SelectedValue;
                var programa = _servico.BuscarTipoAquecimento(idPrograma);

                //DePara de Parametros de tempo e potencia pre definidos
                txtPotencia.Text = programa.Potencia.ToString();
                txtTempo.Text = programa.Tempo.ToString();
            }
        }

        private void Cmb_Programa(object sender, EventArgs e)
        {
            if (cmbPrograma.SelectedIndex == -1)
            {
                LimparDadosdaInterface();
            }
        }

        private void AdicionarPrograma(object sender, EventArgs e)
        {
            var adicionarPrograma = new AdicionarPrograma();
            adicionarPrograma.FormClosing += new FormClosingEventHandler(SairNovoPrograma);
            adicionarPrograma.Show();
        }

        private void SairNovoPrograma(object sender, FormClosingEventArgs e)
        {
            CriarListaPrograma();
            LimparDadosdaInterface();
        }

        private void lblPonto_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblMensagem_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
