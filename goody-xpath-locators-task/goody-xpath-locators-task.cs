public class MainPage
{
	private string GetSectionXPath(string sectionTitle) => $"//a[@title = '{sectionTitle}']";
	private string GetCountryCheckboxXPath(string idSuffix) => $"//label[@for = 'CC-guidedNavigation-refinementCheckboxValue-{idSuffix}']/div[@class = 'fill']";
	private string GetCategoryXPath(string sectionTitle, string categoryTitle) => $"//a[@title = '{sectionTitle}']/following::a[@title = '{categoryTitle}']";
	private string GetFilterDropDownXPath(string filterTitle) => $"//button[contains(@class, 'button_guided_nav') and contains(text(), '{filterTitle}')]";
    private string GetRadioButtonXPath(string buttonName) => $"//label[contains(@class, 'label-radio') and contains(text(), '{buttonName}')];

    private const string ProductTable = "//*[contains(@id, 'CC-productListing')]";
    private const string ThumbnailsContainer = $"{ProductTable}//div[@class='thumbnail_wrap thumbnails']";

    // --- Header ---
    public By SearchTextBox => By.XPath("//input[@aria-label = 'Search Text']");
	public By SearchButton => By.XPath("//button[@aria-label = 'Search']");
	public By SignInButton => By.XPath("//a[@href = '/login']");
	public By CartIcon => By.XPath("//a[@id='CC-header-cart-empty']/div[@class='cart-icon']");
	public By LogoButton => By.XPath("//div[@class = 'logo']");

	// --- Section's buttons ---
	public By WineSectionButton => By.XPath(GetSectionXPath("Wine"));
	public By BeerSectionButton => By.XPath(GetSectionXPath("Beer"));
	public By LiquorSectionButton => By.XPath(GetSectionXPath("Liquor"));
	public By MixersSectionButton => By.XPath(GetSectionXPath("Mixers"));
	public By SnacksAndMoreSectionButton => By.XPath(GetSectionXPath("Snacks & More"));
	public By GiftCardsSectionButton => By.XPath(GetSectionXPath("Gift Cards"));
	public By TopPicksSectionButton => By.XPath(GetSectionXPath("Top Picks"));

    // --- Category's buttons ---
    public By RedWineCategoryButton => By.XPath(GetCategoryXPath("Wine", "Red Wine"));
    public By WhiteWineCategoryButton => By.XPath(GetCategoryXPath("Wine", "White Wine"));
    public By PorterBeerCategoryButton => By.XPath(GetCategoryXPath("Beer", "Porter"));
    public By JapanBeerCategoryButton => By.XPath($"{GetCategoryXPath("Beer", "Imported Beer")}/following::a[@title = 'Japan']");
    public By IrishWhiskeyCategoryButton => By.XPath(GetCategoryXPath("Liquor", "Irish Whiskey"));

    // --- Filter's drop-downs (Red Wine Page) ---
    public By WineTypeDropDown => By.XPath(GetFilterDropDownXPath("Wine Type"));
    public By CountryDropDown => By.XPath(GetFilterDropDownXPath("Country"));
    public By BrandDropDown => By.XPath(GetFilterDropDownXPath("Brand"));

    // --- Country drop-down details ---
    public By FranceCheckbox => By.XPath(GetCountryCheckboxXPath("2_1"));
	public By ItalyCheckbox => By.XPath(GetCountryCheckboxXPath("2_2"));
	public By SpainCheckbox => By.XPath(GetCountryCheckboxXPath("2_6"));
	public By ArgentinaCheckbox => By.XPath(GetCountryCheckboxXPath("2_4"));
	public By FilterSearchTextBox => By.XPath("//input[@id = 'searchBox-2']");

    // --- Table / Product List ---
    public By FirstProductElement => By.XPath($"{ThumbnailsContainer}/div[1]");
    public By OutOfStockProduct => By.XPath($"{ThumbnailsContainer}//p[text()='Currently out of stock']");
    public By AddToCartSpecificButton => By.XPath($"{ThumbnailsContainer}/div[1]//button[text()='Add to cart']");
    public By ProductPriceLabel => By.XPath($"{ThumbnailsContainer}//p[@class = 'bottle_price']");
    public By ProductQuantityTextBox => By.XPath($"{ThumbnailsContainer}//input[@class = 'quantity']");
    public By ProductBadge => By.XPath($"{ThumbnailsContainer}//div[contains(@class, 'prod-badge')]");

    // --- Pickup or Delivery section ---
    public By DeliveryRadioButton => By.XPath(GetRadioButtonXPath("Delivery"));
    public By InStorePickupRadioButton => By.XPath(GetRadioButtonXPath("In-Store Pickup"));

    // --- Order Summary section ---
    public By SubTotalRow => By.XPath("//div[@class = 'sub_total']");
	public By DeliverySummaryRow => By.XPath("//span[@id = 'CC-checkoutOrderSummary-shippingName']");
	public By SalesTaxRow => By.XPath("//span[@data-bind = \"widgetLocaleText:'salesTaxText'\"]");

	// --- Cart Summary section ---
	public By QuantityPlusElement => By.XPath("//section[@summary = \"Cart Summary\"]//div[text()='Quantity']");
	public By ItemTotalValue => By.XPath("//section[@summary = \"Cart Summary\"]//div[text()='Item Total']");
	public By RemoveItemIcon => By.XPath("//span[@class = 'remove-btn']/i[@class = 'fa fa-times-circle']");
	public By InStockText => By.XPath("//div[@class = 'stock_msg']");
}
