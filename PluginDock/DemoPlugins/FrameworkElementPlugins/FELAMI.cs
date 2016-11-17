﻿using System.Windows;
using PluginDock.Modeling;

namespace DemoPlugins.FrameworkElementPlugins
{
    /// <summary>The entry point into the plug-in.</summary>
    [PluginName("Framework Element Layout Anchorable Multiple Instance Demo")]
    [PluginInstanceAllowance(InstanceAllowance.Multiple)]
    [ControlWrapper(ControlWrapper.LayoutAnchorable)]
    public class FELAMI : IFrameworkElementPlugin
    {
        #region Fields
        private readonly FELAPlugin mainControl = new FELAPlugin();
        #endregion

        #region Properties
        /// <summary>Gets the display name.</summary>
        public string DisplayName => "FELA MI Demo";

        /// <summary>Gets or sets a value indicating whether or not the plug-in is closable.</summary>
        public bool IsClosable { get; set; } = true;

        /// <summary>Gets or sets a value indicating whether or not the plug-in is floatable.</summary>
        public bool IsFloatable { get; set; } = true;

        /// <summary>Gets the main control.</summary>
        public FrameworkElement MainControl => mainControl;
        #endregion

        #region Methods
        public void Initialize()
        {
            // do initialization stuff
        }

        public void Dispose()
        {
            // do clean up stuff
        }
        #endregion
    }
}