using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Diagnostics;
using CellBoard;
using ChessBoard;

namespace ChessFinal;


public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here

        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
    

    }


    class Program
    {


        static void Main()
        {
            {
                Board myBoard = new Board(8);
                Debug.Assert(myBoard.Size == 8);
            }
            {
                Board myBoard = new Board(8);
                Debug.Assert(myBoard.theGrid[0, 0].ColumnNumber == 0);
                Debug.Assert(myBoard.theGrid[0, 0].RowNumber == 0);
            }
            {
                Board myBoard = new Board(8);
                Debug.Assert(myBoard.theGrid[3, 5].ColumnNumber == 5);
                Debug.Assert(myBoard.theGrid[3, 5].RowNumber == 3);
            }
            {
                Board myBoard = new Board(8);
                Debug.Assert(myBoard.theGrid[7, 7].ColumnNumber == 7);
                Debug.Assert(myBoard.theGrid[7, 7].RowNumber == 7);
            }
            {
                Board myBoard = new Board(8);
                Debug.Assert(myBoard.theGrid[7, 7].LegalNextMove == false);
            }


            Console.WriteLine("All tests passed.");

            {
                Board myBoard = new Board(8);


                Console.WriteLine("Do you need help?");

                string response = Console.ReadLine();

                while (response == "Yes")
                {

                    myBoard.setCurrentCell();
                    myBoard.MarkNextLegalMove();
                    Console.WriteLine("Do you need help?");
                    response = Console.ReadLine();
                }

                printBoard(myBoard);


                Console.ReadLine();
            }
            static void printBoard(Board myBoard)
            {
                for (int i = 0; i < 10; ++i)
                {
                    for (int j = 0; j < 1; ++j)
                    {
                        Console.Write(i * j + "\t");
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < myBoard.Size; i++)
                {
                    for (int j = 0; j < myBoard.Size; j++)
                    {
                        Cell c = myBoard.theGrid[i, j];

                        if (c.CurrentlyOccupied == true)
                        {
                            Console.WriteLine("X");
                        }
                        else if (c.LegalNextMove == true)
                        {
                            Console.Write("+");
                        }
                        else
                        {
                            Console.Write("Bye");
                        }
                    }

                }
            }
        }
    }

        // TODO: use this.Content to load your game content here

    protected override void Update(GameTime gameTime)
    {
        if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
            Exit();

        // TODO: Add your update logic here

        base.Update(gameTime);
    }

    protected override void Draw(GameTime gameTime)
    {
        GraphicsDevice.Clear(Color.CornflowerBlue);

        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }
}

