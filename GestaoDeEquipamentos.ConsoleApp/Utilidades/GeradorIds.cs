namespace GestaoDeEquipamentos.ConsoleApp.Utilidades;

public static class GeradorIds
{
    private static int contadorIdsEquipamentos = 1;

    public static int GerarIdEquipamento()
    {
        return contadorIdsEquipamentos++;
    }
}