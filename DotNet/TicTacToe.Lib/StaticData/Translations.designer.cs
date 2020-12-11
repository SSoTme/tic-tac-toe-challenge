using System;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class Translations
{
    private static void InitTranslations()
    {
        // setup each one...
        
            
        var Flip = new Translation()
        {
            TranslationId = @"recQ0PgyWBky0wm32",
            createdTime = DateTime.Parse("2020-11-26T20:02:48Z"),
            Name = @"Flip",
            CustomDescription = @"Flip the board along the vertical axis",
            Id = 1,
            CellPatternTranslations = new string[] { @"recwuYqQZ0iCw2WfQ" },
            Description = @"Flip the board along the vertical axis"
        };

        List.Add(Flip);
        ByEnum[TranslationsEnum.Flip] = Flip;
        
            
        var Rotate = new Translation()
        {
            TranslationId = @"recgdoYW4iJ8gaAha",
            createdTime = DateTime.Parse("2020-11-26T20:02:48Z"),
            Name = @"Rotate",
            Id = 0,
            Cells = new string[] { @"rec50MWM91QHzlEzO", "recpPYOZtnp3lTOua", "recczW2Y4WMv9buZ8", "recTGnKjXTE8LfT3C", "recxIf3GoDzEtonFU", "rec35HZOaRy6ge0jk", "recfSe8zeEdCAtcGq", "recmjtZPRUfoCU2sr", "rec3OzG8nTAkUhjVn" },
            CellPatternTranslations = new string[] { @"recD87U0swUjjhnTj", "recNz0LuN77HIXjmB", "recqJB1goFBhhsIVZ", "recJjgKw24kaBFH0i", "rec9PRnE4xpUCcMit", "reczr6h68ZUdkDIZb", "recafoRwqvCh5HZOd", "recoPtQQ8QZtClJK0", "recUD9c7vXgkNLQi9" },
            Description = @"Rotate 3x3 'board' 90 degrees LEFT-hand (Counter-Clockwise) around the middle cell"
        };

        List.Add(Rotate);
        ByEnum[TranslationsEnum.Rotate] = Rotate;
        
    }

}