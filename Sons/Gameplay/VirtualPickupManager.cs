using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Items.Core;
using UnityEngine;

namespace Sons.Gameplay
{
	// Token: 0x020007AE RID: 1966
	[Token(Token = "0x20007AE")]
	public class VirtualPickupManager : SingletonBehaviour<VirtualPickupManager>
	{
		// Token: 0x060034F9 RID: 13561 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034F9")]
		[Address(RVA = "0x34D5A70", Offset = "0x34D4070", VA = "0x1834D5A70")]
		private void ReferenceCleanup()
		{
		}

		// Token: 0x060034FA RID: 13562 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034FA")]
		[Address(RVA = "0x34D5B50", Offset = "0x34D4150", VA = "0x1834D5B50")]
		private void LateUpdate()
		{
		}

		// Token: 0x060034FB RID: 13563 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034FB")]
		[Address(RVA = "0x34D5B70", Offset = "0x34D4170", VA = "0x1834D5B70")]
		private void CheckTimeoutVirtualPickupRepoolCallbacks()
		{
		}

		// Token: 0x060034FC RID: 13564 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034FC")]
		[Address(RVA = "0x34D5D70", Offset = "0x34D4370", VA = "0x1834D5D70")]
		private void CheckPickupCountsAndSwitchToVirtual()
		{
		}

		// Token: 0x060034FD RID: 13565 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034FD")]
		[Address(RVA = "0x34D5F40", Offset = "0x34D4540", VA = "0x1834D5F40")]
		private void CheckPickupCountAndSwitchToVirtual(int itemId)
		{
		}

		// Token: 0x060034FE RID: 13566 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034FE")]
		[Address(RVA = "0x34D6390", Offset = "0x34D4990", VA = "0x1834D6390")]
		private void OnEnable()
		{
		}

		// Token: 0x060034FF RID: 13567 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034FF")]
		[Address(RVA = "0x34D6420", Offset = "0x34D4A20", VA = "0x1834D6420")]
		public void SendToPool(VirtualPickup virtualPickup, int itemId)
		{
		}

		// Token: 0x06003500 RID: 13568 RVA: 0x0000FDC8 File Offset: 0x0000DFC8
		[Token(Token = "0x6003500")]
		[Address(RVA = "0x34D6590", Offset = "0x34D4B90", VA = "0x1834D6590")]
		private bool ReuseWithCallback(VirtualPickup virtualPickup, int itemId)
		{
			return default(bool);
		}

		// Token: 0x06003501 RID: 13569 RVA: 0x0000FDE0 File Offset: 0x0000DFE0
		[Token(Token = "0x6003501")]
		[Address(RVA = "0x34D6670", Offset = "0x34D4C70", VA = "0x1834D6670")]
		public static bool CreateOrTryFetchFromPool(ItemData itemData, out VirtualPickup result)
		{
			return default(bool);
		}

		// Token: 0x06003502 RID: 13570 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		[Token(Token = "0x6003502")]
		[Address(RVA = "0x34D6740", Offset = "0x34D4D40", VA = "0x1834D6740")]
		private bool CreateOrTryFetchFromPoolInternal(out VirtualPickup result, ItemData itemData)
		{
			return default(bool);
		}

		// Token: 0x06003503 RID: 13571 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003503")]
		[Address(RVA = "0x34D6D60", Offset = "0x34D5360", VA = "0x1834D6D60")]
		private static void InitializeResult(VirtualPickup result, ItemData itemData, List<VirtualPickup> existingVirtualPickups)
		{
		}

		// Token: 0x06003504 RID: 13572 RVA: 0x0000FE10 File Offset: 0x0000E010
		[Token(Token = "0x6003504")]
		[Address(RVA = "0x34D6F10", Offset = "0x34D5510", VA = "0x1834D6F10")]
		private int GetMaxVirtualInstances(ItemData itemData)
		{
			return 0;
		}

