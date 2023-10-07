namespace ClassLibrary1;

public class UserInfoPresenter
{
    private readonly IUserInfo _form;

    public UserInfoPresenter(IUserInfo form)
    {
        _form = form;
        _form.SaveAttempted += _form_SaveAttempted;
    }

    private void _form_SaveAttempted(object? sender, EventArgs e)
    {
        _form.ShowFormErrors = false;
        _form.ErrorMessage = null;
        ///
        if (string.IsNullOrEmpty(_form.FirstName))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nFirst Name cannot be empty";
        }
        else if (UpperWord(_form.FirstName) != _form.FirstName)
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nThe string \"First Name\" must begin with a capital letter";
        }
        ///
        if (string.IsNullOrEmpty(_form.LastName))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nLast Name cannot be empty";
        }
        else if (UpperWord(_form.LastName) != _form.LastName)
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nThe string \"Last Name\" must begin with a capital letter";
        }
        ///
        if (string.IsNullOrEmpty(_form.Email))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nEmail cannot be empty";
        }
        else if (!_form.Email.Contains("@"))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nEmail must contain @ symbol";
        }
        ///
        if (string.IsNullOrEmpty(_form.Phone))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nPhone cannot be empty";
        }
        else if (!_form.Phone.Contains("+7") && !_form.Phone.Contains("8",0))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nEmail must contain \"+7\" or \"8\" symbol";
        }
        ///
        if (string.IsNullOrEmpty(_form.Place_of_residence))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nPlace of residence cannot be empty";
        }
        else if (!_form.Place_of_residence.Contains("Russia") && !_form.Place_of_residence.Contains("Россия"))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nPlace of residence must contain \"Russia\" or \"Россия\" Words";
        }
        ///
        if (string.IsNullOrEmpty(_form.Gender))
        {
            _form.ShowFormErrors = true;
            _form.ErrorMessage += "\nGender cannot be empty";
        }
    }

    private string UpperWord(string FormString)
    {
        string? UpperWord = FormString;
        UpperWord = UpperWord.Substring(0, 1).ToUpper() + UpperWord.Remove(0, 1).ToLower();
        return UpperWord;
    }
}