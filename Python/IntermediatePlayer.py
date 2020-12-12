def  IntermediatePlayer:    
    None
    public override Cell Play(TicTacToeBoard board)
    {
        // Play randomly for now until a Human changes this code to do something more specific
        var randomCell = board.GetRandomAvailableCell();
        Console.WriteLine("{0} player, playing at {1}", this.Name, randomCell.Name);
        return randomCell;
    }
