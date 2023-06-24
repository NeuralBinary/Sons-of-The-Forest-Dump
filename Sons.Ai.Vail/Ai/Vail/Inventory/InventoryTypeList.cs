using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sirenix.OdinInspector;

namespace Sons.Ai.Vail.Inventory
{
	// Token: 0x0200021A RID: 538
	[Token(Token = "0x200021A")]
	public static class InventoryTypeList
	{
		// Token: 0x06000F5B RID: 3931 RVA: 0x00008670 File Offset: 0x00006870
		[Token(Token = "0x6000F5B")]
		[Address(RVA = "0x2BBC410", Offset = "0x2BBAA10", VA = "0x182BBC410")]
		public static int GetTypeId(string itemType)
		{
			return 0;
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00008688 File Offset: 0x00006888
		[Token(Token = "0x6000F5C")]
		[Address(RVA = "0x2BBC610", Offset = "0x2BBAC10", VA = "0x182BBC610")]
		public static int GetGroupId(string itemType)
		{
			return 0;
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F5D")]
		[Address(RVA = "0x2BBC820", Offset = "0x2BBAE20", VA = "0x182BBC820")]
		public static string TypeIdToString(int typeId)
		{
			return null;
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x0000227A File Offset: 0x0000047A
		[Token(Token = "0x6000F5E")]
		[Address(RVA = "0x2BBC990", Offset = "0x2BBAF90", VA = "0x182BBC990")]
		public static ValueDropdownList<string> GetValueDropdownList()
		{
			return null;
		}

		// Token: 0x04000952 RID: 2386
		[Token(Token = "0x4000952")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<InventoryTypeList.TypeInfo> TypeList;

		// Token: 0x0200021B RID: 539
		[Token(Token = "0x200021B")]
		private readonly struct TypeInfo
		{
			// Token: 0x06000F60 RID: 3936 RVA: 0x00002050 File Offset: 0x00000250
			[Token(Token = "0x6000F60")]
			[Address(RVA = "0x2BBDB70", Offset = "0x2BBC170", VA = "0x182BBDB70")]
			public TypeInfo(string typeId, int inTypeId, int inGroupId = -1)
			{
			}

			// Token: 0x04000953 RID: 2387
			[Token(Token = "0x4000953")]
			[FieldOffset(Offset = "0x0")]
			public readonly string StringId;

			// Token: 0x04000954 RID: 2388
			[Token(Token = "0x4000954")]
			[FieldOffset(Offset = "0x8")]
			public readonly int TypeId;

			// Token: 0x04000955 RID: 2389
			[Token(Token = "0x4000955")]
			[FieldOffset(Offset = "0xC")]
			public readonly int GroupId;
		}
	}
}
