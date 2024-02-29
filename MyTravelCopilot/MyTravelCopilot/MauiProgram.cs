﻿using MyTravelCopilot.Repositories.Login;
using MyTravelCopilot.Repositories.Signup;
using MyTravelCopilot.Repositories.Spent;

namespace MyTravelCopilot;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkit()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		builder.Services.AddTransient<MainViewModel>();
		builder.Services.AddTransient<LoginViewModel>();
		builder.Services.AddTransient<SignupViewModel>();

		builder.Services.AddTransient<MainPage>();
		builder.Services.AddTransient<LoginPage>();
		builder.Services.AddTransient<SignupPage>();

		builder.Services.AddScoped<ILoginRepository, LoginRepository>();
		builder.Services.AddScoped<ISignupRepository, SignupRepository>();
		builder.Services.AddScoped<ISpentRepository, SpentRepository>();

		return builder.Build();
	}
}
