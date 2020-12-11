using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace TicTacToeChallenge.Lib.DataClasses
{                            
    public partial class AILevel
    {
        private void InitPoco()
        {
            
            
                this.AILevels_AIStrategiesExpanded = new BindingList<AIStrategy>();
            

        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AILevelId")]
        public String AILevelId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "createdTime")]
        public Nullable<DateTime> createdTime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PlayerType")]
        public String PlayerType { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "MinAILevelIndex")]
        public Nullable<Int16> MinAILevelIndex { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AILevelIndex")]
        public Nullable<Int16> AILevelIndex { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SortOrder")]
        public Nullable<Int16> SortOrder { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Users")]
        public String[] Users { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AIStrategies")]
        public String[] AIStrategies { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AIStrategyNames")]
        public String AIStrategyNames { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AILevels_AIStrategiesExpanded")]
        public BindingList<AIStrategy> AILevels_AIStrategiesExpanded { get; set; }
            

        
        
        private static string CreateAILevelWhere(IEnumerable<AILevel> aILevels, String forignKeyFieldName = "AILevelId")
        {
            if (!aILevels.Any()) return "1=1";
            else 
            {
                var idList = aILevels.Select(selectAILevel => String.Format("'{0}'", selectAILevel.AILevelId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
