namespace Defender.ServiceTemplate.Application.Helpers;

public static class ExceptionParser
{
    public static string GetValidationMessage(Exception ex)
    {
        var messageChunks = ex.Message.Split("\"").ToList();

        var detailIndex = messageChunks.IndexOf("detail");
        if (detailIndex > -1)
        {
            return messageChunks[messageChunks.IndexOf("detail") + 2];
        }

        return "Validation error occurs";
    }

}
