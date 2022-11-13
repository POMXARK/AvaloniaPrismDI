using Avalonia;
using Avalonia.Markup.Xaml;
using AvaloniaPrismDI.Views;
using Prism.DryIoc;
using Prism.Ioc;
using System;

namespace AvaloniaPrismDI
{
    /// <summary>
    ///   Application entry point.
    ///   The methods in this file are layed out in their respective calling order
    ///   to help you learn the order of operation.
    /// </summary>
    public class App : PrismApplication
    {
        // Note:
        //  Though, Prism.WPF v8.1 uses, `protected virtual void Initialize()`
        //  Avalonia's AppBuilderBase.cs calls, `.Setup() { ... Instance.Initialize(); ... }`
        //  Therefore, we need this as a `public override void` in PrismApplicationBase.cs
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);

            // DON'T FORGET TO CALL THIS
            base.Initialize();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

            // Services
            //// containerRegistry.RegisterSingleton<ILogService, LogService>();

            // Views - Generic
            containerRegistry.Register<MainWindow>();
        }

        /// <summary>User interface entry point, called after Register and ConfigureModules.</summary>
        /// <returns>Startup View.</returns>
        protected override IAvaloniaObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
    }
}