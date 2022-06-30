private void btnExibir_Click(object sender, EventArgs e)

{
    string nome;
    string veiculo;
    float distancia;
    float litros;
    string consumo;

        consumo = distancia / litros;

    nome = txtNome.Text;
    veiculo = txtVeiculo.Text;
    distancia = float.Parse(txtDistancia.Text);
    litros = float.Parse(txtLitros.Text);
    consumo = txtConsumo.Text;

    if (txtNome.Text == "")
    {
        MessageBox.Show("Preencha o campo Nome.", "Valida")
    }
if (!float.TryParse(txtDistancia.Text, out distancia))
{
    MessageBox.Show()
}

}