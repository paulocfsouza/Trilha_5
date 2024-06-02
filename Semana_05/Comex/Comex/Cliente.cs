class Cliente
{
    private string nome;
    private string cpf;
    private string email;
    private string profissao;
    private string telefone;
    Endereco endereco;

    
        // Propriedades públicas para acessar e modificar os atributos privados
    public string Nome
    {
        get => nome;
        set => nome = value;
    }
    public string Cpf
    {
        get => cpf;
        set => cpf = value;
    }

    public string Email
    {
        get => email;
        set => email = value;
    }

    public string Profissao
    {
        get => profissao;
        set => profissao = value;
    }

    public string Telefone
    {
        get => telefone;
        set => telefone = value;
    }

    // Construtor que exige um nome
    public Cliente(string nome, string cpf, string email, string profissao, string telefone)
    {
        Nome = nome;
        Cpf = cpf;
        Email = email;
        Profissao = profissao;
        Telefone = telefone;
    }
    public void ExibirInformacaoDoCliente(Endereco endereco)
    {
        Console.WriteLine($"\nNome: {Nome}" +
            $"\nCPF: {Cpf}" +
            $"\nE-mail: {Email}" +
            $"\nProfissao: {Profissao}" +
            $"\nTelefone: {Telefone}" 
            );
    }
}

   