using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Construction
{
	// Token: 0x0200006C RID: 108
	[Token(Token = "0x200006C")]
	[CreateAssetMenu(menuName = "Sons/Construction/PresetElementsTemplateNotchingCondition")]
	public class PresetElementsTemplateNotchingCondition : PresetElementsTemplateConditionBase
	{
		// Token: 0x060002BF RID: 703 RVA: 0x000034AC File Offset: 0x000016AC
		[Token(Token = "0x60002BF")]
		[Address(RVA = "0x2D7C9D0", Offset = "0x2D7AFD0", VA = "0x182D7C9D0", Slot = "4")]
		public override bool IsValid(IStructure structure)
		{
			return default(bool);
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60002C0")]
		[Address(RVA = "0x5AC330", Offset = "0x5AA930", VA = "0x1805AC330")]
		public PresetElementsTemplateNotchingCondition()
		{
		}

		// Token: 0x040002B8 RID: 696
		[Token(Token = "0x40002B8")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private PresetElementsTemplateNotchingCondition.NotchCondition[] _notchConditions;

		// Token: 0x0200006D RID: 109
		[Token(Token = "0x200006D")]
		[Serializable]
		public class NotchCondition
		{
			// Token: 0x060002C1 RID: 705 RVA: 0x000034C4 File Offset: 0x000016C4
			[Token(Token = "0x60002C1")]
			[Address(RVA = "0x2D7CB10", Offset = "0x2D7B110", VA = "0x182D7CB10")]
			public bool IsValid(IStructure structure)
			{
				return default(bool);
			}

			// Token: 0x060002C2 RID: 706 RVA: 0x00002066 File Offset: 0x00000266
			[Token(Token = "0x60002C2")]
			[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
			public NotchCondition()
			{
			}

			// Token: 0x040002B9 RID: 697
			[Token(Token = "0x40002B9")]
			[FieldOffset(Offset = "0x10")]
			[SerializeField]
			private int _elementNum;

			// Token: 0x040002BA RID: 698
			[Token(Token = "0x40002BA")]
			[FieldOffset(Offset = "0x14")]
			[SerializeField]
			private Notches _notches;
		}
	}
}
