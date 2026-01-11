public class MainPage
{
	private string GetSectionXPath(string title) => $"//a[@title = '{title}']";
	private string GetCountryCheckboxXPath(string idSuffix) => $"//label[@for = 'CC-guidedNavigation-refinementCheckboxValue-{idSuffix}']/div[@class = 'fill']";

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
	public By RedWineCategoryButton => By.XPath("//a[@title = 'Wine']/following::a[@title = 'Red Wine']");
	public By WhiteWineCategoryButton => By.XPath("//a[@title = 'Wine']/following::a[@title = 'White Wine']");
	public By PorterBeerCategoryButton => By.XPath("//a[@title = 'Beer']/following::a[@title = 'Porter']");
	public By JapanBeerCategoryButton => By.XPath("//a[@title = 'Beer']/following::a[@title = 'Imported Beer']/following::a[@title = 'Japan']");
	public By IrishWhiskeyCategoryButton => By.XPath("//a[@title = 'Liquor']/following::a[@title = 'Irish Whiskey']");

	// --- Filter's drop-downs (Red Wine Page) ---
	public By WineTypeDropDown => By.XPath("//button[@id = 'CC-guidedNavigation-dimensionHeader-0']");
	public By CountryDropDown => By.XPath("//button[@id = 'CC-guidedNavigation-dimensionHeader-2']");
	public By BrandDropDown => By.XPath("//button[@id = 'CC-guidedNavigation-dimensionHeader-4']");

	// --- Country drop-down details ---
	public By FranceCheckbox => By.XPath(GetCountryCheckboxXPath("2_1"));
	public By ItalyCheckbox => By.XPath(GetCountryCheckboxXPath("2_2"));
	public By SpainCheckbox => By.XPath(GetCountryCheckboxXPath("2_6"));
	public By ArgentinaCheckbox => By.XPath(GetCountryCheckboxXPath("2_4"));
	public By FilterSearchTextBox => By.XPath("//input[@id = 'searchBox-2']");

	// --- Table / Product List ---
	public By FirstProductElement => By.XPath("//div[@class='thumbnail_wrap thumbnails']/div[1]");
	public By OutOfStockProduct => By.XPath("//div[@class='thumbnail_wrap thumbnails']//p[text()='Currently out of stock']");
	public By AddToCartSpecificButton => By.XPath("//div[@class='thumbnail_wrap thumbnails']/div[1]//button[text()='Add to cart']");
	public By ProductPriceLabel => By.XPath("//div[@class='thumbnail_wrap thumbnails']//p[@class = 'bottle_price']");
	public By ProductQuantityTextBox => By.XPath("//div[@class='thumbnail_wrap thumbnails']//input[@class = 'quantity']");
	public By ProductBadge => By.XPath("//div[@class = 'prod-badge on_sale'] | //div[@class = 'prod-badge goody_direct']");

	// --- Pickup or Delivery section ---
	public By DeliveryRadioButton => By.XPath("//div[@class='custom custom_check_radio custom_radio']//label[@for = 'pdp-wi4101122-3']");
	public By InStorePickupRadioButton => By.XPath("//div[@class='custom custom_check_radio custom_radio']//label[@for = 'pdp-wi4101122-1']");

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
