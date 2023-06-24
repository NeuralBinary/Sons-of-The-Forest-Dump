using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Serialization;

namespace Sons.Cutscenes
{
	// Token: 0x0200067D RID: 1661
	[Token(Token = "0x200067D")]
	public class HelicopterTreeCrashCutscene : CrashCutsceneBase
	{
		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06002B84 RID: 11140 RVA: 0x0000CE10 File Offset: 0x0000B010
		[Token(Token = "0x170005BE")]
		public override int PlayerBadGuyIntroHash
		{
			[Token(Token = "0x6002B84")]
			[Address(RVA = "0x3410250", Offset = "0x340E850", VA = "0x183410250", Slot = "15")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06002B85 RID: 11141 RVA: 0x0000CE28 File Offset: 0x0000B028
		[Token(Token = "0x170005BF")]
		public override int PlayerProxyCrashTagHash
		{
			[Token(Token = "0x6002B85")]
			[Address(RVA = "0x34102B0", Offset = "0x340E8B0", VA = "0x1834102B0", Slot = "16")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x06002B86 RID: 11142 RVA: 0x0000CE40 File Offset: 0x0000B040
		[Token(Token = "0x170005C0")]
		public override int StandUpFromCrashIndex
		{
			[Token(Token = "0x6002B86")]
			[Address(RVA = "0x6A2B30", Offset = "0x6A1130", VA = "0x1806A2B30", Slot = "17")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002B87 RID: 11143 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B87")]
		[Address(RVA = "0x3410310", Offset = "0x340E910", VA = "0x183410310", Slot = "7")]
		protected override void PostStartHook()
		{
		}

		// Token: 0x06002B88 RID: 11144 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B88")]
		[Address(RVA = "0x3410360", Offset = "0x340E960", VA = "0x183410360", Slot = "13")]
		protected override void Cleanup()
		{
		}

		// Token: 0x06002B89 RID: 11145 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B89")]
		[Address(RVA = "0x3410530", Offset = "0x340EB30", VA = "0x183410530")]
		public void EquipKnife()
		{
		}

		// Token: 0x06002B8A RID: 11146 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002B8A")]
		[Address(RVA = "0x3402A90", Offset = "0x3401090", VA = "0x183402A90")]
		public HelicopterTreeCrashCutscene()
		{
		}

		// Token: 0x04002679 RID: 9849
		[Token(Token = "0x4002679")]
		[FieldOffset(Offset = "0x190")]
		[SerializeField]
		private GameObject _knifeObject;

		// Token: 0x0400267A RID: 9850
		[Token(Token = "0x400267A")]
		[FieldOffset(Offset = "0x198")]
		[SerializeField]
		[FormerlySerializedAs("_TreeObject")]
		private GameObject _treeObject;
	}
}
