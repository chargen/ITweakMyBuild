﻿namespace ITweakMyBuild
{
    using System.ComponentModel.Composition;
    using System.ComponentModel.Composition.Hosting;

    using JetBrains.Annotations;

    using TomsToolbox.Wpf.Composition;

    /// <summary>
    /// Interaction logic for ToolWindowControl.
    /// </summary>
    [Export]
    public partial class ToolWindowControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ToolWindowControl"/> class.
        /// </summary>
        [ImportingConstructor]
        public ToolWindowControl([NotNull] ExportProvider exportProvider)
        {
            this.SetExportProvider(exportProvider);

            Resources.MergedDictionaries.Add(DataTemplateManager.CreateDynamicDataTemplates(exportProvider));

            InitializeComponent();
        }
    }
}