using System;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x020002BA RID: 698
	[Token(Token = "0x20002BA")]
	public class TrivialRectGenerator : MeshGenerator
	{
		// Token: 0x060018CC RID: 6348 RVA: 0x000124AC File Offset: 0x000106AC
		[Token(Token = "0x60018CC")]
		[Address(RVA = "0x1EE3A90", Offset = "0x1EE2090", VA = "0x181EE3A90", Slot = "11")]
		protected virtual Vector3d make_vertex(float x, float y)
		{
			return default(Vector3d);
		}

		// Token: 0x060018CD RID: 6349 RVA: 0x0000207E File Offset: 0x0000027E
		[Token(Token = "0x60018CD")]
		[Address(RVA = "0x1EE3BE0", Offset = "0x1EE21E0", VA = "0x181EE3BE0", Slot = "4")]
		public override MeshGenerator Generate()
		{
			return null;
		}

		// Token: 0x060018CE RID: 6350 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x60018CE")]
		[Address(RVA = "0x1EE46E0", Offset = "0x1EE2CE0", VA = "0x181EE46E0")]
		public TrivialRectGenerator()
		{
		}

		// Token: 0x04000C11 RID: 3089
		[Token(Token = "0x4000C11")]
		[FieldOffset(Offset = "0x40")]
		public float Width;

		// Token: 0x04000C12 RID: 3090
		[Token(Token = "0x4000C12")]
		[FieldOffset(Offset = "0x44")]
		public float Height;

		// Token: 0x04000C13 RID: 3091
		[Token(Token = "0x4000C13")]
		[FieldOffset(Offset = "0x48")]
		public Vector3f Normal;

		// Token: 0x04000C14 RID: 3092
		[Token(Token = "0x4000C14")]
		[FieldOffset(Offset = "0x54")]
		public Index2i IndicesMap;

		// Token: 0x04000C15 RID: 3093
		[Token(Token = "0x4000C15")]
		[FieldOffset(Offset = "0x5C")]
		public TrivialRectGenerator.UVModes UVMode;

		// Token: 0x020002BB RID: 699
		[Token(Token = "0x20002BB")]
		public enum UVModes
		{
			// Token: 0x04000C17 RID: 3095
			[Token(Token = "0x4000C17")]
			FullUVSquare,
			// Token: 0x04000C18 RID: 3096
			[Token(Token = "0x4000C18")]
			CenteredUVRectangle,
			// Token: 0x04000C19 RID: 3097
			[Token(Token = "0x4000C19")]
			BottomCornerUVRectangle
		}
	}
}
