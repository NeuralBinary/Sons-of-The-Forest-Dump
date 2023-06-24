using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Sons.Ai.Vail.Inventory
{
	// Token: 0x02000223 RID: 547
	[Token(Token = "0x2000223")]
	public class VailPickupManager : MonoBehaviour
	{
		// Token: 0x06000F95 RID: 3989 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F95")]
		[Address(RVA = "0x2BBFD10", Offset = "0x2BBE310", VA = "0x182BBFD10")]
		private void Awake()
		{
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F96")]
		[Address(RVA = "0x2BBFE90", Offset = "0x2BBE490", VA = "0x182BBFE90")]
		public static GameObject SpawnPickup(string itemType, VailPickupManager.SpawnType spawnType, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00008790 File Offset: 0x00006990
		[Token(Token = "0x6000F97")]
		[Address(RVA = "0x2BC0030", Offset = "0x2BBE630", VA = "0x182BC0030")]
		public static bool ShouldDropHeldItem(string itemType)
		{
			return default(bool);
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F98")]
		[Address(RVA = "0x2BC0220", Offset = "0x2BBE820", VA = "0x182BC0220")]
		private GameObject SpawnPickupInternal(string itemType, VailPickupManager.SpawnType spawnType, Vector3 position, Quaternion rotation)
		{
			return null;
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F99")]
		[Address(RVA = "0x2BC0450", Offset = "0x2BBEA50", VA = "0x182BC0450")]
		private VailPickupManager.TypeInfo GetTypeInfo(string itemType)
		{
			return null;
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x000087A8 File Offset: 0x000069A8
		[Token(Token = "0x6000F9A")]
		[Address(RVA = "0x2BC0650", Offset = "0x2BBEC50", VA = "0x182BC0650")]
		public static int GetMaxHeld(string itemType)
		{
			return 0;
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x000087C0 File Offset: 0x000069C0
		[Token(Token = "0x6000F9B")]
		[Address(RVA = "0x2BC07A0", Offset = "0x2BBEDA0", VA = "0x182BC07A0")]
		private int GetMaxHeldInternal(string itemType)
		{
			return 0;
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x000087D8 File Offset: 0x000069D8
		[Token(Token = "0x6000F9C")]
		[Address(RVA = "0x2BC07D0", Offset = "0x2BBEDD0", VA = "0x182BC07D0")]
		public static int VailItemToItemId(string vailItemName)
		{
			return 0;
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F9D")]
		[Address(RVA = "0x2BC0AE0", Offset = "0x2BBF0E0", VA = "0x182BC0AE0")]
		public static string ItemIdToVailItem(int itemId)
		{
			return null;
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F9E")]
		[Address(RVA = "0x2BC0BC0", Offset = "0x2BBF1C0", VA = "0x182BC0BC0")]
		private void AddMissingTypes()
		{
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000F9F")]
		[Address(RVA = "0x2BC0E80", Offset = "0x2BBF480", VA = "0x182BC0E80")]
		public VailPickupManager()
		{
		}

		// Token: 0x04000971 RID: 2417
		[Token(Token = "0x4000971")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private List<VailPickupManager.TypeInfo> _pickupTypes;

		// Token: 0x04000972 RID: 2418
		[Token(Token = "0x4000972")]
		[FieldOffset(Offset = "0x0")]
		private static VailPickupManager _instance;

		// Token: 0x02000224 RID: 548
		[Token(Token = "0x2000224")]
		[Serializable]
		public class TypeInfo
		{
			// Token: 0x06000FA0 RID: 4000 RVA: 0x0000227A File Offset: 0x0000047A
			[Token(Token = "0x6000FA0")]
			[Address(RVA = "0x2BC0F60", Offset = "0x2BBF560", VA = "0x182BC0F60")]
			private static ValueDropdownList<string> GetItemTypes()
			{
				return null;
			}

			// Token: 0x06000FA1 RID: 4001 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000FA1")]
			[Address(RVA = "0x2BC0FA0", Offset = "0x2BBF5A0", VA = "0x182BC0FA0")]
			public TypeInfo()
			{
			}

			// Token: 0x04000973 RID: 2419
			[Token(Token = "0x4000973")]
			[FieldOffset(Offset = "0x10")]
			public string itemType;

			// Token: 0x04000974 RID: 2420
			[Token(Token = "0x4000974")]
			[FieldOffset(Offset = "0x18")]
			public int maxHeld;

			// Token: 0x04000975 RID: 2421
			[Token(Token = "0x4000975")]
			[FieldOffset(Offset = "0x20")]
			public GameObject heldPrefab;

			// Token: 0x04000976 RID: 2422
			[Token(Token = "0x4000976")]
			[FieldOffset(Offset = "0x28")]
			public GameObject droppedPrefab;
		}

		// Token: 0x02000225 RID: 549
		[Token(Token = "0x2000225")]
		public enum SpawnType
		{
			// Token: 0x04000978 RID: 2424
			[Token(Token = "0x4000978")]
			Held,
			// Token: 0x04000979 RID: 2425
			[Token(Token = "0x4000979")]
			Dropped
		}
	}
}
