using TesteEdinaldo.Application.DTOs;

namespace TesteEdinaldo.Application.Interfaces
{
    public interface ITranslator
    {
        string this[string name]
        {
            get;
        }

        string GetString(string name);
        string GetString(TranslatorMessageDto input);
    }
}
