using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020006DC RID: 1756
	[Token(Token = "0x20006DC")]
	[AddComponentMenu("Sons/Crafting/Structures/ScrewTreeLinkerSaveManager")]
	public class ScrewTreeLinkerSaveManager : MonoBehaviour, ISaveGameSerializer<ScrewTreeLinkerSaveManager.TreeLinkerSaveData>
	{
		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06002E5D RID: 11869 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000629")]
		private string SerializedName
		{
			[Token(Token = "0x6002E5D")]
			[Address(RVA = "0x344C920", Offset = "0x344AF20", VA = "0x18344C920", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700062A RID: 1578
		// (get) Token: 0x06002E5E RID: 11870 RVA: 0x0000DA88 File Offset: 0x0000BC88
		[Token(Token = "0x1700062A")]
		private bool UniqueFile
		{
			[Token(Token = "0x6002E5E")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700062B RID: 1579
		// (get) Token: 0x06002E5F RID: 11871 RVA: 0x0000DAA0 File Offset: 0x0000BCA0
		[Token(Token = "0x1700062B")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x6002E5F")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700062C RID: 1580
		// (get) Token: 0x06002E60 RID: 11872 RVA: 0x0000DAB8 File Offset: 0x0000BCB8
		[Token(Token = "0x1700062C")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x6002E60")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E61")]
		[Address(RVA = "0x344C950", Offset = "0x344AF50", VA = "0x18344C950")]
		private void Start()
		{
		}

		// Token: 0x06002E62 RID: 11874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E62")]
		[Address(RVA = "0x344CA90", Offset = "0x344B090", VA = "0x18344CA90")]
		private void OnDestroy()
		{
		}

		// Token: 0x06002E63 RID: 11875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E63")]
		[Address(RVA = "0x344CBA0", Offset = "0x344B1A0", VA = "0x18344CBA0")]
		private static void BeforeLoadCleanUp()
		{
		}

		// Token: 0x06002E64 RID: 11876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E64")]
		[Address(RVA = "0x344CC30", Offset = "0x344B230", VA = "0x18344CC30")]
		private void ToggleVerbose()
		{
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E65")]
		[Address(RVA = "0x344CC80", Offset = "0x344B280", VA = "0x18344CC80")]
		public static void Register(ScrewTreeLinker treeLinker)
		{
		}

		// Token: 0x06002E66 RID: 11878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E66")]
		[Address(RVA = "0x344CDB0", Offset = "0x344B3B0", VA = "0x18344CDB0")]
		public static void Unregister(ScrewTreeLinker treeLinker)
		{
		}

		// Token: 0x06002E67 RID: 11879 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002E67")]
		[Address(RVA = "0x344CEA0", Offset = "0x344B4A0", VA = "0x18344CEA0", Slot = "5")]
		private ScrewTreeLinkerSaveManager.TreeLinkerSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x06002E68 RID: 11880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E68")]
		[Address(RVA = "0x344D150", Offset = "0x344B750", VA = "0x18344D150", Slot = "6")]
		private void OnDeserialize(ScrewTreeLinkerSaveManager.TreeLinkerSaveData data)
		{
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002E69")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public ScrewTreeLinkerSaveManager()
		{
		}

		// Token: 0x04002862 RID: 10338
		[Token(Token = "0x4002862")]
		[FieldOffset(Offset = "0x0")]
		private static bool Verbose;

		// Token: 0x04002863 RID: 10339
		[Token(Token = "0x4002863")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<ScrewTreeLinker> _treeLinkers;

		// Token: 0x020006DD RID: 1757
		[Token(Token = "0x20006DD")]
		[Serializable]
		public class TreeLinkerSaveData
		{
			// Token: 0x06002E6B RID: 11883 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6002E6B")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public TreeLinkerSaveData()
			{
			}

			// Token: 0x04002864 RID: 10340
			[Token(Token = "0x4002864")]
			[FieldOffset(Offset = "0x10")]
			public List<ScrewTreeLinker.SaveData> _treeStructureData;
		}
	}
}
