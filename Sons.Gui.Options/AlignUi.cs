using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Gui.Options
{
	// Token: 0x02000005 RID: 5
	[Token(Token = "0x2000005")]
	[AddComponentMenu("Sons/Gui/AlignUi")]
	public class AlignUi : MonoBehaviour
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000007")]
		[Address(RVA = "0x3038E00", Offset = "0x3037400", VA = "0x183038E00")]
		private void OnEnable()
		{
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000008")]
		[Address(RVA = "0x3038E00", Offset = "0x3037400", VA = "0x183038E00")]
		private void DoAlign()
		{
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000009")]
		[Address(RVA = "0x3038E70", Offset = "0x3037470", VA = "0x183038E70")]
		private void AlignHorizontal()
		{
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000A")]
		[Address(RVA = "0x3039050", Offset = "0x3037650", VA = "0x183039050")]
		private void AlignVertical()
		{
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600000B")]
		[Address(RVA = "0x59F410", Offset = "0x59DA10", VA = "0x18059F410")]
		public AlignUi()
		{
		}

		// Token: 0x0400000B RID: 11
		[Token(Token = "0x400000B")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private RectTransform _target;

		// Token: 0x0400000C RID: 12
		[Token(Token = "0x400000C")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private AlignUi.AlignType _alignType;

		// Token: 0x0400000D RID: 13
		[Token(Token = "0x400000D")]
		[FieldOffset(Offset = "0x2C")]
		private Vector3 _rectPosition;

		// Token: 0x02000006 RID: 6
		[Token(Token = "0x2000006")]
		internal enum AlignType
		{
			// Token: 0x0400000F RID: 15
			[Token(Token = "0x400000F")]
			Vertical,
			// Token: 0x04000010 RID: 16
			[Token(Token = "0x4000010")]
			Horizontal
		}
	}
}
