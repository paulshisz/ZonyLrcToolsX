using System.Collections.Generic;
using System.Threading.Tasks;
using McMaster.Extensions.CommandLineUtils;

namespace ZonyLrcTools.Cli.Commands
{
    [HelpOption("--help|-h", Description = "欢迎使用 ZonyLrcToolsX Command Line Interface。")]
    public abstract class ToolCommandBase
    {
        public abstract List<string> CreateArgs();

        protected virtual Task<int> OnExecuteAsync(CommandLineApplication app)
        {
            return Task.FromResult(0);
        }
    }
}