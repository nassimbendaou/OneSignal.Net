![OneSignal Logo](https://onesignal.com/assets/common/logo_onesignal_color.png)

# OneSignal.net
OneSignal.net is a sync/async .NET 4.6.1+ client for the OneSignal API

## How to use

### Initialize OneSignal.net

```csharp
// This only has to be set once.
// Recommended to set in the constructor of the calling class
OneSignalConfiguration.SetupApiKey("ApiKey");
OneSignalConfiguration.SetAppId("AppId");

// All calls that require an app Id have an optional parameter to override what is set in the configuration
```

### Sending a notification with a template

```csharp
var notificationService = new NotificationService();

var createOptions = new CreateNotificationOptions {
   TemplateId = "TemplateId",
   IncludePlayerIds = new List<string> {
      "playerId1",
      "playerId2"
   }
};

var response = await notificationService.CreateAsync();
Console.WriteLine(response.Id);
```

### Sending a notification with content

```csharp
var notificationService = new NotificationService();

var createOptions = new CreateNotificationOptions {
   Content = new Dictionary<string, string> {
      { LanguageCode.English, "This is the content for English" }
   },
   Headings = new Dictionary<string, string> {
      { LanguageCode.English, "This is the heading for English" }
   },
   Subtitle = new Dictionary<string, string> {
      { LanguageCode.English, "This is the subtitle for English" }
   },
   IncludeExternalUserIds = new List<string> {
      "userId1",
      "userId2"
   }
};

var response = await notificationService.CreateAsync();
Console.WriteLine(response.Id);
```

### Sending a notification based on a filter

```csharp
var notificationService = new NotificationService();

var createOptions = new CreateNotificationOptions {
   TemplateId = "TemplateId",
   Filters = new List<NotificationFilter> {
      new NotificationFilterAppVersion(RelationType.GreaterThan, "1.0.0"),
      NotificationFilterOperator.AND,
      new NotificationFilterTag("registered", RelationType.EqualTo, "true")
   }
};

var response = await notificationService.CreateAsync();
Console.WriteLine(response.Id);
```

### Sending an email

```csharp
var notificationService = new NotificationService();

var createOptions = new CreateNotificationOptions {
   TemplateId = "TemplateId",
   // You can also use any other inclusion options such as player ids, external user ids, filters, segments, etc..
   IncludeEmailTokens = new List<string> {
      "emailToken1",
      "emailToken2"
   },
   EmailSubject = "Test email subject"
};

var response = await notificationService.CreateAsync();
Console.WriteLine(response.Id);
```

## OneSignal Api Oficial Documentation
[OneSignal Server API](https://documentation.onesignal.com/reference)
