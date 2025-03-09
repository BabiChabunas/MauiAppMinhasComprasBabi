using MauiAppMinhasComprasBabi.Models;
using System.Threading.Tasks;

namespace MauiAppMinhasComprasBabi.Views
{
    public partial class NovoProduto : ContentPage
    {
        public NovoProduto()
        {
            InitializeComponent();
        }

        private async void ToolbarItem_Clicked_1(object sender, EventArgs e)
        {
            try
            {
                Produto p = new Produto
                {
                    Descricao = txt_descricao.Text,
                    Quantidade = Convert.ToDouble(txt_quantidade.Text),
                    Preco = Convert.ToDouble(txt_preco.Text)
                };

                await App.Db.insert(p);
                await DisplayAlert("Sucesso!", "Registro Inserido", "OK");

            } catch(Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }


        }
    }
}