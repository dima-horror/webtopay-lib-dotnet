# What is paysera-bank-client?
WebToPay Lib DotNet is a library that will allow you to make payment requests to the Paysera website.

# .NET Standard 2.0




## Code samples
Before making a request you are to create an instance of the Client class.
```c#
int projectId = 0;
string signPassword = "32_character_sign_password";
Client client = new Client(projectId, signPassword);
```
Be sure to replace *projectId* and *signPassword* placeholder values with the actual data.

After creating the client object you can now create a new Micro/Macro request
```c#
public MacroRequest NewMacroRequest();
public MicroAnswer NewMicroAnswer();
```

After creating a new request, it is important that you specify the request parameters
```c#
string siteUrl = Request.Url.GetLeftPart(UriPartial.Authority);

request.OrderId = "ORDER0001";
request.Amount = 1000;
request.Currency = "LTL";
request.Country = "LT";
request.AcceptUrl = siteUrl + "/Accept.aspx";
request.CancelUrl = siteUrl + "/Cancel.aspx";
request.CallbackUrl = siteUrl + "/MacroCallback.aspx";
```

You can additionally set the ```request.Test = true;``` if you wish to test the request.

Once the request has been built, you may build the request URL and redirect your client
```c#
string redirectUrl = client.BuildRequestUrl(request);
Response.Redirect(redirectUrl);
```