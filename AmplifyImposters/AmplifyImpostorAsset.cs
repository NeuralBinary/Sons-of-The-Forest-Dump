using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace AmplifyImpostors
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[CreateAssetMenu(fileName = "New Impostor", order = 85)]
	public class AmplifyImpostorAsset : ScriptableObject
	{
		// Token: 0x06000017 RID: 23 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000017")]
		[Address(RVA = "0x5B8130", Offset = "0x5B6730", VA = "0x1805B8130")]
		public AmplifyImpostorAsset()
		{
		}

		// Token: 0x0400004E RID: 78
		[Token(Token = "0x400004E")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		public Material Material;

		// Token: 0x0400004F RID: 79
		[Token(Token = "0x400004F")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		public Mesh Mesh;

		// Token: 0x04000050 RID: 80
		[Token(Token = "0x4000050")]
		[FieldOffset(Offset = "0x28")]
		[HideInInspector]
		[SerializeField]
		public int Version;

		// Token: 0x04000051 RID: 81
		[Token(Token = "0x4000051")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		public ImpostorType ImpostorType;

		// Token: 0x04000052 RID: 82
		[Token(Token = "0x4000052")]
		[FieldOffset(Offset = "0x30")]
		[HideInInspector]
		[SerializeField]
		public bool LockedSizes;

		// Token: 0x04000053 RID: 83
		[Token(Token = "0x4000053")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		[HideInInspector]
		public int SelectedSize;

		// Token: 0x04000054 RID: 84
		[Token(Token = "0x4000054")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		public Vector2 TexSize;

		// Token: 0x04000055 RID: 85
		[Token(Token = "0x4000055")]
		[FieldOffset(Offset = "0x40")]
		[HideInInspector]
		[SerializeField]
		public bool DecoupleAxisFrames;

		// Token: 0x04000056 RID: 86
		[Token(Token = "0x4000056")]
		[FieldOffset(Offset = "0x44")]
		[Range(1f, 32f)]
		[SerializeField]
		public int HorizontalFrames;

		// Token: 0x04000057 RID: 87
		[Token(Token = "0x4000057")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Range(1f, 33f)]
		public int VerticalFrames;

		// Token: 0x04000058 RID: 88
		[Token(Token = "0x4000058")]
		[FieldOffset(Offset = "0x4C")]
		[Range(0f, 64f)]
		[SerializeField]
		public int PixelPadding;

		// Token: 0x04000059 RID: 89
		[Token(Token = "0x4000059")]
		[FieldOffset(Offset = "0x50")]
		[SerializeField]
		[Range(4f, 16f)]
		public int MaxVertices;

		// Token: 0x0400005A RID: 90
		[Token(Token = "0x400005A")]
		[FieldOffset(Offset = "0x54")]
		[SerializeField]
		[Range(0f, 0.2f)]
		public float Tolerance;

		// Token: 0x0400005B RID: 91
		[Token(Token = "0x400005B")]
		[FieldOffset(Offset = "0x58")]
		[Range(0f, 1f)]
		[SerializeField]
		public float NormalScale;

		// Token: 0x0400005C RID: 92
		[Token(Token = "0x400005C")]
		[FieldOffset(Offset = "0x60")]
		[SerializeField]
		public Vector2[] ShapePoints;

		// Token: 0x0400005D RID: 93
		[Token(Token = "0x400005D")]
		[FieldOffset(Offset = "0x68")]
		[SerializeField]
		public AmplifyImpostorBakePreset Preset;

		// Token: 0x0400005E RID: 94
		[Token(Token = "0x400005E")]
		[FieldOffset(Offset = "0x70")]
		[SerializeField]
		public List<TextureOutput> OverrideOutput;
	}
}
