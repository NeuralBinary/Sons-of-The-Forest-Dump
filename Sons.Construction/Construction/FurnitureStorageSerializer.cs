using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Newtonsoft.Json;
using Sons.Inventory;
using Sons.Save;
using UnityEngine;

namespace Construction
{
	// Token: 0x02000194 RID: 404
	[Token(Token = "0x2000194")]
	[AddComponentMenu("Sons/Construction/FurnitureStorageSerializer")]
	public class FurnitureStorageSerializer : MonoBehaviour, ISaveGameSerializer<FurnitureStorageSerializer.FurnitureStorageSaveData>
	{
		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000C57 RID: 3159 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x170002F6")]
		private string SerializedName
		{
			[Token(Token = "0x6000C57")]
			[Address(RVA = "0x2EC2E60", Offset = "0x2EC1460", VA = "0x182EC2E60", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x00007F4C File Offset: 0x0000614C
		[Token(Token = "0x170002F7")]
		private bool UniqueFile
		{
			[Token(Token = "0x6000C58")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000C59 RID: 3161 RVA: 0x00007F64 File Offset: 0x00006164
		[Token(Token = "0x170002F8")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6000C59")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000C5A RID: 3162 RVA: 0x00007F7C File Offset: 0x0000617C
		[Token(Token = "0x170002F9")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6000C5A")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000C5B RID: 3163 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C5B")]
		[Address(RVA = "0x2EC2E90", Offset = "0x2EC1490", VA = "0x182EC2E90")]
		private void Awake()
		{
		}

		// Token: 0x06000C5C RID: 3164 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C5C")]
		[Address(RVA = "0x2EC2F30", Offset = "0x2EC1530", VA = "0x182EC2F30")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000C5D RID: 3165 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C5D")]
		[Address(RVA = "0x2EC2FD0", Offset = "0x2EC15D0", VA = "0x182EC2FD0")]
		private static void ClearAll()
		{
		}

		// Token: 0x06000C5E RID: 3166 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000C5E")]
		[Address(RVA = "0x2EC3060", Offset = "0x2EC1660", VA = "0x182EC3060", Slot = "5")]
		private FurnitureStorageSerializer.FurnitureStorageSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C5F")]
		[Address(RVA = "0x2EC3AF0", Offset = "0x2EC20F0", VA = "0x182EC3AF0", Slot = "6")]
		private void OnDeserialize(FurnitureStorageSerializer.FurnitureStorageSaveData saveData)
		{
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C60")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public FurnitureStorageSerializer()
		{
		}

		// Token: 0x0400073F RID: 1855
		[Token(Token = "0x400073F")]
		[FieldOffset(Offset = "0x0")]
		private static readonly List<FurnitureStructure> Furnitures;

		// Token: 0x04000740 RID: 1856
		[Token(Token = "0x4000740")]
		[FieldOffset(Offset = "0x8")]
		private static bool Verbose;

		// Token: 0x02000195 RID: 405
		[Token(Token = "0x2000195")]
		[Serializable]
		internal class FurnitureStorageSaveData
		{
			// Token: 0x06000C62 RID: 3170 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000C62")]
			[Address(RVA = "0x2EC42F0", Offset = "0x2EC28F0", VA = "0x182EC42F0")]
			public FurnitureStorageSaveData()
			{
			}

			// Token: 0x04000741 RID: 1857
			[Token(Token = "0x4000741")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public string Version;

			// Token: 0x04000742 RID: 1858
			[Token(Token = "0x4000742")]
			[FieldOffset(Offset = "0x18")]
			[JsonProperty]
			public List<FurnitureStorageSerializer.FurnitureSaveData> Furnitures;
		}

		// Token: 0x02000196 RID: 406
		[Token(Token = "0x2000196")]
		[Serializable]
		internal class FurnitureSaveData
		{
			// Token: 0x06000C63 RID: 3171 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000C63")]
			[Address(RVA = "0x2EC4420", Offset = "0x2EC2A20", VA = "0x182EC4420")]
			public FurnitureSaveData()
			{
			}

			// Token: 0x04000743 RID: 1859
			[Token(Token = "0x4000743")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public List<FurnitureStorageSerializer.StorageGroup> StorageGroups;
		}

		// Token: 0x02000197 RID: 407
		[Token(Token = "0x2000197")]
		[Serializable]
		internal class StorageGroup
		{
			// Token: 0x06000C64 RID: 3172 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000C64")]
			[Address(RVA = "0x2EC44D0", Offset = "0x2EC2AD0", VA = "0x182EC44D0")]
			public StorageGroup()
			{
			}

			// Token: 0x04000744 RID: 1860
			[Token(Token = "0x4000744")]
			[FieldOffset(Offset = "0x10")]
			[JsonProperty]
			public List<ItemInstanceManager.ItemInstanceManagerSaveData> EndPoints;
		}
	}
}
