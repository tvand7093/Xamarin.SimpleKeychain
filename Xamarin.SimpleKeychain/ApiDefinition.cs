using System;
using System.Drawing;

using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Security;

namespace Xamarin.SimpleKeychain
{
	[Protocol, BaseType (typeof (NSObject))]
	interface A0SimpleKeychain 
	{
		[Export ("service")]
		string Service { get; set; }

		[Export ("accessGroup")]
		string AccessGroup { get; set; }

		[Export ("defaultAccessiblity")]
		AOSimpleKeychainItemAccessible DefaultAccessiblity { get; set; }

		[Export ("useAccessControl")]
		bool UseAccessControl { get; set; }

		[Export ("initWithService:")]
		IntPtr Constructor(string service);

		[Export ("initWithService:withAccessGroup:")]
		IntPtr Constructor(string service, string accessGroup);

		[Export ("setString:forKey:")]
		bool SetString (string value, string key);

		[Export ("setData:forKey:")]
		bool SetData (NSData data, string key);

		[Export ("setData:forKey:promptMessage:")]
		bool SetData (NSData data, string key, string message);

		[Export ("setString:forKey:promptMessage:")]
		bool SetString (string value, string key, string message);

		[Export ("deleteEntryForKey:")]
		bool DeleteEntry (string key);

		[Export ("clearAll")]
		bool ClearAll ();

		[Export ("stringForKey:")]
		string StringForKey (string key);

		[Export ("dataForKey:")]
		NSData DataForKey (string key);

		[Export ("stringForKey:promptMessage:")]
		string StringForKey (string key, string message);

		[Export ("dataForKey:promptMessage:")]
		NSData DataForKey (string key, string message);

		[Export ("hasValueForKey:")]
		bool HasValueForKey (string key);

		[Static, Export ("keychain")]
		A0SimpleKeychain KeyChain();

		[Static, Export ("keychainWithService:")]
		A0SimpleKeychain KeyChainWithService(string service);

		[Static, Export ("keychainWithService:accessGroup:")]
		A0SimpleKeychain KeyChainWithService(string service, string accessGroup);
	}

	[Protocol, BaseType (typeof (NSObject))]
	interface A0SimpleKeychainKeyPair {

		[Export ("generateRSAKeyPairWithLength:publicKeyTag:privateKeyTag:")]
		bool GenerateKeyPair(A0SimpleKeychainRSAKeySize keyLength, string publicKey, string privateKey);

		[Export ("dataForRSAKeyWithTag:")]
		NSData DataForRSAKey (string key);

		[Export ("deleteRSAKeyWithTag:")]
		bool DeleteRSAKey (string key);

		[Export ("hasRSAKeyWithTag:")]
		bool HasRSAKey (string key);
	}
}

