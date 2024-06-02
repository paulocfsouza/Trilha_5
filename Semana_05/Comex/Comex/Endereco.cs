class Endereco
{
    string bairro;
    string cidade;
    string complemento;
    string estado;
    string rua;
    int numero;

    
    public string Rua
    {
        get { return rua; }
        set { rua = value; }
    }
    
    // Construtor que exige um endereço
    public Endereco(string rua)
    {
        Rua = rua;   
    }

   
}