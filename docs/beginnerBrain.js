
var beginnerBrain = {};
beginnerBrain.play = function (board, availableCells) {
    // Win in the top right if it's available...
    if ((board.values[TopLeftCell].CurrentState == board.cellStates[1].Name) &&
        (board.values[TopCell].CurrentState == board.cellStates[1].Name) &&
        (board.values[TopRightCell].CurrentState == board.cellStates[2].Name)) {
        return TopRightCell;
    }
    return randomBrain.play(board, availableCells);
}                  
                  