// Copyright ?Sven Groot (Inkore.UI.WinForms.Styler.org) 2009
// BSD license; see license.txt for details.

namespace Inkore.UI.WinForms.Styler.Dialogs
{
    /// <summary>
    /// Indicates the type of progress on a task dialog.
    /// </summary>
    public enum ProgressBarStyle
    {
        /// <summary>
        /// No progress bar is displayed on the dialog.
        /// </summary>
        None,
        /// <summary>
        /// A regular progress bar is displayed on the dialog.
        /// </summary>
        ProgressBar,
        /// <summary>
        /// A marquee progress bar is displayed on the dialog. Use this value for operations
        /// that cannot report concrete progress information.
        /// </summary>
        MarqueeProgressBar
    }
}