		// Token: 0x06003505 RID: 13573 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003505")]
		[Address(RVA = "0x34D6F40", Offset = "0x34D5540", VA = "0x1834D6F40")]
		private VirtualPickup CreateNew()
		{
			return null;
		}

		// Token: 0x06003506 RID: 13574 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003506")]
		[Address(RVA = "0x34D7000", Offset = "0x34D5600", VA = "0x1834D7000")]
		public static void RegisterForPoolQueue(VirtualPickupData virtualPickupData)
		{
		}

		// Token: 0x06003507 RID: 13575 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003507")]
		[Address(RVA = "0x34D7070", Offset = "0x34D5670", VA = "0x1834D7070")]
		public static void UnregisterForPoolQueue(VirtualPickupData virtualPickupData)
		{
		}

		// Token: 0x06003508 RID: 13576 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003508")]
		[Address(RVA = "0x34D71E0", Offset = "0x34D57E0", VA = "0x1834D71E0")]
		private void UnregisterForPoolQueueInternal(VirtualPickupData virtualPickupData)
		{
		}

		// Token: 0x06003509 RID: 13577 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003509")]
		[Address(RVA = "0x34D7310", Offset = "0x34D5910", VA = "0x1834D7310")]
		private void RemoveInvalidAndContextFromQueue(Queue<VirtualPickupData> callbacks, VirtualPickupData context)
		{
		}

		// Token: 0x0600350A RID: 13578 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600350A")]
		[Address(RVA = "0x34D73C0", Offset = "0x34D59C0", VA = "0x1834D73C0")]
		private void RegisterForPoolQueueInternal(VirtualPickupData virtualPickupData)
		{
		}

		// Token: 0x0600350B RID: 13579 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600350B")]
		[Address(RVA = "0x34D75C0", Offset = "0x34D5BC0", VA = "0x1834D75C0")]
		public static void RegisterPickupInstance(VirtualPickupSwitcher switcher, PickUp pickup)
		{
		}

		// Token: 0x0600350C RID: 13580 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600350C")]
		[Address(RVA = "0x34D7640", Offset = "0x34D5C40", VA = "0x1834D7640")]
		private void RegisterPickupInstanceInternal(VirtualPickupSwitcher switcher, PickUp pickup)
		{
		}

		// Token: 0x0600350D RID: 13581 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600350D")]
		[Address(RVA = "0x34D7910", Offset = "0x34D5F10", VA = "0x1834D7910")]
		public static void UnregisterPickupInstance(VirtualPickupSwitcher switcher, PickUp pickup)
		{
		}

		// Token: 0x0600350E RID: 13582 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600350E")]
		[Address(RVA = "0x34D7AF0", Offset = "0x34D60F0", VA = "0x1834D7AF0")]
		private void UnregisterPickupInstanceInternal(VirtualPickupSwitcher switcher, PickUp pickup)
		{
		}

		// Token: 0x0600350F RID: 13583 RVA: 0x0000FE28 File Offset: 0x0000E028
		[Token(Token = "0x600350F")]
		[Address(RVA = "0x34D7C90", Offset = "0x34D6290", VA = "0x1834D7C90")]
		public static int GetPickupInstanceCount(int itemId)
		{
			return 0;
		}

		// Token: 0x06003510 RID: 13584 RVA: 0x0000FE40 File Offset: 0x0000E040
		[Token(Token = "0x6003510")]
		[Address(RVA = "0x34D7D80", Offset = "0x34D6380", VA = "0x1834D7D80")]
		private int GetPickupInstanceCountInternal(int itemId)
		{
			return 0;
		}

		// Token: 0x06003511 RID: 13585 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003511")]
		[Address(RVA = "0x34D7E20", Offset = "0x34D6420", VA = "0x1834D7E20")]
		public VirtualPickupManager()
		{
		}

		// Token: 0x04002DBF RID: 11711
		[Token(Token = "0x4002DBF")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Tooltip("Default max number of virtual pickups to spawn for each item type\n - override in the item data but if is < 0 in the item data then we will use this default value")]
		private int _defaultMaxVirtualPickups;

