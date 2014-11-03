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
	[Protocol (Name = "A0SimpleKeychainKeyPair", WrapperType = typeof (A0SimpleKeychainKeyPairWrapper))]
	public interface IA0SimpleKeychainKeyPair : INativeObject, IDisposable
	{
	}
	
	public static partial class A0SimpleKeychainKeyPair_Extensions {
		[CompilerGenerated]
		public static bool GenerateKeyPair (this IA0SimpleKeychainKeyPair This, A0SimpleKeychainRSAKeySize keyLength, string publicKey, string privateKey)
		{
			if (publicKey == null)
				throw new ArgumentNullException ("publicKey");
			if (privateKey == null)
				throw new ArgumentNullException ("privateKey");
			var nspublicKey = NSString.CreateNative (publicKey);
			var nsprivateKey = NSString.CreateNative (privateKey);
			
			bool ret;
			ret = ApiDefinition.Messaging.bool_objc_msgSend_int_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("generateRSAKeyPairWithLength:publicKeyTag:privateKeyTag:"), (int)keyLength, nspublicKey, nsprivateKey);
			NSString.ReleaseNative (nspublicKey);
			NSString.ReleaseNative (nsprivateKey);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static NSData DataForRSAKey (this IA0SimpleKeychainKeyPair This, string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			NSData ret;
			ret =  Runtime.GetNSObject<NSData> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("dataForRSAKeyWithTag:"), nskey));
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static bool DeleteRSAKey (this IA0SimpleKeychainKeyPair This, string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			bool ret;
			ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("deleteRSAKeyWithTag:"), nskey);
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static bool HasRSAKey (this IA0SimpleKeychainKeyPair This, string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			bool ret;
			ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("hasRSAKeyWithTag:"), nskey);
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
	}
	
	internal sealed class A0SimpleKeychainKeyPairWrapper : BaseWrapper, IA0SimpleKeychainKeyPair {
		public A0SimpleKeychainKeyPairWrapper (IntPtr handle)
			: base (handle, false)
		{
		}
		
		[Preserve (Conditional = true)]
		public A0SimpleKeychainKeyPairWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace Xamarin.SimpleKeychain {
	[Protocol]
	[Register("A0SimpleKeychainKeyPair", true)]
	public unsafe partial class A0SimpleKeychainKeyPair : NSObject, IA0SimpleKeychainKeyPair {
		[CompilerGenerated]
		const string selDataForRSAKeyWithTag_ = "dataForRSAKeyWithTag:";
		static readonly IntPtr selDataForRSAKeyWithTag_Handle = Selector.GetHandle ("dataForRSAKeyWithTag:");
		[CompilerGenerated]
		const string selDeleteRSAKeyWithTag_ = "deleteRSAKeyWithTag:";
		static readonly IntPtr selDeleteRSAKeyWithTag_Handle = Selector.GetHandle ("deleteRSAKeyWithTag:");
		[CompilerGenerated]
		const string selGenerateRSAKeyPairWithLengthPublicKeyTagPrivateKeyTag_ = "generateRSAKeyPairWithLength:publicKeyTag:privateKeyTag:";
		static readonly IntPtr selGenerateRSAKeyPairWithLengthPublicKeyTagPrivateKeyTag_Handle = Selector.GetHandle ("generateRSAKeyPairWithLength:publicKeyTag:privateKeyTag:");
		[CompilerGenerated]
		const string selHasRSAKeyWithTag_ = "hasRSAKeyWithTag:";
		static readonly IntPtr selHasRSAKeyWithTag_Handle = Selector.GetHandle ("hasRSAKeyWithTag:");
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("A0SimpleKeychainKeyPair");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public A0SimpleKeychainKeyPair () : base (NSObjectFlag.Empty)
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
		public A0SimpleKeychainKeyPair (NSCoder coder) : base (NSObjectFlag.Empty)
		{
			throw new InvalidOperationException ("Type does not conform to NSCoding");
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public A0SimpleKeychainKeyPair (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		public A0SimpleKeychainKeyPair (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("dataForRSAKeyWithTag:")]
		[CompilerGenerated]
		public virtual NSData DataForRSAKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			NSData ret;
			if (IsDirectBinding) {
				ret =  Runtime.GetNSObject<NSData> (ApiDefinition.Messaging.IntPtr_objc_msgSend_IntPtr (this.Handle, selDataForRSAKeyWithTag_Handle, nskey));
			} else {
				ret =  Runtime.GetNSObject<NSData> (ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_IntPtr (this.SuperHandle, selDataForRSAKeyWithTag_Handle, nskey));
			}
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("deleteRSAKeyWithTag:")]
		[CompilerGenerated]
		public virtual bool DeleteRSAKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selDeleteRSAKeyWithTag_Handle, nskey);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selDeleteRSAKeyWithTag_Handle, nskey);
			}
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
		[Export ("generateRSAKeyPairWithLength:publicKeyTag:privateKeyTag:")]
		[CompilerGenerated]
		public virtual bool GenerateKeyPair (A0SimpleKeychainRSAKeySize keyLength, string publicKey, string privateKey)
		{
			if (publicKey == null)
				throw new ArgumentNullException ("publicKey");
			if (privateKey == null)
				throw new ArgumentNullException ("privateKey");
			var nspublicKey = NSString.CreateNative (publicKey);
			var nsprivateKey = NSString.CreateNative (privateKey);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_int_IntPtr_IntPtr (this.Handle, selGenerateRSAKeyPairWithLengthPublicKeyTagPrivateKeyTag_Handle, (int)keyLength, nspublicKey, nsprivateKey);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_int_IntPtr_IntPtr (this.SuperHandle, selGenerateRSAKeyPairWithLengthPublicKeyTagPrivateKeyTag_Handle, (int)keyLength, nspublicKey, nsprivateKey);
			}
			NSString.ReleaseNative (nspublicKey);
			NSString.ReleaseNative (nsprivateKey);
			
			return ret;
		}
		
		[Export ("hasRSAKeyWithTag:")]
		[CompilerGenerated]
		public virtual bool HasRSAKey (string key)
		{
			if (key == null)
				throw new ArgumentNullException ("key");
			var nskey = NSString.CreateNative (key);
			
			bool ret;
			if (IsDirectBinding) {
				ret = ApiDefinition.Messaging.bool_objc_msgSend_IntPtr (this.Handle, selHasRSAKeyWithTag_Handle, nskey);
			} else {
				ret = ApiDefinition.Messaging.bool_objc_msgSendSuper_IntPtr (this.SuperHandle, selHasRSAKeyWithTag_Handle, nskey);
			}
			NSString.ReleaseNative (nskey);
			
			return ret;
		}
		
	} /* class A0SimpleKeychainKeyPair */
}
