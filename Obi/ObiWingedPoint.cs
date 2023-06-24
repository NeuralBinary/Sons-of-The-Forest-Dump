using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Obi
{
	// Token: 0x020001FC RID: 508
	[Token(Token = "0x20001FC")]
	[Serializable]
	public struct ObiWingedPoint
	{
		// Token: 0x170001A9 RID: 425
		// (get) Token: 0x06000A69 RID: 2665 RVA: 0x0000563C File Offset: 0x0000383C
		[Token(Token = "0x170001A9")]
		public Vector3 inTangentEndpoint
		{
			[Token(Token = "0x6000A69")]
			[Address(RVA = "0x281C800", Offset = "0x281AE00", VA = "0x18281C800")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x170001AA RID: 426
		// (get) Token: 0x06000A6A RID: 2666 RVA: 0x00005654 File Offset: 0x00003854
		[Token(Token = "0x170001AA")]
		public Vector3 outTangentEndpoint
		{
			[Token(Token = "0x6000A6A")]
			[Address(RVA = "0x281C860", Offset = "0x281AE60", VA = "0x18281C860")]
			get
			{
				return default(Vector3);
			}
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A6B")]
		[Address(RVA = "0x281C8C0", Offset = "0x281AEC0", VA = "0x18281C8C0")]
		public ObiWingedPoint(Vector3 inTangent, Vector3 point, Vector3 outTangent)
		{
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A6C")]
		[Address(RVA = "0x281C900", Offset = "0x281AF00", VA = "0x18281C900")]
		public void SetInTangentEndpoint(Vector3 value)
		{
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A6D")]
		[Address(RVA = "0x281CAD0", Offset = "0x281B0D0", VA = "0x18281CAD0")]
		public void SetOutTangentEndpoint(Vector3 value)
		{
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x000020F6 File Offset: 0x000002F6
		[Token(Token = "0x6000A6E")]
		[Address(RVA = "0x281CCA0", Offset = "0x281B2A0", VA = "0x18281CCA0")]
		public void Transform(Vector3 translation, Quaternion rotation, Vector3 scale)
		{
		}

		// Token: 0x04000841 RID: 2113
		[Token(Token = "0x4000841")]
		[FieldOffset(Offset = "0x0")]
		public ObiWingedPoint.TangentMode tangentMode;

		// Token: 0x04000842 RID: 2114
		[Token(Token = "0x4000842")]
		[FieldOffset(Offset = "0x4")]
		public Vector3 inTangent;

		// Token: 0x04000843 RID: 2115
		[Token(Token = "0x4000843")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 position;

		// Token: 0x04000844 RID: 2116
		[Token(Token = "0x4000844")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 outTangent;

		// Token: 0x020001FD RID: 509
		[Token(Token = "0x20001FD")]
		public enum TangentMode
		{
			// Token: 0x04000846 RID: 2118
			[Token(Token = "0x4000846")]
			Aligned,
			// Token: 0x04000847 RID: 2119
			[Token(Token = "0x4000847")]
			Mirrored,
			// Token: 0x04000848 RID: 2120
			[Token(Token = "0x4000848")]
			Free
		}
	}
}
