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
            throw new NotImplementedException();
        }

        private void SpawnFruit()
        {
            throw new NotImplementedException();
        }
    }
}