using System;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class GlobalSettings
{
    private static void InitGlobalSettings()
    {
        // setup each one...
        
            
        var ExampleData = new GlobalSetting()
        {
            GlobalSettingId = @"rec2UsqxDo27MB0tS",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"ExampleData",
            Value = @"ExampleData",
            Description = @"A list of sample values",
            Prefix = @"SampleValues",
            GoogleKey = @"1C_awugxQh7vQx4cCKGK7YKynOEUNdvT0htLzESZqhHA",
            GID = 0
        };

        List.Add(ExampleData);
        ByEnum[GlobalSettingsEnum.ExampleData] = ExampleData;
        
            
        var Descriptions = new GlobalSetting()
        {
            GlobalSettingId = @"rec4PYXvquNHrdkEm",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"Descriptions",
            Value = @"Descriptions",
            Description = @"A list of description resources",
            Prefix = @"Description",
            GoogleKey = @"1C_awugxQh7vQx4cCKGK7YKynOEUNdvT0htLzESZqhHA",
            GID = 0
        };

        List.Add(Descriptions);
        ByEnum[GlobalSettingsEnum.Descriptions] = Descriptions;
        
            
        var ChameleonCodeHostUri = new GlobalSetting()
        {
            GlobalSettingId = @"rec6rBbwkMlBgkC7Y",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"ChameleonCodeHostUri",
            Value = @"https://eejai42.sdks.codeiverse.com/",
            Description = @"The root path to the SDK Doc Host"
        };

        List.Add(ChameleonCodeHostUri);
        ByEnum[GlobalSettingsEnum.ChameleonCodeHostUri] = ChameleonCodeHostUri;
        
            
        var Properties = new GlobalSetting()
        {
            GlobalSettingId = @"recCJ8WknVZI8eBoL",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"Properties",
            Value = @"Properties",
            Description = @"A list of attribute resource",
            Prefix = @"Attributes",
            GoogleKey = @"1C_awugxQh7vQx4cCKGK7YKynOEUNdvT0htLzESZqhHA",
            GID = 0
        };

        List.Add(Properties);
        ByEnum[GlobalSettingsEnum.Properties] = Properties;
        
            
        var BaseNamespace = new GlobalSetting()
        {
            GlobalSettingId = @"recGXKYpNkpkMIAY5",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"BaseNamespace",
            Value = @"CODEiverse.Projects.TicTacToe",
            Description = @"A reasonable base Namespace (to be used as a base namespace for code)"
        };

        List.Add(BaseNamespace);
        ByEnum[GlobalSettingsEnum.BaseNamespace] = BaseNamespace;
        
            
        var GoogleResourceList = new GlobalSetting()
        {
            GlobalSettingId = @"recO4hw3TPGZxFqSJ",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"GoogleResourceList",
            Value = @"AdditionalResources",
            Description = @"A list of additional resources",
            GoogleKey = @"1xpLGHj6wHyot9Kp2lpKTG8AcKJNMSkxjp-aTQT7yB90",
            GID = 1887184744
        };

        List.Add(GoogleResourceList);
        ByEnum[GlobalSettingsEnum.GoogleResourceList] = GoogleResourceList;
        
            
        var Language1 = new GlobalSetting()
        {
            GlobalSettingId = @"recO7Lsgh9rJLgojo",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"Language1",
            Value = @"EN",
            Description = @"The primary language",
            DefaultValue = @"EN"
        };

        List.Add(Language1);
        ByEnum[GlobalSettingsEnum.Language1] = Language1;
        
            
        var Language2 = new GlobalSetting()
        {
            GlobalSettingId = @"recOb5NWYwez7gF9t",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"Language2",
            Description = @"Additional languages",
            DefaultValue = @"NA"
        };

        List.Add(Language2);
        ByEnum[GlobalSettingsEnum.Language2] = Language2;
        
            
        var DisplayName = new GlobalSetting()
        {
            GlobalSettingId = @"recPhjZpPVPkwJsGq",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"DisplayName",
            Value = @"3x3 Tic-Tac-Toe",
            Description = @"A 'friendly' display name for the project which can be changed at any time."
        };

        List.Add(DisplayName);
        ByEnum[GlobalSettingsEnum.DisplayName] = DisplayName;
        
            
        var ChameleonCodeSDKUri = new GlobalSetting()
        {
            GlobalSettingId = @"recmBbQmUKdbqmMzk",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"ChameleonCodeSDKUri",
            Value = @"TicTacToeSDK/",
            Description = @"The relative path within the dochost",
            DefaultValue = @"ChameleonCode/",
            AssociatedLink = @"https://eejai42.sdks.codeiverse.com/TicTacToeSDK/Docs/ReadMe.html"
        };

        List.Add(ChameleonCodeSDKUri);
        ByEnum[GlobalSettingsEnum.ChameleonCodeSDKUri] = ChameleonCodeSDKUri;
        
            
        var ProjectName = new GlobalSetting()
        {
            GlobalSettingId = @"recnP7mBv8TxwPbJ3",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"ProjectName",
            Value = @"TicTacToe",
            Description = @"The name of the project"
        };

        List.Add(ProjectName);
        ByEnum[GlobalSettingsEnum.ProjectName] = ProjectName;
        
            
        var ChameleonCodeSDKPath = new GlobalSetting()
        {
            GlobalSettingId = @"recu7jbuZGXLaz6aN",
            createdTime = DateTime.Parse("2020-11-26T20:08:44Z"),
            Name = @"ChameleonCodeSDKPath",
            Value = @"TicTacToeChallenge/ChameleonCodeSDK/",
            Description = @"The physical path to the doc host folder relative to the CODEE_ROOT_PATH",
            DefaultValue = @"ChameleonCodeSDK\"
        };

        List.Add(ChameleonCodeSDKPath);
        ByEnum[GlobalSettingsEnum.ChameleonCodeSDKPath] = ChameleonCodeSDKPath;
        
    }

}