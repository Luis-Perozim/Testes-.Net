using InterfacesEXE;

SalvarXml salvarXml = new SalvarXml();
salvarXml.Salvar();
salvarXml.Nome();

SalvarJson salvarJason = new SalvarJson();
salvarJason.Salvar();
salvarJason.Nome();

ISalvar salvarArquivo = new SalvarJson();
salvarArquivo.Compactar();  



Console.ReadKey();  
