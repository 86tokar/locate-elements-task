public class ToyotaMainPage
{
	private string GetNavLinkXPath(string className) => $"//button[@class = 'main-nav-link {className}']";
	private string GetActionLinkXPath(string href) => $"//a[@href = '{href}']";
	private string GetGroupLabelXPath(string text) => $"//div[@class = 'vcr-selection-group-title-text' and text() = '{text}']";
	private string GetLinkXPath(string linkText) => $"//div[@class = 'item-action']//a[contains(text(), '{linkText}')]";
    private string GetButtonXPath(string dataId) => $"(//button[@data-id = '{dataId}'])[1]";

    // --- Header ---
    public By VehiclesButton => By.XPath(GetNavLinkXPath("main-nav-link select-vehicle"));
	public By ShoppingToolsButton => By.XPath(GetNavLinkXPath("shopping-tools"));
	public By OwnersButton => By.XPath(GetNavLinkXPath("main-nav-link owners"));
	public By AccountActionButton => By.XPath("//div[@class = 'user-icon-wrap']");
	public By LogoButton => By.XPath("//a[@class = 'logo']");

	// --- Account action popup ---
	public By SignInButton => By.XPath("//div[@class = 'account-actions-container']/button[@class = 'button primary sign-in-btn']");
	public By CreateAccountButton => By.XPath("//a[@class = 'button secondary outline create-account-btn']");
	public By ViewSavesLink => By.XPath("//a[@href = 'https://www.toyota.com/saves']");
	public By ManagePaymentsLink => By.XPath("//a[@href = '/my-dashboard/payments']");
	public By ZipCodeTextBox => By.XPath("//input[@name = 'zipcode']");
	public By UpdateButton => By.XPath("//button[normalize-space()='Update']");

	// --- Vehicles drop-down options ---
	public By SpecificModelLink => By.XPath("//a[@href = '/corollacross/']");
	public By BuildSpecificModelLink => By.XPath("//a[@href = '/configurator/build/step/model/year/2026/series/corollacross/']");
	public By PriceText => By.XPath("//a[@href = '/corollacross/']//p[@class='short-description']/text()[1]");
	public By TrucksSectionButton => By.XPath("//li[@data-model-category = 'trucks']");
	public By UpcomingVehiclesSectionButton => By.XPath("//li[@data-model-category = 'upcoming-vehicle']");

    // --- Navigation menu (Specific model page) ---
    public By OverviewLink => By.XPath(GetLinkXPath("Overview"));
    public By GalleryLink => By.XPath(GetLinkXPath("Gallery"));
    public By FeaturesLink => By.XPath(GetLinkXPath("Features"));
    public By BuildLink => By.XPath("//div[@class = 'menu-item-fixed']/a[contains(@href, '/configurator/build/step/model')]");

	// --- Central content section ---
	public By DragAreaButton => By.XPath("(//button[@aria-label = 'rotate the car anti-clockwise'])[1]");
	public By BlueColorButton => By.XPath("(//button[@aria-label='Hydro Blue [extra_cost_color]'])[1]");
	public By SilverMetallicColorButton => By.XPath("(//button[@aria-label='Elemental Silver Metallic [extra_cost_color]'])[1]");
	public By ColorNameText => By.XPath("(//span[@class = 'color-selector__name disclaimer'])[1]");
	public By BuildNowLink => By.XPath("//ul[@data-aarole = 'cta-container']//a[contains(@href, '/configurator/build/step/model')]");

	// --- Footer ---
	public By ManagePreferencesLink => By.XPath("//a[@href = 'https://www.toyota.com/preferences?source=TOYOTA-COM&brand=Toyota']");
	public By YoutubeLink => By.XPath(GetActionLinkXPath("https://www.youtube.com/user/ToyotaUSA"));
	public By CareersLink => By.XPath(GetActionLinkXPath("https://careers.toyota.com/us/en/"));
	public By AboutUsLink => By.XPath("//a[@href = '/brand/']");
	public By OurCompanyLink => By.XPath("//a[@href = '/usa/']");

    // --- Navigation menu (Build page) ---
    public By ColorsNavButton => By.XPath(GetButtonXPath("color"));
    public By PowertrainNavButton => By.XPath(GetButtonXPath("powertrain"));
    public By PackagesNavButton => By.XPath(GetButtonXPath("packages"));
    public By BuildPriceValue => By.XPath("(//div[@class = 'price-wrapper']//span)[1]");

	// --- Selection section ---
	public By PowertrainGrid => By.XPath("//section[@class = 'vcr-selection-wrapper powertrain']");
	public By PackagesGrid => By.XPath("//section[@class = 'vcr-selection-wrapper packages']");
	public By EngineLabel => By.XPath(GetGroupLabelXPath("Engine"));
	public By DrivetrainLabel => By.XPath(GetGroupLabelXPath("Drivetrain"));
	public By AddPackageButton => By.XPath("//button[@class = 'select']");
	public By AccessoriesGrid => By.XPath("//div[@data-aa-content-section = 'build Accessories tab']");
	public By ProtectionGroupButton => By.XPath(GetGroupLabelXPath("Protection"));
	public By ProtectionItemDetails => By.XPath("//div[@class = 'body-03 desc']");
	public By AddProtectionItemButton => By.XPath("//button[@data-btntype = 'add']");
	public By ProtectionItemPrice => By.XPath("(//div[@class = 'vcr-selection-card vertical multiple accessory']//div[@class = 'body-03 msrp'])[1]");
	public By InventoryButton => By.XPath("//button[@class = 'build-price-button cta button secondary transparent outline dark']");

	// --- Central section (Build page) ---
	public By ModelNameText => By.XPath("//div[@class = 'selection-nav']/div[@class = 'name-container']/span");
	public By InteriorDisplayImage => By.XPath("//img[@alt = 'Exterior-display Image']");
	public By FullScreenElement => By.XPath("//div[@class = 'fullscreen-cta  exterior disclaimer']");
}