using GestaoDeEquipamentos.ConsoleApp.Dominio;

namespace GestaoDeEquipamentos.ConsoleApp.Infraestrutura;

public class RepositorioEquipamento // armazém / recipiente
{
    private Equipamento[] equipamentosSalvos = new Equipamento[100];

    public void Cadastrar(Equipamento novoEquipamento)
    {
        novoEquipamento.Id = contadorIdsEquipamentos++;

        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            if (equipamentosSalvos[i] == null)
            {
                equipamentosSalvos[i] = novoEquipamento;
                break;
            }
        }
    }

    public void Editar(int idSelecionado, Equipamento equipamentoAtualizado)
    {
        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            Equipamento equipamentoSelecionado = equipamentosSalvos[i];

            if (equipamentoSelecionado == null)
                continue;

            if (equipamentoSelecionado.Id == idSelecionado)
            {
                equipamentoSelecionado.Atualizar(equipamentoAtualizado);
                break;
            }
        }
    }

    public void Excluir(int idSelecionado)
    {
        for (int i = 0; i < equipamentosSalvos.Length; i++)
        {
            Equipamento equipamentoSelecionado = equipamentosSalvos[i];

            if (equipamentoSelecionado == null)
                continue;

            if (equipamentoSelecionado.Id == idSelecionado)
            {
                equipamentosSalvos[i] = null;
                break;
            }
        }
    }

    public Equipamento[] SelecionarTodos()
    {
        return equipamentosSalvos;
    }
}