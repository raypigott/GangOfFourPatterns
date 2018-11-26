using System;
using System.Linq;

namespace GangOfFourPatterns.ChainOfResponsibility
{
    public static class FunctionalParser
    {
        public static Result<string> ParseText(File file)
        {
            return (file.Type == Type.Text)
                ? Result.Ok("Text file: " + file.Content)
                : Result.Fail<string>(string.Empty);
        }

        public static Result<string> ParseAudio(File file)
        {
            return file.Type == Type.Audio
                ? Result.Ok("Audio file: " + file.Content)
                : Result.Fail<string>(string.Empty);
        }

        public static Result<string> ParseVideo(File file)
        {
            return file.Type == Type.Video
                ? Result.Ok("Video file: " + file.Content)
                : Result.Fail<string>(string.Empty);
        }

        public static string Parse(File file, params Func<File, Result<string>>[] funcs)
        {
            var first = funcs.First();
            var result = first(file);
            return result.IsSuccess
                ? result.Value
                : Parse(file, funcs.Where(x => x != first).ToArray());
        }
    }
}