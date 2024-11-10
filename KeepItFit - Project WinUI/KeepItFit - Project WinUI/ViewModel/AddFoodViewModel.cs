﻿using KeepItFit___Project_WinUI.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeepItFit___Project_WinUI.ViewModel
{
    public class AddFoodViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Food> foodRecent { get; set; }
        public ObservableCollection<Food> foodFrequent { get; set; }
        public ObservableCollection<Food> foodMyFood { get; set; } //Update later -> don't understand what its function

        //private IDao sqlDao;

        public void init()
        {
            //sqlDao = new SQLDao();
            foodRecent = new ObservableCollection<Food>();
            foodFrequent = new ObservableCollection<Food>();
            LoadRecentFood();
            LoadFrequentFood();
        }

        public void LoadRecentFood()
        {
            var sqlDao = new MockDAO();
            foodRecent = sqlDao.GetFoodRecent();
        }

        public void LoadFrequentFood()
        {
            var sqlDao = new MockDAO();
            foodFrequent = sqlDao.GetFoodFrequent();
        }

        public void UpdateRecentFood(Food food)
        {
            var dao = new MockDAO();
            dao.UpdateRecentFood(food);
            LoadRecentFood();
        }

        public void UpdateFrequentFood(Food food)
        {
            var dao = new MockDAO();
            dao.UpdateFrequentFood(food);
            LoadFrequentFood();
        }

        public void DeleteFrequentOrRecentFood(Food food)
        {
            var dao = new MockDAO();
            dao.DeleteFrequentOrRecentFood(food);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
