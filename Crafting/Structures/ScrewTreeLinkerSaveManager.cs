using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using Sons.Save;
using UnityEngine;

namespace Sons.Crafting.Structures
{
	// Token: 0x020007D0 RID: 2000
	[Token(Token = "0x20007D0")]
	[AddComponentMenu("Sons/Crafting/Structures/ScrewTreeLinkerSaveManager")]
	public class ScrewTreeLinkerSaveManager : MonoBehaviour, ISaveGameSerializer<ScrewTreeLinkerSaveManager.TreeLinkerSaveData>
	{
		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x060034C9 RID: 13513 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006BA")]
		private string SerializedName
		{
			[Token(Token = "0x60034C9")]
			[Address(RVA = "0x2E97F90", Offset = "0x2E96F90", VA = "0x182E97F90", Slot = "4")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006BB RID: 1723
		// (get) Token: 0x060034CA RID: 13514 RVA: 0x0000F108 File Offset: 0x0000D308
		[Token(Token = "0x170006BB")]
		private bool UniqueFile
		{
			[Token(Token = "0x60034CA")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006BC RID: 1724
		// (get) Token: 0x060034CB RID: 13515 RVA: 0x0000F120 File Offset: 0x0000D320
		[Token(Token = "0x170006BC")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x60034CB")]
			[Address(RVA = "0x582970", Offset = "0x581970", VA = "0x180582970", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006BD RID: 1725
		// (get) Token: 0x060034CC RID: 13516 RVA: 0x0000F138 File Offset: 0x0000D338
		[Token(Token = "0x170006BD")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x60034CC")]
			[Address(RVA = "0x53ABD0", Offset = "0x539BD0", VA = "0x18053ABD0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060034CD RID: 13517 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CD")]
		[Address(RVA = "0x2E97FC0", Offset = "0x2E96FC0", VA = "0x182E97FC0")]
		private void Start()
		{
		}

		// Token: 0x060034CE RID: 13518 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CE")]
		[Address(RVA = "0x2E979B0", Offset = "0x2E969B0", VA = "0x182E979B0")]
		private void OnDestroy()
		{
		}

		// Token: 0x060034CF RID: 13519 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034CF")]
		[Address(RVA = "0x2E97920", Offset = "0x2E96920", VA = "0x182E97920")]
		private static void BeforeLoadCleanUp()
		{
		}

		// Token: 0x060034D0 RID: 13520 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D0")]
		[Address(RVA = "0x2E98100", Offset = "0x2E97100", VA = "0x182E98100")]
		private void ToggleVerbose()
		{
		}

		// Token: 0x060034D1 RID: 13521 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D1")]
		[Address(RVA = "0x2E97AC0", Offset = "0x2E96AC0", VA = "0x182E97AC0")]
		public static void Register(ScrewTreeLinker treeLinker)
		{
		}

		// Token: 0x060034D2 RID: 13522 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D2")]
		[Address(RVA = "0x2E98150", Offset = "0x2E97150", VA = "0x182E98150")]
		public static void Unregister(ScrewTreeLinker treeLinker)
		{
		}

		// Token: 0x060034D3 RID: 13523 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60034D3")]
		[Address(RVA = "0x2E97D40", Offset = "0x2E96D40", VA = "0x182E97D40", Slot = "5")]
		private ScrewTreeLinkerSaveManager.TreeLinkerSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x060034D4 RID: 13524 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D4")]
		[Address(RVA = "0x2E97C10", Offset = "0x2E96C10", VA = "0x182E97C10", Slot = "6")]
		private void OnDeserialize(ScrewTreeLinkerSaveManager.TreeLinkerSaveData data)
		{
		}

		// Token: 0x060034D5 RID: 13525 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60034D5")]
		[Address(RVA = "0x539D00", Offset = "0x538D00", VA = "0x180539D00")]
		public ScrewTreeLinkerSaveManager()
		{
		}

		// Token: 0x04002D7E RID: 11646
		[Token(Token = "0x4002D7E")]
		[FieldOffset(Offset = "0x0")]
		private static bool Verbose;

		// Token: 0x04002D7F RID: 11647
		[Token(Token = "0x4002D7F")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<ScrewTreeLinker> _treeLinkers;

		// Token: 0x020007D1 RID: 2001
		[Token(Token = "0x20007D1")]
		[Serializable]
		public class TreeLinkerSaveData
		{
			// Token: 0x060034D7 RID: 13527 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60034D7")]
			[Address(RVA = "0x52F1B0", Offset = "0x52E1B0", VA = "0x18052F1B0")]
			public TreeLinkerSaveData()
			{
			}

			// Token: 0x04002D80 RID: 11648
			[Token(Token = "0x4002D80")]
			[FieldOffset(Offset = "0x10")]
			public List<ScrewTreeLinker.SaveData> _treeStructureData;
		}
	}
}
