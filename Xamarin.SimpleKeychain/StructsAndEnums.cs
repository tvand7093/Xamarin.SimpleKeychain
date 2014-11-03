using System;

namespace Xamarin.SimpleKeychain
{
	public enum AOSimpleKeychainItemAccessible {
		A0SimpleKeychainItemAccessibleWhenUnlocked = 0,
		A0SimpleKeychainItemAccessibleAfterFirstUnlock,
		A0SimpleKeychainItemAccessibleAlways,
		A0SimpleKeychainItemAccessibleWhenPasscodeSetThisDeviceOnly,
		A0SimpleKeychainItemAccessibleWhenUnlockedThisDeviceOnly,
		A0SimpleKeychainItemAccessibleAfterFirstUnlockThisDeviceOnly,
		A0SimpleKeychainItemAccessibleAlwaysThisDeviceOnly
	};

	public enum A0SimpleKeychainRSAKeySize {
		A0SimpleKeychainRSAKeySize512Bits = 512,
		A0SimpleKeychainRSAKeySize1024Bits = 1024,
		A0SimpleKeychainRSAKeySize2048Bits = 2048
	};
}

