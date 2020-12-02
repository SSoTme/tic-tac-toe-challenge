using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace TicTacToeChallenge.Lib.DataClasses
{                            
    public partial class CellPattern
    {
        private void InitPoco()
        {
            
            
                this.CellPatternTranslationsExpanded = new BindingList<CellPatternTranslation>();
            
                this.CellPatternCellsExpanded = new BindingList<CellPatternCell>();
            
                this.CellPatterns_CellsExpanded = new BindingList<Cell>();
            
                this.CellPatterns_CellStatesExpanded = new BindingList<CellState>();
            

        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPatternId")]
        public String CellPatternId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "createdTime")]
        public Nullable<DateTime> createdTime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsWinPattern")]
        public Nullable<Boolean> IsWinPattern { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPatternCells")]
        public String[] CellPatternCells { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPatternTranslations")]
        public String[] CellPatternTranslations { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TargetCell")]
        public String[] TargetCell { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TargetCellState")]
        public String[] TargetCellState { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SortOrder")]
        public Nullable<Int32> SortOrder { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TargetCellIndex")]
        public Nullable<Int32> TargetCellIndex { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TargetCellStateId")]
        public Nullable<Int32> TargetCellStateId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPatternTranslationCodes")]
        public Int32[] CellPatternTranslationCodes { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Cells")]
        public String Cells { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPatternCellStates")]
        public Int32[] CellPatternCellStates { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Target")]
        public Nullable<Int32> Target { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Translations")]
        public String Translations { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPatternTranslationsExpanded")]
        public BindingList<CellPatternTranslation> CellPatternTranslationsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPatternCellsExpanded")]
        public BindingList<CellPatternCell> CellPatternCellsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPatterns_CellsExpanded")]
        public BindingList<Cell> CellPatterns_CellsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPatterns_CellStatesExpanded")]
        public BindingList<CellState> CellPatterns_CellStatesExpanded { get; set; }
            

        
        
        private static string CreateCellPatternWhere(IEnumerable<CellPattern> cellPatterns, String forignKeyFieldName = "CellPatternId")
        {
            if (!cellPatterns.Any()) return "1=1";
            else 
            {
                var idList = cellPatterns.Select(selectCellPattern => String.Format("'{0}'", selectCellPattern.CellPatternId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
