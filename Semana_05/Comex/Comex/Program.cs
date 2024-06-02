// Comix
void ExibirLogo()
{
    Console.WriteLine(@"
█▓▒▒░░░Comix░░░▒▒▓█
");
    string mensagemDeBoasVindas = "Sejam bem vindos!\n";
    Console.WriteLine(mensagemDeBoasVindas);
 }

ExibirLogo();
Menu menu = new Menu();
menu.ExibirMenu();

