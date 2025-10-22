using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjetoAtendimento
{
    public partial class Form1 : Form
    {
        private Senhas senhas;
        private Guiches guiches;

        public Form1()
        {
            InitializeComponent();
            senhas = new Senhas();
            guiches = new Guiches();
            AtualizarQtdGuiches();
        }

        private void AtualizarQtdGuiches()
        {
            lblQtdGuiches.Text = guiches.Quantidade().ToString();
        }

        private void AtualizarListaSenhas()
        {
            lstSenhas.Items.Clear();
            foreach (var s in senhas.FilaSenhas)
            {
                lstSenhas.Items.Add(s.DadosParciais());
            }
        }

        private void AtualizarListaAtendimentos(int? guicheId = null)
        {
            lstAtendimentos.Items.Clear();

            if (guicheId.HasValue)
            {
                var g = guiches.ObterPorId(guicheId.Value);
                if (g != null)
                {
                    foreach (var a in g.Atendimentos)
                    {
                        lstAtendimentos.Items.Add(a.DadosCompletos());
                    }
                }
            }
            else
            {
                foreach (var g in guiches.ListaGuiches)
                {
                    foreach (var a in g.Atendimentos)
                    {
                        lstAtendimentos.Items.Add($"Guichê {g.Id}: {a.DadosCompletos()}");
                    }
                }
            }
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            var s = senhas.Gerar();
            MessageBox.Show($"Senha gerada: {s.DadosParciais()}", "Nova Senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AtualizarListaSenhas();
        }

        private void btnAdicionarGuiche_Click(object sender, EventArgs e)
        {
            int id = (int)nudGuicheId.Value;
            if (guiches.ObterPorId(id) != null)
            {
                MessageBox.Show("Já existe um guichê com esse ID.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            guiches.Adicionar(new Guiche(id));
            AtualizarQtdGuiches();
            MessageBox.Show($"Guichê {id} adicionado com sucesso.", "Guichê", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnChamar_Click(object sender, EventArgs e)
        {
            int id = (int)nudGuicheId.Value;
            var g = guiches.ObterPorId(id);
            if (g == null)
            {
                MessageBox.Show("Guichê não encontrado. Adicione primeiro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (senhas.FilaSenhas.Count == 0)
            {
                MessageBox.Show("Não há senhas na fila.", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            bool sucesso = g.Chamar(senhas.FilaSenhas);
            if (sucesso)
            {
                MessageBox.Show($"Guichê {g.Id} chamou uma senha.", "Atendimento", MessageBoxButtons.OK, MessageBoxIcon.Information);
                AtualizarListaSenhas();
                AtualizarListaAtendimentos(g.Id);
            }
        }

        private void btnListarSenhas_Click(object sender, EventArgs e)
        {
            AtualizarListaSenhas();
        }

        private void btnListarAtendimentos_Click(object sender, EventArgs e)
        {
            int id = (int)nudGuicheId.Value;
            var g = guiches.ObterPorId(id);
            if (g != null)
                AtualizarListaAtendimentos(id);
            else
                AtualizarListaAtendimentos(null);
        }
    }
}
