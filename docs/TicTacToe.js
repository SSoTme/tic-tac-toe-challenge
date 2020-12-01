var randomBrain = {};
randomBrain.play = function (board, availableCells) {
    var randomChoice = Math.round(Math.random() * (availableCells.length - 1));
    return availableCells[randomChoice];
}

function addCommonCode(newBoard) {

    newBoard.values = [];

    newBoard.rows = [];
    for (var y = 0; y < 3; y++) {
        var newRow = {};
        newRow.y = y;
        newRow.columns = [];
        newBoard.rows[y] = newRow;
        for (var x = 0; x < 3; x++) {
            var newCol = {};
            newCol.x = x;
            newRow.columns[x] = newCol;
        }
    }


    newBoard.aiPlayer = {
        brain: beginnerBrain
    };



    newBoard.aiPlayer.play = function () {
        var p = newBoard.aiPlayer;
        console.log('playing for ai now...');

        var availableCells = [];
        for (var i = 0; i < newBoard.cells.length; i++) {
            if (newBoard.values[i].CurrentState === newBoard.cellStates[2].Name) {
                availableCells.push(i);
            }
        }
        var playIndex = p.brain.play(newBoard, availableCells);
        newBoard.values[playIndex].CurrentState = newBoard.cellStates[1].Name;
        if (newBoard.checkForWin()) newBoard.isGameOver = true;

    }

    newBoard.autoPlay = function () {
        console.log('auto-play');
        newBoard.aiPlayer.play();
        if (newBoard.checkForWin()) {
            newBoard.isGameOver = true;
            newBoard.setStatus('GameOver');
        }
        else {
            newBoard.myTurn = !newBoard.myTurn;
        }
    }

    newBoard.click = function (row, col) {
        if (newBoard.isGameOver) return;
        else {
            var cell = newBoard.values[(row.y * 3) + col.x];
            if (cell.CurrentState === newBoard.cellStates[2].Name) {
                cell.CurrentState = newBoard.myTurn ? newBoard.cellStates[0].Name : newBoard.cellStates[1].Name;
                console.log('checking for winl...');
                if (!newBoard.checkForWin()) {
                    console.log('switching who\'s turn it is.');
                    newBoard.myTurn = !newBoard.myTurn;
                    if (!newBoard.myTurn) newBoard.autoPlay();
                } else {
                    newBoard.isGameOver = true;
                    newBoard.setStatus('GameOver');
                }
            }
        }
    }

    newBoard.setStatus = function (token) {
        newBoard.status = newBoard.languageTokens[token];
    };

    newBoard.playing = false;

    newBoard.printInfo = function (title, highlightFirst3, attributeToPrint) {
        var str = '<b>' + title + '</b><br />';
        str += '<div style="border: solid 1px black; width: 5em; text-align: center; padding: 0.5em; margin-bottom: 0.65em;">';
        for (var y = 0; y < 3; y++) {
            for (var x = 0; x < 3; x++) {
                var cell = newBoard.values[(y * 3) + x];

                if (highlightFirst3 && cell.CellIndex < 3) str += '<span style="background-color: lightgray">';
                var newValue = newBoard.cellStates[cell.CurrentState][attributeToPrint];
                str += newValue || ' ';
                if (highlightFirst3 && cell.CellIndex < 3) str += '</span>';

                str += (x < 2 ? '  ' : '');
            }
            str += '<br />';
        }

        str += '</div>';

        newBoard.addString(str);
    }

    newBoard.print = function () {
        newBoard.printInfo("Current Board", true, 'SampleValue');
    }

    newBoard.addString = function (text) {
        var html = $('#rotations').html();
        $('#rotations').html(html + text);
    }

    newBoard.showWinner = function () {
        if (!newBoard.isGameOver) return "";
        else if (newBoard.isTieGame) return newBoard.languageTokens['TieGame'];
        else if (newBoard.myTurn) return newBoard.languageTokens['YouWon'];
        else return newBoard.languageTokens['TheyWon'];
    }
}


