using Microsoft.OpenApi;

namespace PetMatch.OpenApi;

public static class PetMatchOpenApi
{
    public const string DocumentName = "v1";
    public static OpenApiInfo CreateInfo()
    {
        return new OpenApiInfo
        {
            Title = "PetMatch API",
            Version = "v1",
            Description = "Contrato HTTP do PetMatch para consulta de pets, manifestações de interesse e respostas padronizadas."
        };
    }
}