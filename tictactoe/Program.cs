namespace tictactoe;

class Player {
    public string id;
    public string marker;
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to my tic tac toe game!\n");
        Console.WriteLine("Press key to continue");
        Console.ReadLine();
        Console.Clear();

        Console.WriteLine("You are player 1. You will be using X\n");
        Console.WriteLine("Press key to continue");
        Console.ReadLine();
        Console.Clear();

        string[][] gameBoard = [
            ["1", "2", "3"],
            ["4", "5", "6"],
            ["7", "8", "9"]
        ];


        Player player1 = new Player();
        player1.id = "1";
        player1.marker = "X";

        
        Player player2 = new Player();
        player2.id = "2";
        player2.marker = "O";



        Player currentPlayer = player1;
        bool gameOver = false;
        while(gameOver != true){
            Console.WriteLine("This is the board\n");
            DisplayBoard(gameBoard);

            Console.WriteLine($"\nPlayer {currentPlayer.id}. Make a move!");
            string playerChoice =  Console.ReadLine();
            MarkBoard(playerChoice, currentPlayer, gameBoard);

            Console.Clear();

            //switch the current player
            if(currentPlayer.id == "1"){
                currentPlayer = player2;
            }
            else if (currentPlayer.id == "2"){
                currentPlayer = player1;
            }
        }
        
    }

    static void DisplayBoard(string[][] board){
        for(int i = 0; i < board.Length; i++){
            string[] row = board[i];
            for(int x = 0; x < row.Length; x++){
                string value = row[x];
                Console.Write("|" + value + "|");
            }
            Console.WriteLine();
        }
    }

    static void MarkBoard(string playerChoice, Player currentPlayer, string[][] gameBoard){
            if(playerChoice == "1"){
                if(gameBoard[0][0] ==  "X" || gameBoard [0][0] == "O"){
                    throw new Exception("spot is already taken");
                }
                gameBoard[0][0] = currentPlayer.marker;
            }
            else if (playerChoice == "2"){
                if(gameBoard[0][1] ==  "X" || gameBoard [0][1] == "O"){
                    throw new Exception("spot is already taken");
                }
                gameBoard[0][1] = currentPlayer.marker;
            }
            else if (playerChoice == "3"){
                if(gameBoard[0][2] ==  "X" || gameBoard [0][2] == "O"){
                    throw new Exception("spot is already taken");
                }
                gameBoard[0][2] = currentPlayer.marker;
            }
            else if (playerChoice == "4"){
                if(gameBoard[1][0] ==  "X" || gameBoard [1][0] == "O"){
                    throw new Exception("spot is already taken");
                }
                gameBoard[1][0] = currentPlayer.marker;
            }
            else if (playerChoice == "5"){
                if(gameBoard[1][1] ==  "X" || gameBoard [1][1] == "O"){
                    throw new Exception("spot is already taken");
                }
                gameBoard[1][1] = currentPlayer.marker;
            }
            else if (playerChoice == "6"){
                if(gameBoard[1][2] ==  "X" || gameBoard [1][2] == "O"){
                    throw new Exception("spot is already taken");
                }
                gameBoard[1][2] = currentPlayer.marker;
            }
            else if (playerChoice == "7"){
                if(gameBoard[2][0] ==  "X" || gameBoard [2][0] == "O"){
                    throw new Exception("spot is already taken");
                }
                gameBoard[2][0] = currentPlayer.marker;
            }
            else if (playerChoice == "8"){
                if(gameBoard[2][1] ==  "X" || gameBoard [2][1] == "O"){
                    throw new Exception("spot is already taken");
                }
                gameBoard[2][1] = currentPlayer.marker;
            }
            else if (playerChoice == "9"){
                if(gameBoard[2][2] ==  "X" || gameBoard [2][2] == "O"){
                    throw new Exception("spot is already taken");
                }
                gameBoard[2][2] = currentPlayer.marker;
            }
    }


}
