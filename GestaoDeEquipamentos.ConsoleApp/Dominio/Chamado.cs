using GestaoDeEquipamentos.ConsoleApp.Utilidades;

namespace GestaoDeEquipamentos.ConsoleApp.Dominio;

/* 

  Deve ter um identificador único (id);
• Deve ter a título do chamado;
• Deve ter a descrição do chamado;
• Deve ter um equipamento;
• Deve ter uma data de abertura;

*/

public class Chamado
{
  public int Id { get; private set; }
  public string Titulo { get; private set; }
  public string Descricao { get; private set; }
  public DateTime DataAbertura { get; private set; }
  public Equipamento Equipamento { get; private set; }

  public Chamado(string titulo, string descricao, Equipamento equipamento)
  {
    Id = GeradorIds.ObterIdChamado();

    Titulo = titulo;
    Descricao = descricao;
    Equipamento = equipamento;

    DataAbertura = DateTime.Now;
  }

  public void Atualizar(Chamado chamadoAtualizado)
  {
    Titulo = chamadoAtualizado.Titulo;
    Descricao = chamadoAtualizado.Descricao;
    Equipamento = chamadoAtualizado.Equipamento;
  }
}