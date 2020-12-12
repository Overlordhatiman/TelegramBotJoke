using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TelegramBotJoke.Models
{
    public class AppSettings
    {
        public static string Url { get; set; } = "https://telegrambotjoke.azurewebsites.net:443/{0}";
        public static string Name { get; set; } = "IAmJoking_bot";
        public static string Key { get; set; } = "1414261579:AAG38XRgHG0AlrHGoTC68YONHorffXkgFRo";
    }
}