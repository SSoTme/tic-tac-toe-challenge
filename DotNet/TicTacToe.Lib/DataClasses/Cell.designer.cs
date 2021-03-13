using System;
using System.ComponentModel;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using CoreLibrary.Extensions;

namespace TicTacToeChallenge.Lib.DataClasses
{                            
    public partial class Cell
    {
        private void InitPoco()
        {
            
            
                this.TargetCell_CellPatternsExpanded = new BindingList<CellPattern>();
            
                this.CellPatternCellCells_CellPatternsExpanded = new BindingList<CellPattern>();
            
                this.CellPatternCellsExpanded = new BindingList<CellPatternCell>();
            
                this.Clockwise_CellsExpanded = new BindingList<Cell>();
            
                this.CounterClockwise_CellsExpanded = new BindingList<Cell>();
            
                this.Flip_CellsExpanded = new BindingList<Cell>();
            
                this.Cells_TranslationsExpanded = new BindingList<Translation>();
            
                this.CurrentStateCells_CellStatesExpanded = new BindingList<CellState>();
            
                this.DefaultStateCells_CellStatesExpanded = new BindingList<CellState>();
            

        }
        
        partial void AfterGet();
        partial void BeforeInsert();
        partial void AfterInsert();
        partial void BeforeUpdate();
        partial void AfterUpdate();

        

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellId")]
        public String CellId { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "createdTime")]
        public Nullable<DateTime> createdTime { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Name")]
        public String Name { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Clockwise")]
        public String[] Clockwise { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CounterClockwise")]
        public String[] CounterClockwise { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Flip")]
        public String[] Flip { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SampleValue")]
        public String SampleValue { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Description")]
        public String Description { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "X")]
        public Nullable<Int32> X { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Y")]
        public Nullable<Int32> Y { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RotateTranslation")]
        public String[] RotateTranslation { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellIndex")]
        public Nullable<Int32> CellIndex { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPatternCells")]
        public String[] CellPatternCells { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TargetCellForCellPatterns")]
        public String[] TargetCellForCellPatterns { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CurrentCellState")]
        public String[] CurrentCellState { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultCellState")]
        public String[] DefaultCellState { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellKey")]
        public Nullable<Int32> CellKey { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsDailyDouble")]
        public Nullable<Boolean> IsDailyDouble { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "AlexesNumber")]
        public Nullable<Int32> AlexesNumber { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsClockwise")]
        public Nullable<Boolean> IsClockwise { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ClockwiseRotateFrom")]
        public String ClockwiseRotateFrom { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CounterClockwiseRotateFrom")]
        public String CounterClockwiseRotateFrom { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RotateFrom")]
        public String RotateFrom { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RotateDescription")]
        public String RotateDescription { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "ClockwiseRotateFromIndex")]
        public Nullable<Int32> ClockwiseRotateFromIndex { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CounterClockwiseRotateFromIndex")]
        public Nullable<Int32> CounterClockwiseRotateFromIndex { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "RotateIndex")]
        public Nullable<Int32> RotateIndex { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultState")]
        public String DefaultState { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CurrentState")]
        public String CurrentState { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FlipIndex")]
        public Nullable<Int32> FlipIndex { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FlipFromName")]
        public String FlipFromName { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "FlipDescription")]
        public String FlipDescription { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "SortOrder")]
        public Nullable<Int32> SortOrder { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "NamedSetPatterns")]
        public String[] NamedSetPatterns { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsInRow1")]
        public Nullable<Int32> IsInRow1 { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsInRow2")]
        public Nullable<Int32> IsInRow2 { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsInRow3")]
        public Nullable<Int32> IsInRow3 { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsInColumn1")]
        public Nullable<Int32> IsInColumn1 { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsInColumn2")]
        public Nullable<Int32> IsInColumn2 { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsInColumn3")]
        public Nullable<Int32> IsInColumn3 { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsInLeftRightDiagonal")]
        public Nullable<Int32> IsInLeftRightDiagonal { get; set; }
    
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "IsInRightLeftDiagonal")]
        public Nullable<Int32> IsInRightLeftDiagonal { get; set; }
    

        
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "TargetCell_CellPatternsExpanded")]
        public BindingList<CellPattern> TargetCell_CellPatternsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPatternCellCells_CellPatternsExpanded")]
        public BindingList<CellPattern> CellPatternCellCells_CellPatternsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CellPatternCellsExpanded")]
        public BindingList<CellPatternCell> CellPatternCellsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Clockwise_CellsExpanded")]
        public BindingList<Cell> Clockwise_CellsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CounterClockwise_CellsExpanded")]
        public BindingList<Cell> CounterClockwise_CellsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Flip_CellsExpanded")]
        public BindingList<Cell> Flip_CellsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "Cells_TranslationsExpanded")]
        public BindingList<Translation> Cells_TranslationsExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "CurrentStateCells_CellStatesExpanded")]
        public BindingList<CellState> CurrentStateCells_CellStatesExpanded { get; set; }
            
        [JsonProperty(DefaultValueHandling = DefaultValueHandling.IgnoreAndPopulate, PropertyName = "DefaultStateCells_CellStatesExpanded")]
        public BindingList<CellState> DefaultStateCells_CellStatesExpanded { get; set; }
            

        
        
        private static string CreateCellWhere(IEnumerable<Cell> cells, String forignKeyFieldName = "CellId")
        {
            if (!cells.Any()) return "1=1";
            else 
            {
                var idList = cells.Select(selectCell => String.Format("'{0}'", selectCell.CellId));
                var csIdList = String.Join(",", idList);
                return String.Format("{0} in ({1})", forignKeyFieldName, csIdList);
            }
        }
        
    }
}
