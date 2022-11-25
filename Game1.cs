using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
namespace ChessFinal;

public class Game1 : Game
{
    private GraphicsDeviceManager _graphics;
    private SpriteBatch _spriteBatch;

    private (string, int)[] gameBoard = new (string, int)[64];
    private Texture2D boardimage;

    private void createBoard()
    {
        string[] letter = new string[] { "a", "b", "c", "d", "e", "f", "g", "h" };
        int i = 0;
        for (int x = 0; x < gameBoard.Length; x++)
        {
            if (x % 8 == 0 && x != 0)
            {
                i++;
            }
            this.gameBoard[x] = (letter[i], x % 8 + 1);
        }
    }
    public Game1()
    {
        _graphics = new GraphicsDeviceManager(this);
        Content.RootDirectory = "Content";
        IsMouseVisible = true;
    }

    protected override void Initialize()
    {
        // TODO: Add your initialization logic here
        createBoard();
        for (int i = 0; i < gameBoard.Length; i++)
            Console.WriteLine(gameBoard[i]);
        base.Initialize();
    }

    protected override void LoadContent()
    {
        _spriteBatch = new SpriteBatch(GraphicsDevice);
        this.boardimage = Content.Load<Texture2D>("board_plain_04");
        // TODO: use this.Content to load your game content here
    }

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
        _spriteBatch.Begin();
        _spriteBatch.Draw(boardimage, new Vector2(0, 0), Color.White);
        _spriteBatch.End();
        // TODO: Add your drawing code here

