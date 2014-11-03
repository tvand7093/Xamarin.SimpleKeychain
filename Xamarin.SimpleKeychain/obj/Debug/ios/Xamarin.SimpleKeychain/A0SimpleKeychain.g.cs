//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using MonoTouch.UIKit;
using MonoTouch.GLKit;
using MonoTouch.MapKit;
using MonoTouch.Security;
using MonoTouch.SceneKit;
using MonoTouch.CoreVideo;
using MonoTouch.CoreMedia;
using MonoTouch.QuickLook;
using MonoTouch.Foundation;
using MonoTouch.CoreMotion;
using MonoTouch.ObjCRuntime;
using MonoTouch.AddressBook;
using MonoTouch.CoreGraphics;
using MonoTouch.CoreLocation;
using MonoTouch.NewsstandKit;
using MonoTouch.AVFoundation;
using MonoTouch.CoreAnimation;
using MonoTouch.CoreFoundation;

namespace Xamarin.SimpleKeychain {
	[Protocol (Name = "A0SimpleKeychain", WrapperType = typeof (A0SimpleKeychainWrapper))]
	public interface IA0SimpleKeychain : INativeObject, IDisposable
	{
	}
	
	public static partial class A0SimpleKeychain_Extensions {
		[CompilerGenerated]
		public static bool SetString (this IA0SimpleKeychain This, string value, string key)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nsvalue = NSString.CreateNative (value);
			var nskey = NSString.CreateNative (key);
			
