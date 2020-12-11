using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace TicTacToeChallenge.Lib.DataClasses
{                            
    public partial class CellPatternTranslation
    {
        private void InitPoco()
        {
            
            
                this.Users_AILevelsExpanded = new BindingList<AILevel>();
            
                this.CellPatternTranslations_CellPatternsExpanded = new BindingList<CellPattern>();
            
                this.CellPatternTranslations_TranslationsExpanded = new BindingList<Translation>();
            

        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPatternTranslationId")]
        public String CellPatternTranslationId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "createdTime")]
        public Nullable<DateTime> createdTime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CPTCode")]
        public Nullable<Int32> CPTCode { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPattern")]
        public String[] CellPattern { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPatternName")]
        public String CellPatternName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Count")]
        public Nullable<Int32> Count { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Translation")]
        public String[] Translation { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TranslationId")]
        public Nullable<Int32> TranslationId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TranslationName")]
        public String TranslationName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SortOrder")]
        public Nullable<Int32> SortOrder { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Users_AILevelsExpanded")]
        public BindingList<AILevel> Users_AILevelsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPatternTranslations_CellPatternsExpanded")]
        public BindingList<CellPattern> CellPatternTranslations_CellPatternsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPatternTranslations_TranslationsExpanded")]
        public BindingList<Translation> CellPatternTranslations_TranslationsExpanded { get; set; }
            

        
        
        private static string CreateCellPatternTranslationWhere(IEnumerable<CellPatternTranslation> cellPatternTranslations, String forignKeyFieldName = "CellPatternTranslationId")
        {
            if (!cellPatternTranslations.Any()) return "1=1";
            else 
            {
                var idList = cellPatternTranslations.Select(selectCellPatternTranslation => String.Format("'{0}'", selectCellPatternTranslation.CellPatternTranslationId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
