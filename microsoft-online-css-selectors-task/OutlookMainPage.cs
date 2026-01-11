public class OutlookMainPage
{
    private string GetFolderByName(string name) => $"div[data-folder-name = '{name}']";
    private string GetButtonByAria(string label) => $"button[aria-label = '{label}']";

    // --- Top bar menu ---
    public By HideNavigationPaneButton => By.CssSelector(GetButtonByAria("Hide navigation pane"));
    public By HomeButton => By.CssSelector("button[id='1']");
    public By ViewTabButton => By.CssSelector(".ms-Button.root-177");
    public By HelpButton => By.CssSelector("button[aria-describedby^='ktp-'][id='11000']");

    // --- View menu bar ---
    public By ViewSettingsButton => By.CssSelector("button[id='643']");
    public By MessagesListDropDown => By.CssSelector("button[data-unique-id*='-654']");
    public By LayoutDropDown => By.CssSelector("button[data-unique-id='Ribbon-646']");
    public By DensityDropDown => By.CssSelector("button[data-unique-id='Ribbon-649']");
    public By RibbonOverflowMenu => By.CssSelector("button#RibbonOverflowMenu-overflow");

    // --- Layout section ---
    public By RibbonElement => By.CssSelector("button[name='Ribbon']");
    public By FolderPaneElement => By.CssSelector("button[aria-label*='Folder pane']");
    public By ReadingPaneIcon => By.CssSelector("i[data-icon-name='PanelLeftFocusRightFilled']");
    public By MyDayShowButton => By.CssSelector("button#Time");
    public By MyDayHideButton => By.CssSelector("button#flexPaneCloseButton");

    // --- Folders section ---
    public By InboxFolder => By.CssSelector(GetFolderByName("inbox"));
    public By DraftsFolder => By.CssSelector(GetFolderByName("drafts"));
    public By DeletedItemsFolder => By.CssSelector(GetFolderByName("deleted items"));
    public By JunkEmailFolder => By.CssSelector(GetFolderByName("junk email"));

    // --- Favorites section ---
    public By SentItemsFavorite => By.CssSelector(GetFolderByName("sent items"));
    public By AddFavoriteButton => By.CssSelector("span.fui-MenuItem__content");

    // --- Email section ---
    public By EmailSenderText => By.CssSelector("div[role='heading'] span");
    public By EmailReceiverText => By.CssSelector("div[data-testid='RecipientWell']");
    public By DateTimeText => By.CssSelector("div[data-testid='SentReceivedSavedTime']");
    public By SmileIcon => By.CssSelector("span.fui-Button__icon i.fui-Icon-font.fui-Icon-regular");
    public By InlineReplyIcon => By.CssSelector("i[data-icon-name='ArrowReplyRegular'].ms-Icon");
    public By InlineReplyAllIcon => By.CssSelector("i[data-icon-name='ArrowReplyAllRegular'].ms-Icon");
    public By MoreActionsThreeDots => By.CssSelector(GetButtonByAria("More actions"));
    public By CommandBarReplyButton => By.CssSelector("button[aria-label='Reply'].ms-Button.ms-Button--commandBar");
    public By CommandBarForwardButton => By.CssSelector(GetButtonByAria("Forward"));
    public By EmailBodyArea => By.CssSelector("table tbody");

    // --- Additional buttons ---
    public By AppLauncherNineDots => By.CssSelector(GetButtonByAria("App launcher"));
    public By MailAppIcon => By.CssSelector(GetButtonByAria("Mail"));
    public By CalendarAppIcon => By.CssSelector(GetButtonByAria("Calendar"));
    public By MoreAppsIcon => By.CssSelector(GetButtonByAria("More apps"));
    public By OutlookLogo => By.CssSelector("a[id='O365_AppName']");
    public By SearchInput => By.CssSelector("div[id='searchBoxId-Mail']");
    public By TeamsButton => By.CssSelector("button[id='O365_AppTile_SkypeTeams']");
    public By NotificationButton => By.CssSelector("button[id='owaActivityFeedButton']");