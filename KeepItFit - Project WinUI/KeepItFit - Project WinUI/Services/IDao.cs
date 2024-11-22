﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeepItFit___Project_WinUI.Model;

namespace KeepItFit___Project_WinUI.Services
{
    public interface IDao
    {

        public List<Nutritions> GetAllNutrtion();
        //Exercise part
        public ObservableCollection<CardioExercise> GetAllCardioExercise(string keyword);
        public ObservableCollection<StrengthTraining> GetAllStrengthTraining(string keyword);


        // SQLDao
        public ObservableCollection<Meals> GetAllMeals();
        public ObservableCollection<Food> GetFoodRecent();
        public ObservableCollection<Food> GetFoodFrequent();
        public ObservableCollection<Food> GetFoodDatabase(string keyword);
        public void UpdateRecentOrFrequentFood(Food food, string type);
        public void DeleteFrequentOrRecentFood(Food food);
        public List<Food> GetFoodForTheDay_FoodDiary(string date, string diaryType);
        public List<Food> GeQuickAddForTheDay_FoodDiary(string date, string diaryType);
        public void DeleteFoodForTheDay_FoodDiary(string date, int foodId, string diaryType);
        public void DeleteQuickAddForTheDay_FoodDiary(string date, int quickAddId, string diaryType);
        public void UpdateFoodForTheDay_FoodDiary(string date, int foodId, string foodQuantity, string diaryType);
        public void UpdateQuickAddForTheDay_FoodDiary(string date, List<int> quickAddList, string diaryType);
    }

}