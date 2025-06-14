using server.Models;

public class Repositorio {
    public Jogo JogoAtual { get; private set; }

    public Repositorio(){}

    public Jogo CriarJogo(string nome, string modo, string nivel, int tamanho){
        JogoAtual = new Jogo(nome, modo, nivel, tamanho);
        return JogoAtual;
    }

    public Estado ProcessarHumano(int pos){
        return JogoAtual.AbrirCartaHumano(pos);
    }

    public Estado VerificarJogadaHumano(){
        return JogoAtual.ProcessarJogadaHumano();
    }
}