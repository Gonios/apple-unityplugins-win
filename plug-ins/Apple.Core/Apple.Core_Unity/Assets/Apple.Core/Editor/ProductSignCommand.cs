#if UNITY_EDITOR_OSX || (UNITY_EDITOR && UNITY_IOS)

namespace Apple.Core
{
    public class ProductSignCommand
    {
        public int Run(string codeSigningIdentifier, string unsignedPKGPath, string signedOutputPKGPath)
        {
            var command = $"productsign --sign {codeSigningIdentifier} {unsignedPKGPath} {signedOutputPKGPath}";

            return ShellCommandRunner.Run(command);
        }
    }
}
#endif