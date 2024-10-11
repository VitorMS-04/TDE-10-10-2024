Empresa empresa = new Empresa();
Funcionario func1 = new Funcionario("Alberto", 26);
Gerente gerente = new Gerente("Rafael", 39, 2000);
Estagiario estagiario = new Estagiario("João", 17);

empresa.AdicionarFuncionario(func1);
empresa.AdicionarFuncionario(gerente);
empresa.AdicionarFuncionario(estagiario);

empresa.ListarFuncionarios();

