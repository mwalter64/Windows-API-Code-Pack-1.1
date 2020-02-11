//Copyright (c) Microsoft Corporation.  All rights reserved.

using System;

namespace Microsoft.WindowsAPICodePack.Controls
{
    /// <summary>
    /// Indicates the content options of the explorer browser. Typically use one, or a bitwise combination of these flags to specify how
    /// conent should appear in the explorer browser control
    /// </summary>
    [Flags]
    public enum ExplorerBrowserContentSectionOptions
    {
        /// <summary>No options.</summary>
        None = 0,

        /// <summary>The view should be left-aligned.</summary>
        AlignLeft = 0x00000800,

        /// <summary>Automatically arrange the elements in the view.</summary>
        AutoArrange = 0x00000001,

        /// <summary>Turns on check mode for the view</summary>
        CheckSelect = 0x08000000,

        /// <summary>When the view is set to "Tile" the layout of a single item should be extended to the width of the view.</summary>
        ExtendedTiles = 0x02000000,

        /// <summary>When an item is selected, the item and all its sub-items are highlighted.</summary>
        FullRowSelect = 0x00200000,

        /// <summary>The view should not display file names</summary>
        HideFileNames = 0x00020000,

        /// <summary>The view should not save view state in the browser.</summary>
        NoBrowserViewState = 0x10000000,

        /// <summary>Do not display a column header in the view in any view mode.</summary>
        NoColumnHeader = 0x00800000,

        /// <summary>Only show the column header in details view mode.</summary>
        NoHeaderInAllViews = 0x01000000,

        /// <summary>The view should not display icons.</summary>
        NoIcons = 0x00001000,

        /// <summary>Do not show subfolders.</summary>
        NoSubfolders = 0x00000080,

        /// <summary>Navigate with a single click</summary>
        SingleClickActivate = 0x00008000,

        /// <summary>Do not allow more than a single item to be selected.</summary>
        SingleSelection = 0x00000040,
    }

    /// <summary>
    /// Specifies the options that control subsequent navigation. Typically use one, or a bitwise combination of these flags to specify how
    /// the explorer browser navigates.
    /// </summary>
    [Flags]
    public enum ExplorerBrowserNavigateOptions
    {
        /// <summary>
        /// Do not navigate further than the initial navigation.
        /// </summary>
        NavigateOnce = 0x00000001,

        /// <summary>
        /// Use the following standard panes: Commands Module pane, Navigation pane, Details pane, and Preview pane.
        /// An implementer of IExplorerPaneVisibility can modify the components of the Commands Module that are shown.
        /// For more information see, IExplorerPaneVisibility::GetPaneState. If EBO_SHOWFRAMES is not set, 
        /// Explorer browser uses a single view object.
        /// </summary>
        ShowFrames = 0x00000002,

        /// <summary>
        /// Always navigate, even if you are attempting to navigate to the current folder.
        /// </summary>
        AlwaysNavigate = 0x00000004,

        /// <summary>
        /// Do not update the travel log.
        /// </summary>
        NoTravelLog = 0x00000008,

        /// <summary>
        /// Do not use a wrapper window. This flag is used with legacy clients that need the browser parented directly on themselves.
        /// </summary>
        NoWrapperWindow = 0x00000010,

        /// <summary>
        /// Show WebView for sharepoint sites.
        /// </summary>
        HtmlSharePointView = 0x00000020,

        /// <summary>
        /// Introduced in Windows Vista. Do not draw a border around the browser window.
        /// </summary>
        NoBorder = 0x00000040,

        /// <summary>
        /// Introduced in Windows Vista. Do not persist the view state.
        /// </summary>
        NoPersistViewState = 0x00000080,
    }

    /// <summary>Indicates the viewing mode of the explorer browser</summary>
    public enum ExplorerBrowserViewMode
    {
        /// <summary>Choose the best view mode for the folder</summary>
        Auto = -1,

        /// <summary>(New for Windows7)</summary>
        Content = 8,

        /// <summary>Object names and other selected information, such as the size or date last updated, are shown.</summary>
        Details = 4,

        /// <summary>The view should display medium-size icons.</summary>
        Icon = 1,

        /// <summary>Object names are displayed in a list view.</summary>
        List = 3,

        /// <summary>The view should display small icons.</summary>
        SmallIcon = 2,

        /// <summary>The view should display thumbnail icons.</summary>
        Thumbnail = 5,

        /// <summary>The view should display icons in a filmstrip format.</summary>
        ThumbStrip = 7,

        /// <summary>The view should display large icons.</summary>
        Tile = 6
    }

    /// <summary>Indicates the visibility state of an ExplorerBrowser pane</summary>
    public enum PaneVisibilityState
    {
        /// <summary>
        /// Do not make any modifications to the pane.
        /// </summary>
        DoNotCare = 0x0000,

        /// <summary>
        /// Set the default state of the pane to "on", but respect any user-modified persisted state.
        /// </summary>
        DefaultOn = 0x0001,

        /// <summary>
        /// Set the default state of the pane to "off".
        /// </summary>
        DefaultOff = 0x0002,

        /// <summary>
        /// Unused
        /// </summary>
        StateMask = 0xFFFF,

        /// <summary>
        /// Ignore any persisted state from the user, but the user can still modify the state.
        /// </summary>
        InitialState = 0x00010000,

        /// <summary>
        /// Users cannot modify the state, that is, they do not have the ability to show or hide the given pane. This option implies EPS_INITIALSTATE.
        /// </summary>
        Force = 0x00020000,

    }
}