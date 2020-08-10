using ConsoleClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Application : IApplication
    {
        IReadInput _readInput;
        IPrintOutput _printOutput;
        IWorkSpace _workSpace;
        IStringConstraint _stringConstraint;
        IMapString _mapString;
        ISortString _sortString;
        IValidation _validation;

        public Application
           (IReadInput readInput,
            IPrintOutput printOutput,
            IWorkSpace workSpace,
            IStringConstraint stringConstraint,
            IMapString mapString,
            ISortString sortString,
            IValidation validation)
        {
            _readInput = readInput;
            _printOutput = printOutput;
            _workSpace = workSpace;
            _stringConstraint = stringConstraint;
            _mapString = mapString;
            _sortString = sortString;
            _validation = validation;

        }
        public void Run()
        {
            do
            {
                bool isValid;
                string input;

                do
                {
                    _workSpace.ClearConsole();
                    _printOutput.Message("Input:");
                    input = _readInput.StringValue();
                    isValid = _validation.ValidateString(input);
                    if (!isValid)
                    {
                        _printOutput.MessageEnd("Input not valid! Only letters are allowed. Press any key to continue...");
                    }

                } while (!isValid);

                string noPAnctuationInput = _stringConstraint.IgnorePanctuation(input);
                string lowerCaseInput = _mapString.ToLowerCase(noPAnctuationInput);
                string sortedString = _sortString.Ascending(lowerCaseInput);

                _printOutput.Message("Output:");
                _printOutput.Message(sortedString.Trim());
                _printOutput.Message("\nPress \"Enter\" to exit or any other key to proceed...");
                
            } while (Console.ReadKey().Key != ConsoleKey.Enter);
        }
    }
}
