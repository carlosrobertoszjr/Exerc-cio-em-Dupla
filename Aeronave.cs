using System;

class Aeronave {
  public string NomeAeronave;
  public int CapCombustivel;
  public int NivelCombustivelAtual;
  public int QtdPassageiros; 
  public int AutonomiaAeronave;
  public int HorasDeVoo;
  private string NomePiloto;
  private string AeroportoAtual;
  
  int Abastecer;
  public int AbastecerAeronave(){
    if (NivelCombustivelAtual < CapCombustivel){
      Abastecer = CapCombustivel - NivelCombustivelAtual; // Quantos litros abasteceu
      NivelCombustivelAtual = CapCombustivel; // Atualiza o nível de combustível atual
    }return Abastecer;
  }
  

    public int Voar(int distancia){
      if (distancia <= HorasDeVoo){
        HorasDeVoo+= distancia;
      } return HorasDeVoo; 
    }


    //SET
    public void SetAlterarAeroporto(string novo_aero){
      AeroportoAtual = novo_aero;
    }

    public void SetNome(string novo_nome){
      NomePiloto = novo_nome;
    }

    //GET
    public string GetAlterarAeroporto(){
      return AeroportoAtual;
    }

    public string GetNome(){
      return NomePiloto;
    }

    public Aeronave (){
    } 
    

    public Aeronave (string na, int cc, int nc, int qtdP, int autA, int hv, string np, string aa){
      NomeAeronave = na;
      CapCombustivel = cc;
      NivelCombustivelAtual = nc;
      QtdPassageiros = qtdP;
      AutonomiaAeronave = autA;
      HorasDeVoo = hv;
      NomePiloto = np;
      AeroportoAtual = aa;
    }

}