        base.Draw(gameTime);
    }

    List<Tuple<int, int, string>> Whitepieces = new List<Tuple<int, int, string>>{
    Tuple.Create(1,1,"Pawn1"),
    Tuple.Create(2,1, "Pawn2"),
    Tuple.Create(3,1, "Pawn3"),
   Tuple.Create( 4,1,"Pawn4"),
   Tuple.Create(4,1,"Pawn4"),
   Tuple.Create(5,1,"Pawn5"),
   Tuple.Create(6,1,"Pawn6"),
   Tuple.Create(7,1, "Pawn8"),
   Tuple.Create(8,1, "Pawn8"),
   Tuple.Create(3,0,"Bishop1"),
   Tuple.Create(6,0,"Bishop2"),
   Tuple.Create(1,0,"Rook1"),
   Tuple.Create(8,0,"Rook2"),
   Tuple.Create(2,0,"Knight1"),
   Tuple.Create(5,0,"Queen"),
   Tuple.Create(4,0,"King"),
    };


    List<Tuple<int, int, string>> Blackpieces = new List<Tuple<int, int, string>>{

    Tuple.Create(1,7,"Pawn1"),
    Tuple.Create(2,7, "Pawn2"),
    Tuple.Create(3,7, "Pawn3"),
   Tuple.Create( 4,7,"Pawn4"),
   Tuple.Create(4,7,"Pawn4"),
   Tuple.Create(5,7,"Pawn5"),
   Tuple.Create(6,7,"Pawn6"),
   Tuple.Create(7,7, "Pawn8"),
   Tuple.Create(8,7, "Pawn8"),
   Tuple.Create(3,8,"Bishop1"),
   Tuple.Create(6,8,"Bishop2"),
   Tuple.Create(1,8,"Rook1"),
   Tuple.Create(8,8,"Rook2"),
   Tuple.Create(2,8,"Knight1"),
   Tuple.Create(5,8,"Queen"),
   Tuple.Create(4,8,"King"),
    };
    void pawnMovements((int, int, string) peice, (int, int) nextMove)
{
       // switch(nextMove){
       // case (peice.Item1, peice.Item2+1):

       // break;
        //case: (int, int) valid1 = (peice.Item1 + 1, peice.Item2 + 1);
//break;
    //default:
   // break;
            (int, int) valid2 = (peice.Item1 + 1, peice.Item2 - 1);
            //if is a valid move change the peice to the next move location
       
        }
        
        void BishopMvements((int, int, string) peice)
        {
            (int, int) valid = (peice.Item1 + 1, peice.Item2 + 1);
            (int, int) valid1 = (peice.Item1 + 2, peice.Item2 + 2);
            (int, int) valid2 = (peice.Item1 + 3, peice.Item2 + 3);
            (int, int) valid3 = (peice.Item1 + 4, peice.Item2 + 4);
            (int, int) valid4 = (peice.Item1 + 5, peice.Item2 + 5);
            (int, int) valid5 = (peice.Item1 + 6, peice.Item2 + 6);
            (int, int) valid6 = (peice.Item1 + 7, peice.Item2 + 7);
            (int, int) valid7 = (peice.Item1 + 8, peice.Item2 + 8);
            (int, int) valid8 = (peice.Item1 - 1, peice.Item2 - 1);
            (int, int) valid9 = (peice.Item1 - 2, peice.Item2 - 2);
            (int, int) valid10 = (peice.Item1 - 3, peice.Item2 - 3);
            (int, int) valid11 = (peice.Item1 - 4, peice.Item2 - 4);
            (int, int) valid12 = (peice.Item1 - 5, peice.Item2 - 5);
            (int, int) valid13 = (peice.Item1 - 6, peice.Item2 - 6);
            (int, int) valid14 = (peice.Item1 - 7, peice.Item2 - 7);
            (int, int) valid15 = (peice.Item1 - 8, peice.Item2 - 8);

        }

        void RookMvements((int, int, string) piece)
{
            (int, int) valid1 = (piece.Item1 + 1, piece.Item2);
            (int, int) valid2 = (piece.Item1 + 2, piece.Item2);
            (int, int) valid3 = (piece.Item1 + 3, piece.Item2);
            (int, int) valid4 = (piece.Item1 + 4, piece.Item2);
            (int, int) valid5 = (piece.Item1 + 5, piece.Item2);
            (int, int) valid6 = (piece.Item1 + 6, piece.Item2);
            (int, int) valid7 = (piece.Item1 + 7, piece.Item2);
            (int, int) valid8 = (piece.Item1 + 8, piece.Item2);
            (int, int) valid9 = (piece.Item1 - 1, piece.Item2);
            (int, int) valid10 = (piece.Item1 - 2, piece.Item2);
            (int, int) valid11 = (piece.Item1 - 3, piece.Item2);
            (int, int) valid12 = (piece.Item1 - 4, piece.Item2);
            (int, int) valid13 = (piece.Item1 - 5, piece.Item2);
            (int, int) valid14 = (piece.Item1 - 6, piece.Item2);
            (int, int) valid15 = (piece.Item1 - 7, piece.Item2);
            (int, int) valid16 = (piece.Item1 - 8, piece.Item2);
            (int, int) valid17 = (piece.Item1, piece.Item2 + 1);
            (int, int) valid18 = (piece.Item1, piece.Item2 + 2);
            (int, int) valid19 = (piece.Item1, piece.Item2 + 3);
            (int, int) valid20 = (piece.Item1, piece.Item2 + 4);
            (int, int) valid21 = (piece.Item1, piece.Item2 + 5);
            (int, int) valid22 = (piece.Item1, piece.Item2 + 6);
            (int, int) valid23 = (piece.Item1, piece.Item2 + 7);
            (int, int) valid24 = (piece.Item1, piece.Item2 + 8);
            (int, int) valid25 = (piece.Item1, piece.Item2 - 1);
            (int, int) valid26 = (piece.Item1, piece.Item2 - 2);
            (int, int) valid27 = (piece.Item1, piece.Item2 - 3);
            (int, int) valid28 = (piece.Item1, piece.Item2 - 4);
            (int, int) valid29 = (piece.Item1, piece.Item2 - 5);
            (int, int) valid30 = (piece.Item1, piece.Item2 - 6);
            (int, int) valid31 = (piece.Item1, piece.Item2 - 7);
            (int, int) valid32 = (piece.Item1, piece.Item2 - 8);

}
            void knightMovements((int, int, string) piece)
            {
                (int, int) valid1 = (piece.Item1 + 1, piece.Item2 + 2);
                (int, int) valid2 = (piece.Item1 + 1, piece.Item2 - 2);
                (int, int) valid3 = (piece.Item1 - 1, piece.Item2 + 2);
                (int, int) valid4 = (piece.Item1 - 1, piece.Item2 - 2);
                (int, int) valid5 = (piece.Item1 + 2, piece.Item2 + 1);
                (int, int) valid6 = (piece.Item1 + 2, piece.Item2 - 1);
                (int, int) valid7 = (piece.Item1 - 2, piece.Item2 + 1);
                (int, int) valid8 = (piece.Item1 - 2, piece.Item2 - 1);


            }

            void KingMovements((int, int, string) piece)
            {
                (int, int) valid1 = (piece.Item1 + 1, piece.Item2);
                (int, int) valid2 = (piece.Item1 + 1, piece.Item2 + 1);
                (int, int) valid3 = (piece.Item1 + 1, piece.Item2 - 1);
                (int, int) valid4 = (piece.Item1 - 1, piece.Item2);
                (int, int) valid5 = (piece.Item1 - 1, piece.Item2 + 1);
                (int, int) valid6 = (piece.Item1 - 1, piece.Item2 - 1);
                (int, int) valid7 = (piece.Item1, piece.Item2 - 1);
                (int, int) valid8 = (piece.Item1, piece.Item2 + 1);

            }

            void QueenMovements((int, int, string) piece)
            {
                (int, int) valid = (piece.Item1 + 1, piece.Item2 + 1);
                (int, int) valid1 = (piece.Item1 + 2, piece.Item2 + 2);
                (int, int) valid2 = (piece.Item1 + 3, piece.Item2 + 3);
                (int, int) valid3 = (piece.Item1 + 4, piece.Item2 + 4);
                (int, int) valid4 = (piece.Item1 + 5, piece.Item2 + 5);
                (int, int) valid5 = (piece.Item1 + 6, piece.Item2 + 6);
                (int, int) valid6 = (piece.Item1 + 7, piece.Item2 + 7);
                (int, int) valid7 = (piece.Item1 + 8, piece.Item2 + 8);
                (int, int) valid8 = (piece.Item1 - 1, piece.Item2 - 1);
                (int, int) valid9 = (piece.Item1 - 2, piece.Item2 - 2);
                (int, int) valid10 = (piece.Item1 - 3, piece.Item2 - 3);
                (int, int) valid11 = (piece.Item1 - 4, piece.Item2 - 4);
                (int, int) valid12 = (piece.Item1 - 5, piece.Item2 - 5);
                (int, int) valid13 = (piece.Item1 - 6, piece.Item2 - 6);
                (int, int) valid14 = (piece.Item1 - 7, piece.Item2 - 7);
                (int, int) valid15 = (piece.Item1 - 8, piece.Item2 - 8);
                (int, int) valid16 = (piece.Item1 + 1, piece.Item2);
                (int, int) valid17 = (piece.Item1 + 2, piece.Item2);
                (int, int) valid18 = (piece.Item1 + 3, piece.Item2);
                (int, int) valid19 = (piece.Item1 + 4, piece.Item2);
                (int, int) valid20 = (piece.Item1 + 5, piece.Item2);
                (int, int) valid21 = (piece.Item1 + 6, piece.Item2);
                (int, int) valid22 = (piece.Item1 + 7, piece.Item2);
                (int, int) valid23 = (piece.Item1 + 8, piece.Item2);
                (int, int) valid24 = (piece.Item1 - 1, piece.Item2);
                (int, int) valid25 = (piece.Item1 - 2, piece.Item2);
                (int, int) valid26 = (piece.Item1 - 3, piece.Item2);
                (int, int) valid27 = (piece.Item1 - 4, piece.Item2);
                (int, int) valid28 = (piece.Item1 - 5, piece.Item2);
                (int, int) valid29 = (piece.Item1 - 6, piece.Item2);
                (int, int) valid30 = (piece.Item1 - 7, piece.Item2);
                (int, int) valid31 = (piece.Item1 - 8, piece.Item2);
                (int, int) valid32 = (piece.Item1, piece.Item2 + 1);
                (int, int) valid33 = (piece.Item1, piece.Item2 + 2);
                (int, int) valid34 = (piece.Item1, piece.Item2 + 3);
                (int, int) valid35 = (piece.Item1, piece.Item2 + 4);
                (int, int) valid36 = (piece.Item1, piece.Item2 + 5);
                (int, int) valid37 = (piece.Item1, piece.Item2 + 6);
                (int, int) valid38 = (piece.Item1, piece.Item2 + 7);
                (int, int) valid39 = (piece.Item1, piece.Item2 + 8);
                (int, int) valid40 = (piece.Item1, piece.Item2 - 1);
                (int, int) valid41 = (piece.Item1, piece.Item2 - 2);
                (int, int) valid42 = (piece.Item1, piece.Item2 - 3);
                (int, int) valid43 = (piece.Item1, piece.Item2 - 4);
                (int, int) valid44 = (piece.Item1, piece.Item2 - 5);
                (int, int) valid45 = (piece.Item1, piece.Item2 - 6);
                (int, int) valid46 = (piece.Item1, piece.Item2 - 7);
                (int, int) valid47 = (piece.Item1, piece.Item2 - 8);
            }
}