function commonAfterLoaded(newBoard, dataLoaded) {
    newBoard.myTurn = true;
    newBoard.boardLoaded = true;

    for (var i = 0; i < 9; i++) {
        newBoard.values[i] = newBoard.cells[i];
    }

    for (var i = 0; i < newBoard.cellStates.length; i++) {
        var cellState = newBoard.cellStates[i];
        newBoard.cellStates[cellState.Name] = cellState;
    }

    for (var i = 0; i < newBoard.languageTokens.length; i++) {
        var token = newBoard.languageTokens[i];
        newBoard.languageTokens[token.Token] = token.DisplayName;
    }

    newBoard.setStatus('GameOn');

    if (dataLoaded) dataLoaded(newBoard);
}

function createBoard() {
    var newBoard = {};

    addCommonCode(newBoard);
    addDerivedCode(newBoard);

    return newBoard;
}

function getFileUrl(fileName) {
    var rootUrl = 'http://localhost:8080/json/';
    var ext = '.xml.json';
    return rootUrl + fileName + ext;
}

var filesToDownload = ['CellStates', 'Cells', 'LanguageTokens'];//, 'Translations', 'CellPatterns']

function checkAngularFile(newBoard, $scope, $http, dataLoaded) {
    var fileUrl = getFileUrl("Airtable");
    console.error('CHECKING ANGULAR FILE');
    $http.get(fileUrl)
      .success(function (data) {
          console.error('LOADED DATA', data, fileUrl);
          filesToDownload.forEach(fileName => {
            var lowerFileName = fileName.substring(0, 1).toLowerCase() + fileName.substring(1, fileName.length);
            newBoard[lowerFileName] = data.Airtable[fileName][fileName.substring(0, fileName.length - 1)];
            newBoard[lowerFileName] = newBoard[lowerFileName].sort((a, b) => {
                if (a.SortOrder > b.SortOrder) return 1;
                else if (b.SortOrder > a.SortOrder) return -1;
                else if (a.CellIndex > b.CellIndex) return 1;
                else if (b.CellIndex > a.CellIndex) return -1;
                else return 0;
            });
            console.error('PROCESSED FILE: ', fileName, newBoard[lowerFileName]);
          });
          commonAfterLoaded(newBoard, dataLoaded);
          console.error('PROCESSED LOADED: ', newBoard);
     })
      .error(function (e) {
          console.log('Error getting ' + fileName);
          console.log(e);
      });

}

function angularBoard($scope, $http, dataLoaded) {
    console.error('CREATING BOARD');
    var newBoard = $scope.newBoard = createBoard();

    checkAngularFile(newBoard, $scope, $http, dataLoaded);

    return newBoard;
}

function checkJQueryFile(newBoard, fileIndex, dataLoaded) {
    var fileUrl = getFileUrl("Airtable");
    console.error('LOADED Airtable Data');

    $.getJSON(fileUrl,
        function (data) {
            console.error('LOADED DATA', data, fileUrl);
            filesToDownload.forEach(fileName => {
              var lowerFileName = fileName.substring(0, 1).toLowerCase() + fileName.substring(1, fileName.length);
              newBoard[lowerFileName] = data.Airtable[fileName][fileName.substring(0, fileName.length - 1)];
              newBoard[lowerFileName] = newBoard[lowerFileName].sort((a, b) => {
                    if (a.SortOrder > b.SortOrder) return 1;
                    else if (b.SortOrder > a.SortOrder) return -1;
                    else if (a.CellIndex > b.CellIndex) return 1;
                    else if (b.CellIndex > a.CellIndex) return -1;
                    else return 0;
                });

            });
            commonAfterLoaded(newBoard, dataLoaded);
            console.error('PROCESSED LOADED: ', newBoard);
          });

}

function jQueryBoard(dataLoaded) {
    console.error('CREATING BOARD');
    var newBoard = createBoard();

    console.error('Check JQuery File');
    checkJQueryFile(newBoard, 0, dataLoaded);

    return newBoard;
}
