using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
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
            if (x % 8 == 0&& x!=0)
            {
             i++;  
            }
            this.gameBoard[x] = (letter[i],x%8+1);
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
        for(int i = 0; i<gameBoard.Length;i++)
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
}
