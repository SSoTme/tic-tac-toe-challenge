
// ***************************************************************************************************
//
// AUTO GENERATED - DO NOT CHANGE
// Created By: EJ Alexandra (2016)
//
// ***************************************************************************************************

// ***************************************************************************************************
// Constants for the relationship between the name and cellIndex of the cell in the cells array.
// ***************************************************************************************************
var TopLeftCell = 0;
var TopCell = 1;
var TopRightCell = 2;
var MiddleLeftCell = 3;
var MiddleCell = 4;
var MiddleRightCell = 5;
var BottomLeftCell = 6;
var BottomCell = 7;
var BottomRightCell = 8;


// ***************************************************************************************************
// This function adds board translations to a javascript representation of the 3x3 TicTacToe board.
// ***************************************************************************************************
function addDerivedCode(newBoard) {
    // ***************************************************************************************************
    // TRANSLATION FUNCTION: 
    // Rotate
    // Description: 
    // Rotate 3x3 "board" 90 degrees RIGHT-hand (Clockwise) around the middle cell
    // ***************************************************************************************************
    newBoard.rotate = function () {
        var tempValues = [];
        var b = this;
        
        tempValues[TopLeftCell] = b.values[BottomLeftCell];  // MOVE BottomLeft to the TopLeft
        tempValues[TopCell] = b.values[MiddleLeftCell];  // MOVE MiddleLeft to the Top
        tempValues[TopRightCell] = b.values[TopLeftCell];  // MOVE TopLeft to the TopRight
        tempValues[MiddleLeftCell] = b.values[BottomCell];  // MOVE Bottom to the MiddleLeft
        tempValues[MiddleRightCell] = b.values[TopCell];  // MOVE Top to the MiddleRight
        tempValues[BottomLeftCell] = b.values[BottomRightCell];  // MOVE BottomRight to the BottomLeft
        tempValues[BottomCell] = b.values[MiddleRightCell];  // MOVE MiddleRight to the Bottom
        tempValues[BottomRightCell] = b.values[TopRightCell];  // MOVE TopRight to the BottomRight
        for (var i = 0; i < 9; i++) {
            if (tempValues[i]) b.values[i] = tempValues[i];
        }
    };

                            
    // ***************************************************************************************************
    // TRANSLATION FUNCTION: 
    // Flip
    // Description: 
    // Flip the board along the vertical axis
    // ***************************************************************************************************
    newBoard.flip = function () {
        var tempValues = [];
        var b = this;
        
        tempValues[TopLeftCell] = b.values[TopRightCell];  // MOVE TopRight to the TopLeft
        tempValues[TopRightCell] = b.values[TopLeftCell];  // MOVE TopLeft to the TopRight
        tempValues[MiddleLeftCell] = b.values[MiddleRightCell];  // MOVE MiddleRight to the MiddleLeft
        tempValues[MiddleRightCell] = b.values[MiddleLeftCell];  // MOVE MiddleLeft to the MiddleRight
        tempValues[BottomLeftCell] = b.values[BottomRightCell];  // MOVE BottomRight to the BottomLeft
        tempValues[BottomRightCell] = b.values[BottomLeftCell];  // MOVE BottomLeft to the BottomRight
        for (var i = 0; i < 9; i++) {
            if (tempValues[i]) b.values[i] = tempValues[i];
        }
    };

                            

    newBoard.checkEdgeWinStep = function (testBoard, cellStateToFind) {
        
        if ((testBoard.values[TopLeftCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[TopCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[TopRightCell].CurrentState !== cellStateToFind)) return false;
        else return true;
    }
    

    newBoard.checkRow3Step = function (testBoard, cellStateToFind) {
        
        if ((testBoard.values[BottomLeftCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[BottomCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[BottomRightCell].CurrentState !== cellStateToFind)) return false;
        else return true;
    }
    

    newBoard.checkColumn1Step = function (testBoard, cellStateToFind) {
        
        if ((testBoard.values[TopLeftCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[MiddleLeftCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[BottomLeftCell].CurrentState !== cellStateToFind)) return false;
        else return true;
    }
    

    newBoard.checkColumn3Step = function (testBoard, cellStateToFind) {
        
        if ((testBoard.values[TopRightCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[MiddleRightCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[BottomRightCell].CurrentState !== cellStateToFind)) return false;
        else return true;
    }
    

    newBoard.checkRightLeftDiagonalStep = function (testBoard, cellStateToFind) {
        
        if ((testBoard.values[TopRightCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[MiddleCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[BottomLeftCell].CurrentState !== cellStateToFind)) return false;
        else return true;
    }
    

    newBoard.checkColumn2Step = function (testBoard, cellStateToFind) {
        
        if ((testBoard.values[TopCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[MiddleCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[BottomCell].CurrentState !== cellStateToFind)) return false;
        else return true;
    }
    

    newBoard.checkRow1Step = function (testBoard, cellStateToFind) {
        
        if ((testBoard.values[TopLeftCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[TopCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[TopRightCell].CurrentState !== cellStateToFind)) return false;
        else return true;
    }
    

    newBoard.checkLeftRightDiagonalStep = function (testBoard, cellStateToFind) {
        
        if ((testBoard.values[TopLeftCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[MiddleCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[BottomRightCell].CurrentState !== cellStateToFind)) return false;
        else return true;
    }
    

    newBoard.checkMiddleWinStep = function (testBoard, cellStateToFind) {
        
        if ((testBoard.values[MiddleLeftCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[MiddleCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[MiddleRightCell].CurrentState !== cellStateToFind)) return false;
        else return true;
    }
    

    newBoard.checkRow2Step = function (testBoard, cellStateToFind) {
        
        if ((testBoard.values[MiddleLeftCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[MiddleCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[MiddleRightCell].CurrentState !== cellStateToFind)) return false;
        else return true;
    }
    

    newBoard.checkDiagonalWinStep = function (testBoard, cellStateToFind) {
        
        if ((testBoard.values[TopLeftCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[MiddleCell].CurrentState !== cellStateToFind)) return false;
        else if ((testBoard.values[BottomRightCell].CurrentState !== cellStateToFind)) return false;
        else return true;
    }
    
    newBoard.checkEdgeWin = function () {
        var testBoard = this;
        var cellStateToFind = testBoard.cellStates[testBoard.myTurn ? 0 : 1].Name;
        
        // Check for a match...
        if (testBoard.checkEdgeWinStep(testBoard, cellStateToFind)) return true;
        // Rotate the test board to try another test...
        testBoard.rotate();
        // Check for a match...
        if (testBoard.checkEdgeWinStep(testBoard, cellStateToFind)) return true;
        // Rotate the test board to try another test...
        testBoard.rotate();
        // Check for a match...
        if (testBoard.checkEdgeWinStep(testBoard, cellStateToFind)) return true;
        // Rotate the test board to try another test...
        testBoard.rotate();
        // Check for a match...
        if (testBoard.checkEdgeWinStep(testBoard, cellStateToFind)) return true;
        return false;
    }
    
    newBoard.checkRow3 = function () {
        var testBoard = this;
        var cellStateToFind = testBoard.cellStates[testBoard.myTurn ? 0 : 1].Name;
        
        // Check for a match...
        if (testBoard.checkRow3Step(testBoard, cellStateToFind)) return true;
        return false;
    }
    
    newBoard.checkColumn1 = function () {
        var testBoard = this;
        var cellStateToFind = testBoard.cellStates[testBoard.myTurn ? 0 : 1].Name;
        
        // Check for a match...
        if (testBoard.checkColumn1Step(testBoard, cellStateToFind)) return true;
        return false;
    }
    
    newBoard.checkColumn3 = function () {
        var testBoard = this;
        var cellStateToFind = testBoard.cellStates[testBoard.myTurn ? 0 : 1].Name;
        
        // Check for a match...
        if (testBoard.checkColumn3Step(testBoard, cellStateToFind)) return true;
        return false;
    }
    
    newBoard.checkRightLeftDiagonal = function () {
        var testBoard = this;
        var cellStateToFind = testBoard.cellStates[testBoard.myTurn ? 0 : 1].Name;
        
        // Check for a match...
        if (testBoard.checkRightLeftDiagonalStep(testBoard, cellStateToFind)) return true;
        return false;
    }
    
    newBoard.checkColumn2 = function () {
        var testBoard = this;
        var cellStateToFind = testBoard.cellStates[testBoard.myTurn ? 0 : 1].Name;
        
        // Check for a match...
        if (testBoard.checkColumn2Step(testBoard, cellStateToFind)) return true;
        return false;
    }
    
    newBoard.checkRow1 = function () {
        var testBoard = this;
        var cellStateToFind = testBoard.cellStates[testBoard.myTurn ? 0 : 1].Name;
        
        // Check for a match...
        if (testBoard.checkRow1Step(testBoard, cellStateToFind)) return true;
        return false;
    }
    
    newBoard.checkLeftRightDiagonal = function () {
        var testBoard = this;
        var cellStateToFind = testBoard.cellStates[testBoard.myTurn ? 0 : 1].Name;
        
        // Check for a match...
        if (testBoard.checkLeftRightDiagonalStep(testBoard, cellStateToFind)) return true;
        return false;
    }
    
    newBoard.checkMiddleWin = function () {
        var testBoard = this;
        var cellStateToFind = testBoard.cellStates[testBoard.myTurn ? 0 : 1].Name;
        
        // Check for a match...
        if (testBoard.checkMiddleWinStep(testBoard, cellStateToFind)) return true;
        // Rotate the test board to try another test...
        testBoard.rotate();
        // Check for a match...
        if (testBoard.checkMiddleWinStep(testBoard, cellStateToFind)) return true;
        return false;
    }
    
    newBoard.checkRow2 = function () {
        var testBoard = this;
        var cellStateToFind = testBoard.cellStates[testBoard.myTurn ? 0 : 1].Name;
        
        // Check for a match...
        if (testBoard.checkRow2Step(testBoard, cellStateToFind)) return true;
        return false;
    }
    
    newBoard.checkDiagonalWin = function () {
        var testBoard = this;
        var cellStateToFind = testBoard.cellStates[testBoard.myTurn ? 0 : 1].Name;
        
        // Check for a match...
        if (testBoard.checkDiagonalWinStep(testBoard, cellStateToFind)) return true;
        // Flip the test board to try another test...
        testBoard.flip();
        // Check for a match...
        if (testBoard.checkDiagonalWinStep(testBoard, cellStateToFind)) return true;
        return false;
    }
    

    newBoard.checkForWin = function () {
        console.log(newBoard);
        var testBoard = jQuery.extend(true, {}, newBoard);

        if (testBoard.checkEdgeWin()) return true;
        else if (testBoard.checkRow3()) return true;
        else if (testBoard.checkColumn1()) return true;
        else if (testBoard.checkColumn3()) return true;
        else if (testBoard.checkRightLeftDiagonal()) return true;
        else if (testBoard.checkColumn2()) return true;
        else if (testBoard.checkRow1()) return true;
        else if (testBoard.checkLeftRightDiagonal()) return true;
        else if (testBoard.checkMiddleWin()) return true;
        else if (testBoard.checkRow2()) return true;
        else if (testBoard.checkDiagonalWin()) return true;
        
        else return false;
    }
}

