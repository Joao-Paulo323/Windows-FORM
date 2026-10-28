# Achados e Perdidos — Formulários editáveis (Visual Studio 2022)

Abra `AchadosPerdidos.csproj` no Visual Studio 2022 (17.8+), com a carga de trabalho **Desenvolvimento para desktop com .NET**. Aguarde a restauração dos pacotes NuGet e compile (Ctrl+Shift+B).

## Formulários no Designer

No Gerenciador de Soluções, clique com o botão direito em cada arquivo `.cs` de UI e selecione **Exibir Designer** (Shift+F7):
- `LoginForm.cs` — login e primeiro administrador
- `MainForm.cs` — menu, consulta, filtros, tabela e botões
- `ItemForm.cs` — cadastro com foto
- `ReturnForm.cs` — devolução
- `LabelForm.cs` — etiqueta QR e impressão
- `UserForm.cs` — cadastro de funcionários

Todos possuem `.Designer.cs` com controles declarados individualmente. **Não altere manualmente `InitializeComponent()`**: edite os controles na interface visual.

## Banco de dados / primeiro acesso

O banco SQLite é criado automaticamente em `%LOCALAPPDATA%\AchadosPerdidos\dados.db`; as fotos ficam em `Fotos` na mesma pasta. Na primeira execução, a tela de login pede a criação do administrador. Use login e senha de no mínimo oito caracteres. Em seguida, entre com as credenciais criadas. O administrador cadastra outros funcionários na tela Funcionários.

**Atenção:** para um novo teste com banco vazio, não apague um banco com dados reais. Faça backup antes. O projeto ainda precisa de compilação e validação do Designer em Windows, não disponíveis neste ambiente.

## QR Code

O QR Code contém apenas o código do objeto. A etiqueta possui pré-visualização de impressão; o PDF pode ser obtido usando uma impressora virtual PDF instalada no Windows.
