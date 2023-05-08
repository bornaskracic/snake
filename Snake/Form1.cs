namespace Snake
{
    public partial class Form1 : Form
    {
        private Button fruit;

        public Form1()
        {
            InitializeComponent();
            SpawnFruit();

        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            MoveSnake();
        }

        private void MoveSnake()
        {
            CheckBoundaries();
            if (snake.Bounds.IntersectsWith(fruit.Bounds))
                SpawnFruit();

            // Move logic
        }

        private void CheckBoundaries()
        {
            // I'm sorry
            // So terribly sorry
            /*if (snake.Location.Y > panel1.Bounds.Bottom)
                snake.Location = new Point(snake.Location.X, panel1.Bounds.Top);
            if (snake.Location.Y < panel1.Bounds.Top)
                snake.Location = new Point(snake.Location.X, panel1.Bounds.Bottom - snake.Size.Height);
            if (snake.Location.X > panel1.Bounds.Right)
                snake.Location = new Point(panel1.Bounds.Left, snake.Location.Y);
            if (snake.Location.X < panel1.Bounds.Left)
                snake.Location = new Point(panel1.Bounds.Right + snake.Size.Width, snake.Location.Y);*/

            // TODO improve that so that it doesn't clip through the panel boundary
            snake.Location = new Point((snake.Location.X + panel1.Width) % panel1.Width, (snake.Location.Y + panel1.Height) % panel1.Height);
        }

        private void SpawnFruit()
        {
            throw new NotImplementedException();
        }
    }
}