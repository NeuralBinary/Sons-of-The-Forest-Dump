using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.Serialization;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001F6 RID: 502
	[Token(Token = "0x20001F6")]
	public class TreeStructureSaveManager : MonoBehaviour, ISaveGameSerializer<TreeStructureSaveManager.TreeStructureSaveData>
	{
		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06000F2D RID: 3885 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000381")]
		private string SerializedName
		{
			[Token(Token = "0x6000F2D")]
			[Address(RVA = "0x2EFAAE0", Offset = "0x2EF90E0", VA = "0x182EFAAE0", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06000F2E RID: 3886 RVA: 0x000093A4 File Offset: 0x000075A4
		[Token(Token = "0x17000382")]
		private bool UniqueFile
		{
			[Token(Token = "0x6000F2E")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000383 RID: 899
		// (get) Token: 0x06000F2F RID: 3887 RVA: 0x000093BC File Offset: 0x000075BC
		[Token(Token = "0x17000383")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6000F2F")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000384 RID: 900
		// (get) Token: 0x06000F30 RID: 3888 RVA: 0x000093D4 File Offset: 0x000075D4
		[Token(Token = "0x17000384")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6000F30")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F31")]
		[Address(RVA = "0x2EFAB10", Offset = "0x2EF9110", VA = "0x182EFAB10")]
		private void Start()
		{
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F32")]
		[Address(RVA = "0x2EFAC40", Offset = "0x2EF9240", VA = "0x182EFAC40")]
		private void OnDestroy()
		{
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F33")]
		[Address(RVA = "0x2EFACF0", Offset = "0x2EF92F0", VA = "0x182EFACF0")]
		private void BeforeLoadCleanUp()
		{
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F34")]
		[Address(RVA = "0x2EFAD80", Offset = "0x2EF9380", VA = "0x182EFAD80")]
		private void ToggleVerbose()
		{
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F35")]
		[Address(RVA = "0x2EFADD0", Offset = "0x2EF93D0", VA = "0x182EFADD0")]
		public static void Register(TreeStructure treeStructure)
		{
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F36")]
		[Address(RVA = "0x2EFAF00", Offset = "0x2EF9500", VA = "0x182EFAF00")]
		public static void Unregister(TreeStructure treeStructure)
		{
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x6000F37")]
		[Address(RVA = "0x2EFB140", Offset = "0x2EF9740", VA = "0x182EFB140", Slot = "5")]
		private TreeStructureSaveManager.TreeStructureSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F38")]
		[Address(RVA = "0x2EFB470", Offset = "0x2EF9A70", VA = "0x182EFB470", Slot = "6")]
		private void OnDeserialize(TreeStructureSaveManager.TreeStructureSaveData data)
		{
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000F39")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public TreeStructureSaveManager()
		{
		}

		// Token: 0x04000824 RID: 2084
		[Token(Token = "0x4000824")]
		[FieldOffset(Offset = "0x0")]
		private static bool Verbose;

		// Token: 0x04000825 RID: 2085
		[Token(Token = "0x4000825")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<TreeStructure> _treeStructures;

		// Token: 0x020001F7 RID: 503
		[Token(Token = "0x20001F7")]
		[Serializable]
		public class TreeStructureSaveData
		{
			// Token: 0x06000F3B RID: 3899 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000F3B")]
			[Address(RVA = "0x2EFB7B0", Offset = "0x2EF9DB0", VA = "0x182EFB7B0")]
			[OnSerializing]
			private void OnSerializing(StreamingContext context)
			{
			}

			// Token: 0x06000F3C RID: 3900 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x6000F3C")]
			[Address(RVA = "0x2EFB830", Offset = "0x2EF9E30", VA = "0x182EFB830")]
			public TreeStructureSaveData()
			{
			}

			// Token: 0x04000826 RID: 2086
			[Token(Token = "0x4000826")]
			public const string Version_0_0_0String = "0.0.0";

			// Token: 0x04000827 RID: 2087
			[Token(Token = "0x4000827")]
			public const string DefaultVersionString = "0.0.0";

			// Token: 0x04000828 RID: 2088
			[Token(Token = "0x4000828")]
			public const string CurrentVersionString = "0.0.1";

			// Token: 0x04000829 RID: 2089
			[Token(Token = "0x4000829")]
			[FieldOffset(Offset = "0x10")]
			[DefaultValue("0.0.0")]
			public string Version;

			// Token: 0x0400082A RID: 2090
			[Token(Token = "0x400082A")]
			[FieldOffset(Offset = "0x18")]
			public List<TreeStructure.SaveData> _treeStructureData;
		}
	}
}
