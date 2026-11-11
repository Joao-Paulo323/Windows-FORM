# Achados e Perdidos — Visual Studio 2022

## Abrir e editar os formulários
1. Extraia o ZIP, abra `AchadosPerdidos.csproj` no Visual Studio 2022 (17.8+).
2. Instale a carga de trabalho **Desenvolvimento para desktop com .NET**.
3. No **Gerenciador de Soluções**, expanda `UI`.
4. Clique com o botão direito em `LoginForm.cs`, `ItemForm.cs` ou `ReturnForm.cs` e escolha **Exibir Designer** (Shift+F7).
5. O código dos controles está nos respectivos `.Designer.cs`; a lógica dos eventos está nos `.cs`.
6. **Atenção:** `MainForm.cs` e `LabelForm.cs` ainda são telas criadas por código; não estão totalmente editáveis no Designer nesta versão. A tela de gerenciamento de funcionários também é dinâmica.

## Login e banco de dados: passo a passo
1. Pressione **F5**. Na primeira execução, o programa chama `Database.Initialize()` em `Program.cs`.
2. O SQLite cria automaticamente `%LOCALAPPDATA%\AchadosPerdidos\dados.db` e a pasta `Fotos`.
3. A tela de login verifica `Database.HasUsers()`. Se não houver usuários, aparecerá **Criar administrador**.
4. Informe um login e uma senha com pelo menos 8 caracteres e clique em **Criar administrador**.
5. Faça login usando os mesmos dados. O método `Database.Authenticate()` valida a senha no SQLite.
6. Na tela principal, um administrador pode escolher **Funcionários** e cadastrar outros usuários.
7. As senhas são guardadas com PBKDF2-SHA256, salt individual e 210.000 iterações; nunca em texto simples.
8. Para inspecionar o banco, instale **DB Browser for SQLite**, abra `dados.db` e consulte `Usuarios` e `Itens`.
9. Para backup, feche o programa e copie toda a pasta `%LOCALAPPDATA%\AchadosPerdidos` (incluindo fotos). Não compartilhe o banco com usuários sem autorização.
10. Para migrar futuramente a vários computadores, substitua a camada `Data/Database.cs` por uma API/banco centralizado; **não** compartilhe o arquivo SQLite por pasta de rede.

## Testes recomendados
- Primeiro acesso e criação do administrador.
- Senha incorreta bloqueia entrada.
- Login correto abre a tela principal.
- Cadastro gera número único, foto otimizada e QR Code.
- Devolução muda status e preserva histórico.

## Observações
- Projeto de desenvolvimento; não foi compilado no Windows neste ambiente.
- O QR Code representa o código interno do objeto, não um link público.
- Não há acesso de alunos ao programa.
