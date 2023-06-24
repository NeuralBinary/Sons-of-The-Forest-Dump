using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using Sons.Save;

namespace Sons.Gameplay
{
	// Token: 0x020007C8 RID: 1992
	[Token(Token = "0x20007C8")]
	public class RainCatcherSaveManager : SingletonBehaviour<RainCatcherSaveManager>, ISaveGameSerializer<RainCatcherSaveManager.RainCatcherManagerSaveData>
	{
		// Token: 0x170006BE RID: 1726
		// (get) Token: 0x060035BE RID: 13758 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170006BE")]
		private string SerializedName
		{
			[Token(Token = "0x60035BE")]
			[Address(RVA = "0x34E8490", Offset = "0x34E6A90", VA = "0x1834E8490", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x060035BF RID: 13759 RVA: 0x000100F8 File Offset: 0x0000E2F8
		[Token(Token = "0x170006BF")]
		private bool UniqueFile
		{
			[Token(Token = "0x60035BF")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "13")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006C0 RID: 1728
		// (get) Token: 0x060035C0 RID: 13760 RVA: 0x00010110 File Offset: 0x0000E310
		[Token(Token = "0x170006C0")]
		private bool ShouldSerialize
		{
			[Token(Token = "0x60035C0")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "14")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170006C1 RID: 1729
		// (get) Token: 0x060035C1 RID: 13761 RVA: 0x00010128 File Offset: 0x0000E328
		[Token(Token = "0x170006C1")]
		private bool IncludeInPlayerSave
		{
			[Token(Token = "0x60035C1")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "15")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060035C2 RID: 13762 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C2")]
		[Address(RVA = "0x34E84C0", Offset = "0x34E6AC0", VA = "0x1834E84C0")]
		private void Start()
		{
		}

		// Token: 0x060035C3 RID: 13763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C3")]
		[Address(RVA = "0x34E85F0", Offset = "0x34E6BF0", VA = "0x1834E85F0", Slot = "9")]
		protected override void PostOnDestroy()
		{
		}

		// Token: 0x060035C4 RID: 13764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C4")]
		[Address(RVA = "0x34E86A0", Offset = "0x34E6CA0", VA = "0x1834E86A0")]
		private void BeforeLoadCleanUp()
		{
		}

		// Token: 0x060035C5 RID: 13765 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C5")]
		[Address(RVA = "0x34E8730", Offset = "0x34E6D30", VA = "0x1834E8730")]
		private void ToggleVerbose()
		{
		}

		// Token: 0x060035C6 RID: 13766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C6")]
		[Address(RVA = "0x34E8780", Offset = "0x34E6D80", VA = "0x1834E8780")]
		public static void Register(RainCatcher rainCatcher)
		{
		}

		// Token: 0x060035C7 RID: 13767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C7")]
		[Address(RVA = "0x34E88B0", Offset = "0x34E6EB0", VA = "0x1834E88B0")]
		public static void Unregister(RainCatcher rainCatcher)
		{
		}

		// Token: 0x060035C8 RID: 13768 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60035C8")]
		[Address(RVA = "0x34E89A0", Offset = "0x34E6FA0", VA = "0x1834E89A0", Slot = "11")]
		private RainCatcherSaveManager.RainCatcherManagerSaveData OnSerialize()
		{
			return null;
		}

		// Token: 0x060035C9 RID: 13769 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035C9")]
		[Address(RVA = "0x34E8CB0", Offset = "0x34E72B0", VA = "0x1834E8CB0", Slot = "12")]
		private void OnDeserialize(RainCatcherSaveManager.RainCatcherManagerSaveData data)
		{
		}

		// Token: 0x060035CA RID: 13770 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60035CA")]
		[Address(RVA = "0x34E8DE0", Offset = "0x34E73E0", VA = "0x1834E8DE0")]
		public RainCatcherSaveManager()
		{
		}

		// Token: 0x04002E6B RID: 11883
		[Token(Token = "0x4002E6B")]
		[FieldOffset(Offset = "0x0")]
		private static bool Verbose;

		// Token: 0x04002E6C RID: 11884
		[Token(Token = "0x4002E6C")]
		[FieldOffset(Offset = "0x8")]
		private static readonly List<RainCatcher> _rainCatchers;

		// Token: 0x020007C9 RID: 1993
		[Token(Token = "0x20007C9")]
		[Serializable]
		public class RainCatcherManagerSaveData
		{
			// Token: 0x060035CC RID: 13772 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60035CC")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public RainCatcherManagerSaveData()
			{
			}

			// Token: 0x04002E6D RID: 11885
			[Token(Token = "0x4002E6D")]
			[FieldOffset(Offset = "0x10")]
			public List<RainCatcher.RainCatcherData> _rainCatchersData;
		}
	}
}
