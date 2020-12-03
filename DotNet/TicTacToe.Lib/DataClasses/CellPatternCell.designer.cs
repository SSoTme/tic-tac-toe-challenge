using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace TicTacToeChallenge.Lib.DataClasses
{                            
    public partial class CellPatternCell
    {
        private void InitPoco()
        {
            
            
                this.CellPatternCells_CellPatternsExpanded = new BindingList<CellPattern>();
            
                this.CellPatternCells_CellsExpanded = new BindingList<Cell>();
            
                this.CellPatternCells_CellStatesExpanded = new BindingList<CellState>();
            

        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPatternCellId")]
        public String CellPatternCellId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "createdTime")]
        public Nullable<DateTime> createdTime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Cell")]
        public String[] Cell { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPattern")]
        public String[] CellPattern { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellState")]
        public String[] CellState { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellIndex")]
        public Nullable<Int32> CellIndex { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellStateId")]
        public Nullable<Int32> CellStateId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellCellState")]
        public Nullable<Int32> CellCellState { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellName")]
        public String CellName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellStateName")]
        public String CellStateName { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPatternCells_CellPatternsExpanded")]
        public BindingList<CellPattern> CellPatternCells_CellPatternsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPatternCells_CellsExpanded")]
        public BindingList<Cell> CellPatternCells_CellsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPatternCells_CellStatesExpanded")]
        public BindingList<CellState> CellPatternCells_CellStatesExpanded { get; set; }
            

        
        
        private static string CreateCellPatternCellWhere(IEnumerable<CellPatternCell> cellPatternCells, String forignKeyFieldName = "CellPatternCellId")
        {
            if (!cellPatternCells.Any()) return "1=1";
            else 
            {
                var idList = cellPatternCells.Select(selectCellPatternCell => String.Format("'{0}'", selectCellPatternCell.CellPatternCellId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
