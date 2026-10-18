namespace MauiAppJogoDaVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;

            if (vez == "X")
            {
                btn.Text = "X";
                vez = "O";
            }
            else
            {
                btn.Text = "O";
                vez = "X";
            }

            // Verifica se o X ganhou em qualquer linha, coluna ou diagonal
            if (Verifica("X"))
            {
                DisplayAlert("Parabéns!", "O X ganhou!", "OK");
                Zerar();
            }
            // Verifica se o O ganhou em qualquer linha, coluna ou diagonal
            else if (Verifica("O"))
            {
                DisplayAlert("Parabéns!", "O O ganhou!", "OK");
                Zerar();
            }

        } // Fecha método 

        // Método auxiliar que verifica todas as combinações para o jogador informado ("X" ou "O")
        bool Verifica(string p)
        {
            // Linhas
            if (btn10.Text == p && btn11.Text == p && btn12.Text == p) return true;
            if (btn20.Text == p && btn21.Text == p && btn22.Text == p) return true;
            if (btn30.Text == p && btn31.Text == p && btn32.Text == p) return true;

            // Colunas
            if (btn10.Text == p && btn20.Text == p && btn30.Text == p) return true;
            if (btn11.Text == p && btn21.Text == p && btn31.Text == p) return true;
            if (btn12.Text == p && btn22.Text == p && btn32.Text == p) return true;

            // Diagonais
            if (btn10.Text == p && btn21.Text == p && btn32.Text == p) return true;
            if (btn12.Text == p && btn21.Text == p && btn30.Text == p) return true;

            return false;
        }

        void Zerar()
        {
            // Limpa o texto de todos os botões do tabuleiro
            btn10.Text = "";
            btn11.Text = "";
            btn12.Text = "";
            btn20.Text = "";
            btn21.Text = "";
            btn22.Text = "";
            btn30.Text = "";
            btn31.Text = "";
            btn32.Text = "";

            // Reativa todos os botões para permitir novas jogadas
            btn10.IsEnabled = true;
            btn11.IsEnabled = true;
            btn12.IsEnabled = true;
            btn20.IsEnabled = true;
            btn21.IsEnabled = true;
            btn22.IsEnabled = true;
            btn30.IsEnabled = true;
            btn31.IsEnabled = true;
            btn32.IsEnabled = true;

            // Reinicia a vez para o "X"
            vez = "X";
        }

    } // Fecha Classe 
} // Fecha Namespace