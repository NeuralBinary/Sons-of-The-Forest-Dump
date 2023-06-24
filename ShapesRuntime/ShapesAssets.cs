using System;
using Il2CppDummyDll;
using TMPro;
using UnityEngine;

namespace Shapes
{
	// Token: 0x0200007B RID: 123
	[Token(Token = "0x200007B")]
	public class ShapesAssets : ScriptableObject
	{
		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000BFF RID: 3071 RVA: 0x0000210E File Offset: 0x0000030E
		[Token(Token = "0x170001C1")]
		public static ShapesAssets Instance
		{
			[Token(Token = "0x6000BFF")]
			[Address(RVA = "0x2A49C80", Offset = "0x2A48280", VA = "0x182A49C80")]
			get
			{
				return null;
			}
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000C00")]
		[Address(RVA = "0x2A49DF0", Offset = "0x2A483F0", VA = "0x182A49DF0")]
		public ShapesAssets()
		{
		}

		// Token: 0x04000277 RID: 631
		[Token(Token = "0x4000277")]
		[FieldOffset(Offset = "0x18")]
		[Header("Config")]
		public TMP_FontAsset defaultFont;

		// Token: 0x04000278 RID: 632
		[Token(Token = "0x4000278")]
		[FieldOffset(Offset = "0x20")]
		[Header("Meshes")]
		public Mesh[] meshQuad;

		// Token: 0x04000279 RID: 633
		[Token(Token = "0x4000279")]
		[FieldOffset(Offset = "0x28")]
		public Mesh[] meshTriangle;

		// Token: 0x0400027A RID: 634
		[Token(Token = "0x400027A")]
		[FieldOffset(Offset = "0x30")]
		public Mesh[] meshCube;

		// Token: 0x0400027B RID: 635
		[Token(Token = "0x400027B")]
		[FieldOffset(Offset = "0x38")]
		public Mesh[] meshSphere;

		// Token: 0x0400027C RID: 636
		[Token(Token = "0x400027C")]
		[FieldOffset(Offset = "0x40")]
		public Mesh[] meshTorus;

		// Token: 0x0400027D RID: 637
		[Token(Token = "0x400027D")]
		[FieldOffset(Offset = "0x48")]
		public Mesh[] meshCapsule;

		// Token: 0x0400027E RID: 638
		[Token(Token = "0x400027E")]
		[FieldOffset(Offset = "0x50")]
		public Mesh[] meshCylinder;

		// Token: 0x0400027F RID: 639
		[Token(Token = "0x400027F")]
		[FieldOffset(Offset = "0x58")]
		public Mesh[] meshCone;

		// Token: 0x04000280 RID: 640
		[Token(Token = "0x4000280")]
		[FieldOffset(Offset = "0x60")]
		public Mesh[] meshConeUncapped;

		// Token: 0x04000281 RID: 641
		[Token(Token = "0x4000281")]
		[FieldOffset(Offset = "0x68")]
		[Header("Misc")]
		public TextAsset packageJson;

		// Token: 0x04000282 RID: 642
		[Token(Token = "0x4000282")]
		[FieldOffset(Offset = "0x0")]
		private static ShapesAssets inst;
	}
}
