﻿using Microsoft.Extensions.Logging;
using _3010746.Data;
using _3010746.Views;

namespace _3010746
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
            builder.Logging.AddDebug();
#endif
            builder.Services.AddSingleton<TodoListPage>();
            builder.Services.AddTransient<TodoItemPage>();

            builder.Services.AddSingleton<TodoItemDatabase>();
            return builder.Build();
        }
    }
}