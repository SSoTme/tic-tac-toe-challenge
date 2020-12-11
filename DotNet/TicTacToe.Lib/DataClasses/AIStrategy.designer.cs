using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace TicTacToeChallenge.Lib.DataClasses
{                            
    public partial class AIStrategy
    {
        private void InitPoco()
        {
            
            
                this.AIStrategies_AILevelsExpanded = new BindingList<AILevel>();
            

        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AIStrategyId")]
        public String AIStrategyId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "createdTime")]
        public Nullable<DateTime> createdTime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "PlayerLevel")]
        public Nullable<Int16> PlayerLevel { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsDefensive")]
        public Nullable<Boolean> IsDefensive { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "StrategyRank")]
        public Nullable<Int32> StrategyRank { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SortOrder")]
        public Nullable<Int32> SortOrder { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AILevels")]
        public String[] AILevels { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AILevelNames")]
        public String AILevelNames { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AIStrategies_AILevelsExpanded")]
        public BindingList<AILevel> AIStrategies_AILevelsExpanded { get; set; }
            

        
        
        private static string CreateAIStrategyWhere(IEnumerable<AIStrategy> aIStrategies, String forignKeyFieldName = "AIStrategyId")
        {
            if (!aIStrategies.Any()) return "1=1";
            else 
            {
                var idList = aIStrategies.Select(selectAIStrategy => String.Format("'{0}'", selectAIStrategy.AIStrategyId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
