using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Cutscenes
{
	// Token: 0x02000772 RID: 1906
	[Token(Token = "0x2000772")]
	public class HelicopterTreeCrashCutscene : CrashCutsceneBase
	{
		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x0600320D RID: 12813 RVA: 0x0000E538 File Offset: 0x0000C738
		[Token(Token = "0x17000651")]
		public override int PlayerBadGuyIntroHash
		{
			[Token(Token = "0x600320D")]
			[Address(RVA = "0x2E46630", Offset = "0x2E45630", VA = "0x182E46630", Slot = "15")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x0600320E RID: 12814 RVA: 0x0000E550 File Offset: 0x0000C750
		[Token(Token = "0x17000652")]
		public override int PlayerProxyCrashTagHash
		{
			[Token(Token = "0x600320E")]
			[Address(RVA = "0x2E46690", Offset = "0x2E45690", VA = "0x182E46690", Slot = "16")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x0600320F RID: 12815 RVA: 0x0000E568 File Offset: 0x0000C768
		[Token(Token = "0x17000653")]
		public override int StandUpFromCrashIndex
		{
			[Token(Token = "0x600320F")]
			[Address(RVA = "0x6206B0", Offset = "0x61F6B0", VA = "0x1806206B0", Slot = "17")]
			get
			{
				return default(int);
			}
		}

		// Token: 0x06003210 RID: 12816 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003210")]
		[Address(RVA = "0x2E465E0", Offset = "0x2E455E0", VA = "0x182E465E0", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003211")]
		[Address(RVA = "0x2E464E0", Offset = "0x2E454E0", VA = "0x182E464E0", Slot = "13")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003212")]
		[Address(RVA = "0x2E465B0", Offset = "0x2E455B0", VA = "0x182E465B0")]
		public void EquipKnife()
		{
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003213")]
		[Address(RVA = "0x2E3EBA0", Offset = "0x2E3DBA0", VA = "0x182E3EBA0")]
		public HelicopterTreeCrashCutscene()
		{
		}

		// Token: 0x04002BA6 RID: 11174
		[Token(Token = "0x4002BA6")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private GameObject _knifeObject;

		// Token: 0x04002BA7 RID: 11175
		[Token(Token = "0x4002BA7")]
		[FieldOffset(Offset = "0x198")]
		[FormerlySerializedAs("_TreeObject")]
		[SerializeField]
		private GameObject _treeObject;
	}
}
