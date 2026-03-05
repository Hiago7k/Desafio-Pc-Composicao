using Desafio_Pc_Composicao;

Processador cpu = new Processador("Amd", "Ryzen 5 5600x");
PlacaMae mobo = new PlacaMae("Gigabyte", "Am4");
Computador pc = new Computador(cpu, mobo);

pc.ExibirConfiguracoes();