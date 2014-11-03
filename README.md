Xamarin.SimpleKeychain
======================

A Xamarin Binding wrapper for the Auth0 native SimpleKeychain library.

##Key Features

- **Simple interface** to store user's credentials (e.g. JWT) in the Keychain.
- Store credentials under an **Access Group to enable Keychain Sharing**.
- Support for **iOS 8 Access Control** for fine grained access control. _(Only for iOS 8+)_
- **TouchID and Keychain integration** with iOS 8 new accesibility field `kSecAttrAccessibleWhenPasscodeSetThisDeviceOnly`. _(Only for iOS 8+)_

## Usage

```csharp
string message = "Please enter your passcode/fingerprint to login with awesome App!.";
A0SimpleKeychain keychain = A0SimpleKeychain.KeyChain();
string jwt = keychain.stringForKey("auth0-user-jwt", message);
```

## Requirements

At least iOS 7, if you want to use `kSecAttrAccessControl` with the flag `useAccessControl` you need to have iOS 8+.

## Installation

Simply download the .dll file inside the Release folder and reference it in your project.

##A0SimpleKeychain

###Save a JWT token or password

```csharp
string jwt = //user's JWT token obtained after login
A0SimpleKeychain.KeyChain().SetString(jwt, "auth0-user-jwt");
```

###Obtain a JWT token or password

```csharp
string jwt = A0SimpleKeychain.KeyChain().StringForKey("auth0-user-jwt");
```

###Share JWT Token with other apps using iOS Access Group

```csharp
string jwt = //user's JWT token obtained after login
A0SimpleKeychain keychain = A0SimpleKeychain.KeyChainWithService("Auth0", "ABCDEFGH.com.mydomain.myaccessgroup");
keychain.SetString(jwt, "auth0-user-jwt");
```

###Store and retrieve JWT token using TouchID and Keychain AcessControl attribute (iOS 8 Only).

Let's save the JWT first:
```csharp
string jwt = //user's JWT token obtained after login
A0SimpleKeychain keychain = A0SimpleKeychain.KeyChain();
keychain.useAcessControl = YES;
keychain.DefaultAccesiblity = AOSimpleKeychainItemAccessible
.A0SimpleKeychainItemAccessibleWhenPasscodeSetThisDeviceOnly
keychain.SetString(jwt, "auth0-user-jwt");
```

>If there is an existent value under the key `auth0-user-jwt` saved with AccessControl and `A0SimpleKeychainItemAccessibleWhenPasscodeSetThisDeviceOnly`, iOS will prompt the user to enter their passcode or fingerprint before updating the value.

Then let's obtain the value
```csharp
string message = "Please enter your passcode/fingerprint to login with awesome App!.";
A0SimpleKeychain keychain = A0SimpleKeychain.KeyChain();
string jwt = keychain.StringForKey("auth0-user-jwt", message);
```

###Remove a JWT token or password
```csharp
A0SimpleKeychain.KeyChain().DeleteEntry("auth0-user-jwt");
```

## License

SimpleKeychain is available under the MIT license. See the [LICENSE file]([LICENSE file](https://github.com/auth0/SimpleKeychain/blob/master/LICENSE)) for more info.

## Author

SimpleKeychain Library - [Auth0](https://auth0.com)
Xamarin Binding - Tyler Vanderhoef
