namespace RouterQuack.Core.ConfigFileWriters;

/// <summary>
/// Describes a config file writer for a specific router brand or type.
/// </summary>
public interface IConfigFileWriter : IStep
{
    /// <summary>
    /// Target brand to generate configs for.
    /// </summary>
    public RouterBrand Brand { get; init; }

    /// <summary>
    /// Write config files for target routers to <paramref name="outputDirectory"/>.
    /// </summary>
    /// <param name="outputDirectory">Output folder to write to. Must be existant.</param>
    /// <exception cref="DirectoryNotFoundException"><paramref name="outputDirectory"/> doesn't exist.</exception>
    public void WriteFiles(string outputDirectory);
}