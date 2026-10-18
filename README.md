# ❌ Jogo da Velha em .NET MAUI ⭕

Aplicativo de Jogo da Velha desenvolvido em **.NET MAUI** com um design moderno em degradê e lógica completa de partida. Este projeto foi desenvolvido como atividade prática e aprimorado com o auxílio de inteligência artificial para otimização de código e experiência do usuário.

---

## 🎥 Vídeo Explicativo do Projeto
Assista à apresentação do projeto funcionando e à explicação detalhada de todo o código implementado:
👉 **[Clique aqui para assistir ao vídeo ](https://drive.google.com/file/d/1-pLCteKSk8TyHdPcxGph2-TuRla8dwM4/view?usp=sharing)**

---

## 🎨 Layout e Personalização (XAML)
- **Fundo com Gradiente:** Utilização de `LinearGradientBrush` combinando tons de preto e laranja.
- **Estilização de Botões:** Definição de estilo global (`Style TargetType="Button"`) com cantos arredondados (`CornerRadius="15"`), transparência, bordas brancas e fontes grandes (`FontSize="80"`).
- **Cabeçalho:** Inclusão de um `Label` estilizado como título no topo da grade (`Grid`).

---

## ⚙️ Melhorias e Lógica Implementada (C#)
Com a evolução do projeto, implementamos importantes melhorias na lógica:
1. **Controle de Turnos:** Alternância automática entre os jogadores **"X"** e **"O"** a cada jogada.
2. **Validação Completa de Vitória:** Criação de um método auxiliar (`Verifica`) otimizado que valida de forma dinâmica **todas as linhas, colunas e diagonais** do tabuleiro para ambos os jogadores.
3. **Redefinição do Tabuleiro (`Zerar()`):** Implementação da limpeza de texto (`.Text = ""`) e reativação (`.IsEnabled = true`) de todos os 9 botões simultaneamente após o término da partida, reiniciando o jogo de forma fluida.
4. **Alerta de Vitória:** Exibição de um `DisplayAlert` personalizado informando qual jogador venceu antes de reiniciar o tabuleiro.

---

