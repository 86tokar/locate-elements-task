public class LoginPage
{
    private string GetInputById(string id) => $"input#{id}";
    // --- Sign In section ---
    public By EmailField => By.CssSelector(GetInputById("i0116"));
    public By CreateOneLink => By.CssSelector("a[href^='https://login.live.com/oauth20_authorize']");
    public By CantAccessAccountLink => By.CssSelector("a[id='cantAccessAccount']");
    public By BackButton => By.CssSelector(GetInputById("idBtn_Back"));
    public By NextButton => By.CssSelector(GetInputById("idSIButton9"));

    // --- Password section ---
    public By PasswordField => By.CssSelector("input#i0118[name='passwd']");
    public By ForgotPasswordLink => By.CssSelector("a#idA_PWD_ForgotPassword");
    public By SignInSubmitButton => By.CssSelector(GetInputById("idSIButton9"));

    
}
