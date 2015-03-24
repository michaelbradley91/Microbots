﻿using System.Windows.Controls;
using Microbots.Controllers;

namespace Microbots.Views
{
    public partial class WorldMenuView
    {
        private IWorldMenuController WorldMenuController { get; set; }

        public WorldMenuView(IWorldMenuController worldMenuController)
        {
            WorldMenuController = worldMenuController;
            InitializeComponent();
            DataContext = worldMenuController.WorldMenuViewModel;
        }
    }
}
