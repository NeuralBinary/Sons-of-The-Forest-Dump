using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x020001D0 RID: 464
	[Token(Token = "0x20001D0")]
	[AddComponentMenu("Sons/Construction/FakePilarStructure")]
	public class FakePilarStructure : PilarStructure
	{
		// Token: 0x1700033F RID: 831
		// (get) Token: 0x06000DB2 RID: 3506 RVA: 0x0000872C File Offset: 0x0000692C
		[Token(Token = "0x1700033F")]
		public override ushort TypeID
		{
			[Token(Token = "0x6000DB2")]
			[Address(RVA = "0x67D850", Offset = "0x67BE50", VA = "0x18067D850", Slot = "47")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000340 RID: 832
		// (get) Token: 0x06000DB3 RID: 3507 RVA: 0x00002068 File Offset: 0x00000268
		[Token(Token = "0x17000340")]
		public new static Counter Counter
		{
			[Token(Token = "0x6000DB3")]
			[Address(RVA = "0x2ED76C0", Offset = "0x2ED5CC0", VA = "0x182ED76C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DB4")]
		[Address(RVA = "0x2ED7710", Offset = "0x2ED5D10", VA = "0x182ED7710", Slot = "65")]
		public override void OnLinkedStructuresChanged()
		{
		}

		// Token: 0x06000DB5 RID: 3509 RVA: 0x00008744 File Offset: 0x00006944
		[Token(Token = "0x6000DB5")]
		[Address(RVA = "0x2ED7F40", Offset = "0x2ED6540", VA = "0x182ED7F40")]
		private bool TryGetSingleLinkedBeam(out Structure linkedStructure)
		{
			return default(bool);
		}

		// Token: 0x06000DB6 RID: 3510 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DB6")]
		[Address(RVA = "0x2ED81A0", Offset = "0x2ED67A0", VA = "0x182ED81A0")]
		public void CastBackToTerrain()
		{
		}

		// Token: 0x06000DB7 RID: 3511 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DB7")]
		[Address(RVA = "0x2ED86C0", Offset = "0x2ED6CC0", VA = "0x182ED86C0")]
		public FakePilarStructure()
		{
		}

		// Token: 0x06000DB9 RID: 3513 RVA: 0x0000875C File Offset: 0x0000695C
		[Token(Token = "0x6000DB9")]
		[Address(RVA = "0x2ED87C0", Offset = "0x2ED6DC0", VA = "0x182ED87C0")]
		[CompilerGenerated]
		private bool <OnLinkedStructuresChanged>g__IsWaterBorne|5_0(ref FakePilarStructure.<>c__DisplayClass5_0 A_1)
		{
			return default(bool);
		}

		// Token: 0x06000DBA RID: 3514 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000DBA")]
		[Address(RVA = "0x2ED8850", Offset = "0x2ED6E50", VA = "0x182ED8850")]
		[CompilerGenerated]
		private void <OnLinkedStructuresChanged>g__RemoveFakePilarElement|5_1(ref FakePilarStructure.<>c__DisplayClass5_0 A_1)
		{
		}

		// Token: 0x06000DBB RID: 3515 RVA: 0x00008774 File Offset: 0x00006974
		[Token(Token = "0x6000DBB")]
		[Address(RVA = "0x2ED8980", Offset = "0x2ED6F80", VA = "0x182ED8980")]
		[CompilerGenerated]
		private bool <OnLinkedStructuresChanged>g__IsSoloGroundedBeam|5_2(out FakePilarStructure otherFp, ref FakePilarStructure.<>c__DisplayClass5_0 A_2)
		{
			return default(bool);
		}
	}
}
