using NyolcadikHet_IZ7TL4.Abstraction;
using NyolcadikHet_IZ7TL4.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NyolcadikHet_IZ7TL4
{
    public partial class Form1 : Form
    {
        private List<Toy> _toys = new List<Toy>();
        private Toy _nextToy;
        private IToyFactory _factory;
        public IToyFactory Factory 
        {
            get { return _factory; }
            set 
            { 
                _factory = value;
                DisplayNext();
            }
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void createTimer_Tick(object sender, EventArgs e)
        {
            var ball = Factory.CreateNew();
            _toys.Add(ball);
            ball.Left = -ball.Width;
            mainPanel.Controls.Add(ball);
        }

        private void conveyorTimer_Tick(object sender, EventArgs e)
        {
            var maxPosition = 0;
            foreach (var ball in _toys)
            {
                ball.MoveToy();
                if (ball.Left > maxPosition)
                    maxPosition = ball.Left;
            }

            if (maxPosition > 1000)
            {
                var oldestBall = _toys[0];
                mainPanel.Controls.Remove(oldestBall);
                _toys.Remove(oldestBall);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Factory = new CarFactory();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Factory = new BallFactory();
        }
        void DisplayNext()
        {
            if (_nextToy != null)
                mainPanel.Controls.Remove(_nextToy);
            _nextToy = Factory.CreateNew();
            _nextToy.Top = label1.Top + label1.Height + 20;
            _nextToy.Left = label1.Left;
            mainPanel.Controls.Add(_nextToy);
        }
    }
}
