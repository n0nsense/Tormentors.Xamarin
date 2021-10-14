using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace Tormentors
{
    public class TormentorsMainPage : ContentPage
    {
        public TormentorsMainPage()
        {

            Classes.CircularLinkedList<String> tormentorsList = new Classes.CircularLinkedList<string>();
            tormentorsList.Add("Каж Часовой");
            tormentorsList.Add("Проматиз");
            tormentorsList.Add("Часовой Шакорзет");
            tormentorsList.Add("Медиатор Раззрам");
            tormentorsList.Add("Старейшина Груукууек");
            tormentorsList.Add("Алгель Преследователь");
            tormentorsList.Add("Маллеар Гракиз");
            tormentorsList.Add("Гралебойх");
            tormentorsList.Add("Месиво душ");
            tormentorsList.Add("Воплощение боли");
            tormentorsList.Add("Верзия Проклятая");
            tormentorsList.Add("Зул'гат Cвежеватель");
            tormentorsList.Add("Голмак Чудовище");
            tormentorsList.Add("Часовой Пирофус");
            tormentorsList.Add("Мугрем пожиратель душ");

            RowDefinitionCollection rowDefinitions = new RowDefinitionCollection();
            rowDefinitions.Add(new RowDefinition {
                Height = new GridLength(1, GridUnitType.Star)
            }); //Первая строка для хэда таблицы
            foreach (var item in tormentorsList)
            {
                rowDefinitions.Add(new RowDefinition
                {
                    Height = new GridLength(1, GridUnitType.Star)
                });
            } //добавляем столько строк, сколько у нас торменторов

            Content = new Grid
            {
                RowDefinitions = rowDefinitions,
                ColumnDefinitions = {
                    new ColumnDefinition {Width = new GridLength(5, GridUnitType.Star)},
                    new ColumnDefinition(),
                    new ColumnDefinition(),
                    new ColumnDefinition()
                }
            };
        }
        
    }
}