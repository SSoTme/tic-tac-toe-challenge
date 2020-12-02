using System;
using System.Collections.Generic;
using System.Linq;
using TicTacToeChallenge.Lib.DataClasses;

public static partial class AdditionalResources
{
    public static Dictionary<AdditionalResourcesEnum, AdditionalResource> ByEnum { get; }
    public static List<AdditionalResource> List { get; }
    static AdditionalResources()
    {
        AdditionalResources.ByEnum = new Dictionary<AdditionalResourcesEnum, AdditionalResource>();
        AdditionalResources.List = new List<AdditionalResource>();
        AdditionalResources.InitAdditionalResources();
    }    
}