		// Token: 0x04002DC0 RID: 11712
		[Token(Token = "0x4002DC0")]
		[FieldOffset(Offset = "0x2C")]
		[Tooltip("The max amount of pending virtualization callbacks that can be queued up before we start dropping them\n - multiplied by the max number of virtual pickups i.e. 0.1 = 10% of max virtual pickups")]
		[SerializeField]
		private float _maxCallbackQueuePercentage;

		// Token: 0x04002DC1 RID: 11713
		[Token(Token = "0x4002DC1")]
		[FieldOffset(Offset = "0x30")]
		[Tooltip("The max amount of time a virtualization callback can be queued up before we start dropping them")]
		[SerializeField]
		private float _maxCallbackQueueLifetime;

		// Token: 0x04002DC2 RID: 11714
		[Token(Token = "0x4002DC2")]
		private const string DefaultInstanceName = "VirtualPickup";

		// Token: 0x04002DC3 RID: 11715
		[Token(Token = "0x4002DC3")]
		[FieldOffset(Offset = "0x38")]
		private readonly Dictionary<int, List<VirtualPickup>> _virtualPickupInstances;

		// Token: 0x04002DC4 RID: 11716
		[Token(Token = "0x4002DC4")]
		[FieldOffset(Offset = "0x40")]
		private readonly Dictionary<int, List<VirtualPickupSwitcher>> _virtualPickupSwitcherInstances;

		// Token: 0x04002DC5 RID: 11717
		[Token(Token = "0x4002DC5")]
		[FieldOffset(Offset = "0x48")]
		private readonly Dictionary<int, int> _virtualPickupSwitcherCounts;

		// Token: 0x04002DC6 RID: 11718
		[Token(Token = "0x4002DC6")]
		[FieldOffset(Offset = "0x50")]
		private readonly Stack<VirtualPickup> _virtualPickupPool;

		// Token: 0x04002DC7 RID: 11719
		[Token(Token = "0x4002DC7")]
		[FieldOffset(Offset = "0x58")]
		private readonly Dictionary<int, Queue<VirtualPickupData>> _virtualPickupRepoolCallbacks;

		// Token: 0x020007AF RID: 1967
		[Token(Token = "0x20007AF")]
		internal class VirtualPickupAction
		{
			// Token: 0x06003512 RID: 13586 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003512")]
			[Address(RVA = "0x2172780", Offset = "0x2170D80", VA = "0x182172780")]
			public VirtualPickupAction(Action<VirtualPickup> callback, UnityEngine.Object context)
			{
			}

			// Token: 0x170006B1 RID: 1713
			// (get) Token: 0x06003513 RID: 13587 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006B1")]
			public UnityEngine.Object Context
			{
				[Token(Token = "0x6003513")]
				[Address(RVA = "0x5BB360", Offset = "0x5B9960", VA = "0x1805BB360")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170006B2 RID: 1714
			// (get) Token: 0x06003514 RID: 13588 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x170006B2")]
			public Action<VirtualPickup> Callback
			{
				[Token(Token = "0x6003514")]
				[Address(RVA = "0x5EDB80", Offset = "0x5EC180", VA = "0x1805EDB80")]
				[CompilerGenerated]
				get
				{
					return null;
				}
			}

			// Token: 0x170006B3 RID: 1715
			// (get) Token: 0x06003515 RID: 13589 RVA: 0x0000FE58 File Offset: 0x0000E058
			[Token(Token = "0x170006B3")]
			public bool IsValid
			{
				[Token(Token = "0x6003515")]
				[Address(RVA = "0x34D8160", Offset = "0x34D6760", VA = "0x1834D8160")]
				get
				{
					return default(bool);
				}
			}

			// Token: 0x06003516 RID: 13590 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6003516")]
			[Address(RVA = "0xFC6380", Offset = "0xFC4980", VA = "0x180FC6380")]
			public void Invoke(VirtualPickup virtualPickup)
			{
			}
		}
	}
}
