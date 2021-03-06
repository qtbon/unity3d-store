﻿using UnityEngine;
using System;
using System.Runtime.InteropServices;

namespace Soomla
{
	public class StoreInventoryAndroid : StoreInventory {
#if UNITY_ANDROID && !UNITY_EDITOR
		override protected void _buyItem(string itemId) {
			AndroidJNI.PushLocalFrame(100);
			using(AndroidJavaClass jniStoreInventory = new AndroidJavaClass("com.soomla.store.StoreInventory")) {
				AndroidJNIHandler.CallStaticVoid(jniStoreInventory, "buy", itemId);
			}
			AndroidJNI.PopLocalFrame(IntPtr.Zero);
		}

		override protected int _getItemBalance(string itemId) {
			AndroidJNI.PushLocalFrame(100);
			int balance = 0;
			using(AndroidJavaClass jniStoreInventory = new AndroidJavaClass("com.soomla.store.StoreInventory")) {
				balance = AndroidJNIHandler.CallStatic<int>(jniStoreInventory, "getVirtualItemBalance", itemId);
			}
			AndroidJNI.PopLocalFrame(IntPtr.Zero);
			return balance;
		}

		override protected void _giveItem(string itemId, int amount) {
			AndroidJNI.PushLocalFrame(100);
			using(AndroidJavaClass jniStoreInventory = new AndroidJavaClass("com.soomla.store.StoreInventory")) {
				AndroidJNIHandler.CallStaticVoid(jniStoreInventory, "giveVirtualItem", itemId, amount);
			}
			AndroidJNI.PopLocalFrame(IntPtr.Zero);
		}

		override protected void _takeItem(string itemId, int amount) {
			AndroidJNI.PushLocalFrame(100);
			using(AndroidJavaClass jniStoreInventory = new AndroidJavaClass("com.soomla.store.StoreInventory")) {
				AndroidJNIHandler.CallStaticVoid(jniStoreInventory, "takeVirtualItem", itemId, amount);
			}
			AndroidJNI.PopLocalFrame(IntPtr.Zero);
		}

		override protected void _equipVirtualGood(string goodItemId) {
			AndroidJNI.PushLocalFrame(100);
			using(AndroidJavaClass jniStoreInventory = new AndroidJavaClass("com.soomla.store.StoreInventory")) {
				AndroidJNIHandler.CallStaticVoid(jniStoreInventory, "equipVirtualGood", goodItemId);
			}
			AndroidJNI.PopLocalFrame(IntPtr.Zero);
		}

		override protected void _unEquipVirtualGood(string goodItemId) {
			AndroidJNI.PushLocalFrame(100);
			using(AndroidJavaClass jniStoreInventory = new AndroidJavaClass("com.soomla.store.StoreInventory")) {
				AndroidJNIHandler.CallStaticVoid(jniStoreInventory, "unEquipVirtualGood", goodItemId);
			}
			AndroidJNI.PopLocalFrame(IntPtr.Zero);
		}

		override protected bool _isVertualGoodEquipped(string goodItemId) {
			bool result = false;
			AndroidJNI.PushLocalFrame(100);
			using(AndroidJavaClass jniStoreInventory = new AndroidJavaClass("com.soomla.store.StoreInventory")) {
				result = AndroidJNIHandler.CallStatic<bool>(jniStoreInventory, "isVirtualGoodEquipped", goodItemId);
			}
			AndroidJNI.PopLocalFrame(IntPtr.Zero);
			return result;
		}

		override protected int _getGoodUpgradeLevel(string goodItemId) {
			int level = 0;
			AndroidJNI.PushLocalFrame(100);
			using(AndroidJavaClass jniStoreInventory = new AndroidJavaClass("com.soomla.store.StoreInventory")) {
				level = AndroidJNIHandler.CallStatic<int>(jniStoreInventory, "getGoodUpgradeLevel", goodItemId);
			}
			AndroidJNI.PopLocalFrame(IntPtr.Zero);
			return level;
		}

		override protected string _getGoodCurrentUpgrade(string goodItemId) {
			string currentItemId = "";
			AndroidJNI.PushLocalFrame(100);
			using(AndroidJavaClass jniStoreInventory = new AndroidJavaClass("com.soomla.store.StoreInventory")) {
				currentItemId = AndroidJNIHandler.CallStatic<string>(jniStoreInventory, "getGoodCurrentUpgrade", goodItemId);
			}
			AndroidJNI.PopLocalFrame(IntPtr.Zero);
			return currentItemId;
		}

		override protected void _upgradeGood(string goodItemId) {
			AndroidJNI.PushLocalFrame(100);
			using(AndroidJavaClass jniStoreInventory = new AndroidJavaClass("com.soomla.store.StoreInventory")) {
				AndroidJNIHandler.CallStaticVoid(jniStoreInventory, "upgradeVirtualGood", goodItemId);
			}
			AndroidJNI.PopLocalFrame(IntPtr.Zero);
		}

		override protected void _removeGoodUpgrades(string goodItemId) {
			AndroidJNI.PushLocalFrame(100);
			using(AndroidJavaClass jniStoreInventory = new AndroidJavaClass("com.soomla.store.StoreInventory")) {
				AndroidJNIHandler.CallStaticVoid(jniStoreInventory, "removeUpgrades", goodItemId);
			}
			AndroidJNI.PopLocalFrame(IntPtr.Zero);
		}

		override protected bool _nonConsumableItemExists(string nonConsItemId) {
			bool result = false;
			AndroidJNI.PushLocalFrame(100);
			using(AndroidJavaClass jniStoreInventory = new AndroidJavaClass("com.soomla.store.StoreInventory")) {
				result = AndroidJNIHandler.CallStatic<bool>(jniStoreInventory, "nonConsumableItemExists", nonConsItemId);
			}
			AndroidJNI.PopLocalFrame(IntPtr.Zero);
			return result;
		}

		override protected void _addNonConsumableItem(string nonConsItemId) {
			AndroidJNI.PushLocalFrame(100);
			using(AndroidJavaClass jniStoreInventory = new AndroidJavaClass("com.soomla.store.StoreInventory")) {
				AndroidJNIHandler.CallStaticVoid(jniStoreInventory, "addNonConsumableItem", nonConsItemId);
			}
			AndroidJNI.PopLocalFrame(IntPtr.Zero);
		}
		
		override protected void _removeNonConsumableItem(string nonConsItemId) {
			AndroidJNI.PushLocalFrame(100);
			using(AndroidJavaClass jniStoreInventory = new AndroidJavaClass("com.soomla.store.StoreInventory")) {
				AndroidJNIHandler.CallStaticVoid(jniStoreInventory, "removeNonConsumableItem", nonConsItemId);
			}
			AndroidJNI.PopLocalFrame(IntPtr.Zero);
		}
#endif
	}
}
