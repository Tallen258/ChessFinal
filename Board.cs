using System;
using ChessFinal;
using CellBoard;

namespace ChessBoard
{
    class Board
    {
        public int currentRow = 0;
        public int currentCol = 0;

        public int Size { get; set; }

        public Cell[,] theGrid { get; set; }

        public Board(int s)
        {
            Size = s;
            theGrid = new Cell[Size, Size];

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }

            }

        }
        public void MarkNextLegalMove()
        {
            Cell currentCell = new Cell(currentRow, currentCol);
            string chessPiece = "";

            Console.WriteLine("Enter the piece:");
            try
            {
                chessPiece = Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Not valid.");
            }

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    theGrid[i, j].LegalNextMove = false;
                    theGrid[i, j].CurrentlyOccupied = false;
                }

            }
            switch (chessPiece)
            {

                case "Knight":
                    theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 2, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 2].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 2].LegalNextMove = true;
                    break;

                case "King":
                    theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 0].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 0].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber + 1].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 1, currentCell.ColumnNumber - 1].LegalNextMove = true;
                    break;

                case "Rook":
                    theGrid[currentCell.RowNumber + 7, currentCell.ColumnNumber + 0].LegalNextMove = true;
                    theGrid[currentCell.RowNumber - 7, currentCell.ColumnNumber + 0].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber + 7].LegalNextMove = true;
                    theGrid[currentCell.RowNumber + 0, currentCell.ColumnNumber - 7].LegalNextMove = true;
                    break;

                case "Bishop":
                    Console.WriteLine("Bishops can move only diagonal. Every bishop is confined to half of the board, as it can move only on its respective light or dark squares. . It cannot hop over other pieces like a knight");
                    break;

                case "Queen":
                    Console.WriteLine("The Queen can move 1-7 squares in any direction, up, down, left, right, or diagonal, until the Queen reaches an obstruction or captures a piece. It cannot jump over pieces and can only capture one piece per turn.");
                    break;

                case "Pawn":
                    Console.WriteLine("The pawn can only move forwards one step at a time, and not backwards, but when they capture the other pieces they can only do so when the opponent's piece is on a square diagonally in front of them. Each Pawn may advance two squares forward the first time it is moved");
                    break;

                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }

            for (int i = 0; i < Size; i++)
            {
                for (int j = 0; j < Size; j++)
                {
                    if (theGrid[i, j].LegalNextMove)
                    {
                        Console.WriteLine("Row " + i + " Column " + j + " is a legal move.");
                    }
                }

            }
        }


        public void setCurrentCell()
        {
            Console.WriteLine("Enter the current row number");
            try
            {
                currentRow = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Not valid.");
            }
            try
            {
                Console.WriteLine("Enter the current column number");
                currentCol = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Not valid.");
            }
            if (currentRow < 0 || currentRow > Size || currentCol < 0 || currentCol > Size)
            {
                Console.WriteLine("Out of range");
            }
            theGrid[currentRow, currentCol].CurrentlyOccupied = true;

        }

    }
}