namespace Plarge;

public class Program
{
    public static async Task<int> Main(string[] args) =>
        await Bootstrapper
            .Factory
            .CreateWeb(args)
            .DeployToNetlify("MySiteId",
                Config.FromSetting<string>("TOKEN_VAR"))
            .RunAsync();
}