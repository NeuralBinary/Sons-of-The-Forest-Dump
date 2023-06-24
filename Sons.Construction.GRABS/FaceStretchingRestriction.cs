using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Construction.GRABS
{
	// Token: 0x02000055 RID: 85
	[Token(Token = "0x2000055")]
	public class FaceStretchingRestriction
	{
		// Token: 0x06000229 RID: 553 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000229")]
		[Address(RVA = "0x2DA9DE0", Offset = "0x2DA83E0", VA = "0x182DA9DE0")]
		public FaceStretchingRestriction(BlueprintFace face)
		{
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00002BDC File Offset: 0x00000DDC
		[Token(Token = "0x600022A")]
		[Address(RVA = "0x2DA9FF0", Offset = "0x2DA85F0", VA = "0x182DA9FF0")]
		public Vector3 ClampWithinFoundations(Vector3 onFaceForwardAxisPos)
		{
			return default(Vector3);
		}

		// Token: 0x040000F9 RID: 249
		[Token(Token = "0x40000F9")]
		[FieldOffset(Offset = "0x10")]
		private readonly BlueprintFace _face;

		// Token: 0x040000FA RID: 250
		[Token(Token = "0x40000FA")]
		[FieldOffset(Offset = "0x18")]
		private readonly float _minBlueprintLocalPosition;

		// Token: 0x040000FB RID: 251
		[Token(Token = "0x40000FB")]
		[FieldOffset(Offset = "0x1C")]
		private readonly float _maxBlueprintLocalPosition;

		// Token: 0x040000FC RID: 252
		[Token(Token = "0x40000FC")]
		[FieldOffset(Offset = "0x20")]
		private readonly BlueprintTilesSearcher _blueprintTilesSearcher;
	}
}