			bool ret;
			ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("setString:forKey:"), nsvalue, nskey);
			NSString.ReleaseNative (nsvalue);
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static bool SetData (this IA0SimpleKeychain This, NSData data, string key)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			bool ret;
			ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("setData:forKey:"), data.Handle, nskey);
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static bool SetData (this IA0SimpleKeychain This, NSData data, string key, string message)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (key == null)
				throw new ArgumentNullException ("key");
			if (message == null)
				throw new ArgumentNullException ("message");
			var nskey = NSString.CreateNative (key);
			var nsmessage = NSString.CreateNative (message);
			
			bool ret;
			ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("setData:forKey:promptMessage:"), data.Handle, nskey, nsmessage);
			NSString.ReleaseNative (nskey);
			NSString.ReleaseNative (nsmessage);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static bool SetString (this IA0SimpleKeychain This, string value, string key, string message)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (key == null)
				throw new ArgumentNullException ("key");
			if (message == null)
				throw new ArgumentNullException ("message");
			var nsvalue = NSString.CreateNative (value);
			var nskey = NSString.CreateNative (key);
			var nsmessage = NSString.CreateNative (message);
			
			bool ret;
			ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("setString:forKey:promptMessage:"), nsvalue, nskey, nsmessage);
			NSString.ReleaseNative (nsvalue);
			NSString.ReleaseNative (nskey);
			NSString.ReleaseNative (nsmessage);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static bool DeleteEntry (this IA0SimpleKeychain This, string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			bool ret;
			ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("deleteEntryForKey:"), nskey);
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static bool ClearAll (this IA0SimpleKeychain This)
		{
			return ApiDefinition.Messaging.bool_objc_msgSend (This.Handle, Selector.GetHandle ("clearAll"));
		}
		
		[CompilerGenerated]
		public static string StringForKey (this IA0SimpleKeychain This, string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			string ret;
			ret = NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("stringForKey:"), nskey));
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static NSData DataForKey (this IA0SimpleKeychain This, string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("dataForKey:"), nskey));
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static string StringForKey (this IA0SimpleKeychain This, string key, string message)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (message == null)
				throw new ArgumentNullException ("message");
			var nskey = NSString.CreateNative (key);
			var nsmessage = NSString.CreateNative (message);
			
			string ret;
			ret = NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("stringForKey:promptMessage:"), nskey, nsmessage));
			NSString.ReleaseNative (nskey);
			NSString.ReleaseNative (nsmessage);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static NSData DataForKey (this IA0SimpleKeychain This, string key, string message)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (message == null)
				throw new ArgumentNullException ("message");
			var nskey = NSString.CreateNative (key);
			var nsmessage = NSString.CreateNative (message);
			
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("dataForKey:promptMessage:"), nskey, nsmessage));
			NSString.ReleaseNative (nskey);
			NSString.ReleaseNative (nsmessage);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static bool HasValueForKey (this IA0SimpleKeychain This, string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			bool ret;
			ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("hasValueForKey:"), nskey);
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
	}
	
	internal sealed class A0SimpleKeychainWrapper : BaseWrapper, IA0SimpleKeychain {
		public A0SimpleKeychainWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public A0SimpleKeychainWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace Xamarin.SimpleKeychain {
	[Protocol]
	[Register("A0SimpleKeychain", true)]
	public unsafe partial class A0SimpleKeychain : NSObject, IA0SimpleKeychain {
		[CompilerGenerated]
		const string selAccessGroup = "accessGroup";
		static readonly IntPtr selAccessGroupHandle = Selector.GetHandle ("accessGroup");
		[CompilerGenerated]
		const string selClearAll = "clearAll";
		static readonly IntPtr selClearAllHandle = Selector.GetHandle ("clearAll");
		[CompilerGenerated]
		const string selDataForKey_ = "dataForKey:";
		static readonly IntPtr selDataForKey_Handle = Selector.GetHandle ("dataForKey:");
		[CompilerGenerated]
		const string selDataForKeyPromptMessage_ = "dataForKey:promptMessage:";
		static readonly IntPtr selDataForKeyPromptMessage_Handle = Selector.GetHandle ("dataForKey:promptMessage:");
		[CompilerGenerated]
		const string selDefaultAccessiblity = "defaultAccessiblity";
		static readonly IntPtr selDefaultAccessiblityHandle = Selector.GetHandle ("defaultAccessiblity");
		[CompilerGenerated]
		const string selDeleteEntryForKey_ = "deleteEntryForKey:";
		static readonly IntPtr selDeleteEntryForKey_Handle = Selector.GetHandle ("deleteEntryForKey:");
		[CompilerGenerated]
		const string selHasValueForKey_ = "hasValueForKey:";
		static readonly IntPtr selHasValueForKey_Handle = Selector.GetHandle ("hasValueForKey:");
		[CompilerGenerated]
		const string selInitWithService_ = "initWithService:";
		static readonly IntPtr selInitWithService_Handle = Selector.GetHandle ("initWithService:");
		[CompilerGenerated]
		const string selInitWithServiceWithAccessGroup_ = "initWithService:withAccessGroup:";
		static readonly IntPtr selInitWithServiceWithAccessGroup_Handle = Selector.GetHandle ("initWithService:withAccessGroup:");
		[CompilerGenerated]
		const string selKeychain = "keychain";
		static readonly IntPtr selKeychainHandle = Selector.GetHandle ("keychain");
		[CompilerGenerated]
		const string selKeychainWithService_ = "keychainWithService:";
		static readonly IntPtr selKeychainWithService_Handle = Selector.GetHandle ("keychainWithService:");
		[CompilerGenerated]
		const string selKeychainWithServiceAccessGroup_ = "keychainWithService:accessGroup:";
		static readonly IntPtr selKeychainWithServiceAccessGroup_Handle = Selector.GetHandle ("keychainWithService:accessGroup:");
		[CompilerGenerated]
		const string selService = "service";
		static readonly IntPtr selServiceHandle = Selector.GetHandle ("service");
		[CompilerGenerated]
		const string selSetAccessGroup_ = "setAccessGroup:";
		static readonly IntPtr selSetAccessGroup_Handle = Selector.GetHandle ("setAccessGroup:");
		[CompilerGenerated]
		const string selSetDataForKey_ = "setData:forKey:";
		static readonly IntPtr selSetDataForKey_Handle = Selector.GetHandle ("setData:forKey:");
		[CompilerGenerated]
		const string selSetDataForKeyPromptMessage_ = "setData:forKey:promptMessage:";
		static readonly IntPtr selSetDataForKeyPromptMessage_Handle = Selector.GetHandle ("setData:forKey:promptMessage:");
		[CompilerGenerated]
		const string selSetDefaultAccessiblity_ = "setDefaultAccessiblity:";
		static readonly IntPtr selSetDefaultAccessiblity_Handle = Selector.GetHandle ("setDefaultAccessiblity:");
		[CompilerGenerated]
		const string selSetService_ = "setService:";
		static readonly IntPtr selSetService_Handle = Selector.GetHandle ("setService:");
		[CompilerGenerated]
		const string selSetStringForKey_ = "setString:forKey:";
		static readonly IntPtr selSetStringForKey_Handle = Selector.GetHandle ("setString:forKey:");
		[CompilerGenerated]
		const string selSetStringForKeyPromptMessage_ = "setString:forKey:promptMessage:";
		static readonly IntPtr selSetStringForKeyPromptMessage_Handle = Selector.GetHandle ("setString:forKey:promptMessage:");
		[CompilerGenerated]
		const string selSetUseAccessControl_ = "setUseAccessControl:";
		static readonly IntPtr selSetUseAccessControl_Handle = Selector.GetHandle ("setUseAccessControl:");
		[CompilerGenerated]
		const string selStringForKey_ = "stringForKey:";
		static readonly IntPtr selStringForKey_Handle = Selector.GetHandle ("stringForKey:");
		[CompilerGenerated]
		const string selStringForKeyPromptMessage_ = "stringForKey:promptMessage:";
		static readonly IntPtr selStringForKeyPromptMessage_Handle = Selector.GetHandle ("stringForKey:promptMessage:");
		[CompilerGenerated]
		const string selUseAccessControl = "useAccessControl";
		static readonly IntPtr selUseAccessControlHandle = Selector.GetHandle ("useAccessControl");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("A0SimpleKeychain");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public A0SimpleKeychain () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::MonoTouch.ObjCRuntime.Selector.Init), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::MonoTouch.ObjCRuntime.Selector.Init), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("initWithCoder:")]
		public A0SimpleKeychain (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public A0SimpleKeychain (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public A0SimpleKeychain (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithService:")]
		[CompilerGenerated]
		public A0SimpleKeychain (string service)
			: base (NSObjectFlag.Empty)
		{
			if (service == null)
				throw new ArgumentNullException ("service");
			var nsservice = NSString.CreateNative (service);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selInitWithService_Handle, nsservice), "initWithService:");
			} else {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selInitWithService_Handle, nsservice), "initWithService:");
			}
			NSString.ReleaseNative (nsservice);
			
		}
		
		[Export ("initWithService:withAccessGroup:")]
		[CompilerGenerated]
		public A0SimpleKeychain (string service, string accessGroup)
			: base (NSObjectFlag.Empty)
		{
			if (service == null)
				throw new ArgumentNullException ("service");
			if (accessGroup == null)
				throw new ArgumentNullException ("accessGroup");
			var nsservice = NSString.CreateNative (service);
			var nsaccessGroup = NSString.CreateNative (accessGroup);
			
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selInitWithServiceWithAccessGroup_Handle, nsservice, nsaccessGroup), "initWithService:withAccessGroup:");
			} else {
				InitializeHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selInitWithServiceWithAccessGroup_Handle, nsservice, nsaccessGroup), "initWithService:withAccessGroup:");
			}
			NSString.ReleaseNative (nsservice);
			NSString.ReleaseNative (nsaccessGroup);
			
		}
		
		[Export ("clearAll")]
		[CompilerGenerated]
		public virtual bool ClearAll ()
		{
			if (IsDirectBinding) {
				return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, selClearAllHandle);
			} else {
				return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selClearAllHandle);
			}
		}
		
		[Export ("dataForKey:")]
		[CompilerGenerated]
		public virtual NSData DataForKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			NSData ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selDataForKey_Handle, nskey));
			} else {
				ret =  Runtime.GetNSObject<NSData> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selDataForKey_Handle, nskey));
			}
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("dataForKey:promptMessage:")]
		[CompilerGenerated]
		public virtual NSData DataForKey (string key, string message)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (message == null)
				throw new ArgumentNullException ("message");
			var nskey = NSString.CreateNative (key);
			var nsmessage = NSString.CreateNative (message);
			
			NSData ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selDataForKeyPromptMessage_Handle, nskey, nsmessage));
			} else {
				ret =  Runtime.GetNSObject<NSData> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selDataForKeyPromptMessage_Handle, nskey, nsmessage));
			}
			NSString.ReleaseNative (nskey);
			NSString.ReleaseNative (nsmessage);
			
			return ret;
		}
		
		[Export ("deleteEntryForKey:")]
		[CompilerGenerated]
		public virtual bool DeleteEntry (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selDeleteEntryForKey_Handle, nskey);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selDeleteEntryForKey_Handle, nskey);
			}
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("hasValueForKey:")]
		[CompilerGenerated]
		public virtual bool HasValueForKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selHasValueForKey_Handle, nskey);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selHasValueForKey_Handle, nskey);
			}
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("keychain")]
		[CompilerGenerated]
		public static A0SimpleKeychain KeyChain ()
		{
			return  Runtime.GetNSObject<A0SimpleKeychain> (ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, selKeychainHandle));
		}
		
		[Export ("keychainWithService:")]
		[CompilerGenerated]
		public static A0SimpleKeychain KeyChainWithService (string service)
		{
			if (service == null)
				throw new ArgumentNullException ("service");
			var nsservice = NSString.CreateNative (service);
			
			A0SimpleKeychain ret;
			ret =  Runtime.GetNSObject<A0SimpleKeychain> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (class_ptr, selKeychainWithService_Handle, nsservice));
			NSString.ReleaseNative (nsservice);
			
			return ret;
		}
		
		[Export ("keychainWithService:accessGroup:")]
		[CompilerGenerated]
		public static A0SimpleKeychain KeyChainWithService (string service, string accessGroup)
		{
			if (service == null)
				throw new ArgumentNullException ("service");
			if (accessGroup == null)
				throw new ArgumentNullException ("accessGroup");
			var nsservice = NSString.CreateNative (service);
			var nsaccessGroup = NSString.CreateNative (accessGroup);
			
			A0SimpleKeychain ret;
			ret =  Runtime.GetNSObject<A0SimpleKeychain> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (class_ptr, selKeychainWithServiceAccessGroup_Handle, nsservice, nsaccessGroup));
			NSString.ReleaseNative (nsservice);
			NSString.ReleaseNative (nsaccessGroup);
			
			return ret;
		}
		
		[Export ("setData:forKey:")]
		[CompilerGenerated]
		public virtual bool SetData (NSData data, string key)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetDataForKey_Handle, data.Handle, nskey);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSetDataForKey_Handle, data.Handle, nskey);
			}
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("setData:forKey:promptMessage:")]
		[CompilerGenerated]
		public virtual bool SetData (NSData data, string key, string message)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (key == null)
				throw new ArgumentNullException ("key");
			if (message == null)
				throw new ArgumentNullException ("message");
			var nskey = NSString.CreateNative (key);
			var nsmessage = NSString.CreateNative (message);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selSetDataForKeyPromptMessage_Handle, data.Handle, nskey, nsmessage);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selSetDataForKeyPromptMessage_Handle, data.Handle, nskey, nsmessage);
			}
			NSString.ReleaseNative (nskey);
			NSString.ReleaseNative (nsmessage);
			
			return ret;
		}
		
		[Export ("setString:forKey:")]
		[CompilerGenerated]
		public virtual bool SetString (string value, string key)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (key == null)
				throw new ArgumentNullException ("key");
			var nsvalue = NSString.CreateNative (value);
			var nskey = NSString.CreateNative (key);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr (this.Handle, selSetStringForKey_Handle, nsvalue, nskey);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selSetStringForKey_Handle, nsvalue, nskey);
			}
			NSString.ReleaseNative (nsvalue);
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("setString:forKey:promptMessage:")]
		[CompilerGenerated]
		public virtual bool SetString (string value, string key, string message)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			if (key == null)
				throw new ArgumentNullException ("key");
			if (message == null)
				throw new ArgumentNullException ("message");
			var nsvalue = NSString.CreateNative (value);
			var nskey = NSString.CreateNative (key);
			var nsmessage = NSString.CreateNative (message);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, selSetStringForKeyPromptMessage_Handle, nsvalue, nskey, nsmessage);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, selSetStringForKeyPromptMessage_Handle, nsvalue, nskey, nsmessage);
			}
			NSString.ReleaseNative (nsvalue);
			NSString.ReleaseNative (nskey);
			NSString.ReleaseNative (nsmessage);
			
			return ret;
		}
		
		[Export ("stringForKey:")]
		[CompilerGenerated]
		public virtual string StringForKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			string ret;
			if (IsDirectBinding) {
				ret = NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selStringForKey_Handle, nskey));
			} else {
				ret = NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selStringForKey_Handle, nskey));
			}
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("stringForKey:promptMessage:")]
		[CompilerGenerated]
		public virtual string StringForKey (string key, string message)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			if (message == null)
				throw new ArgumentNullException ("message");
			var nskey = NSString.CreateNative (key);
			var nsmessage = NSString.CreateNative (message);
			
			string ret;
			if (IsDirectBinding) {
				ret = NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr_IntPtr (this.Handle, selStringForKeyPromptMessage_Handle, nskey, nsmessage));
			} else {
				ret = NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr_IntPtr (this.SuperHandle, selStringForKeyPromptMessage_Handle, nskey, nsmessage));
			}
			NSString.ReleaseNative (nskey);
			NSString.ReleaseNative (nsmessage);
			
			return ret;
		}
		
		[CompilerGenerated]
		public virtual string AccessGroup {
			[Export ("accessGroup")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selAccessGroupHandle));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selAccessGroupHandle));
				}
			}
			
			[Export ("setAccessGroup:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetAccessGroup_Handle, nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetAccessGroup_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual AOSimpleKeychainItemAccessible DefaultAccessiblity {
			[Export ("defaultAccessiblity")]
			get {
				if (IsDirectBinding) {
					return (AOSimpleKeychainItemAccessible) ApiDefinition.Messaging.int_objc_msgSend (this.Handle, selDefaultAccessiblityHandle);
				} else {
					return (AOSimpleKeychainItemAccessible) ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, selDefaultAccessiblityHandle);
				}
			}
			
			[Export ("setDefaultAccessiblity:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, selSetDefaultAccessiblity_Handle, (int)value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, selSetDefaultAccessiblity_Handle, (int)value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual string Service {
			[Export ("service")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, selServiceHandle));
				} else {
					return NSString.FromHandle (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, selServiceHandle));
				}
			}
			
			[Export ("setService:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, selSetService_Handle, nsvalue);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, selSetService_Handle, nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual bool UseAccessControl {
			[Export ("useAccessControl")]
			get {
				if (IsDirectBinding) {
					return ApiDefinition.Messaging.bool_objc_msgSend (this.Handle, selUseAccessControlHandle);
				} else {
					return ApiDefinition.Messaging.bool_objc_msgSendSuper (this.SuperHandle, selUseAccessControlHandle);
				}
			}
			
			[Export ("setUseAccessControl:")]
			set {
				if (IsDirectBinding) {
					ApiDefinition.Messaging.void_objc_msgSend_bool (this.Handle, selSetUseAccessControl_Handle, value);
				} else {
					ApiDefinition.Messaging.void_objc_msgSendSuper_bool (this.SuperHandle, selSetUseAccessControl_Handle, value);
				}
			}
		}
		
	} /* class A0SimpleKeychain */
}
