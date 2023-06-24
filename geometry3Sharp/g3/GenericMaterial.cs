using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;

namespace g3
{
	// Token: 0x02000192 RID: 402
	[Token(Token = "0x2000192")]
	public abstract class GenericMaterial
	{
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000B0C RID: 2828
		// (set) Token: 0x06000B0D RID: 2829
		[Token(Token = "0x170001F5")]
		public abstract Vector3f DiffuseColor { [Token(Token = "0x6000B0C")] get; [Token(Token = "0x6000B0D")] set; }

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000B0E RID: 2830
		// (set) Token: 0x06000B0F RID: 2831
		[Token(Token = "0x170001F6")]
		public abstract float Alpha { [Token(Token = "0x6000B0E")] get; [Token(Token = "0x6000B0F")] set; }

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000B10 RID: 2832 RVA: 0x00008294 File Offset: 0x00006494
		// (set) Token: 0x06000B11 RID: 2833 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x170001F7")]
		public GenericMaterial.KnownMaterialTypes Type
		{
			[Token(Token = "0x6000B10")]
			[Address(RVA = "0x9FA1D0", Offset = "0x9F87D0", VA = "0x1809FA1D0")]
			[CompilerGenerated]
			get
			{
				return GenericMaterial.KnownMaterialTypes.OBJ_MTL_Format;
			}
			[Token(Token = "0x6000B11")]
			[Address(RVA = "0xA7FDD0", Offset = "0xA7E3D0", VA = "0x180A7FDD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06000B12 RID: 2834 RVA: 0x00002066 File Offset: 0x00000266
		[Token(Token = "0x6000B12")]
		[Address(RVA = "0x59F160", Offset = "0x59D760", VA = "0x18059F160")]
		protected GenericMaterial()
		{
		}

		// Token: 0x0400063D RID: 1597
		[Token(Token = "0x400063D")]
		[FieldOffset(Offset = "0x0")]
		public static readonly float Invalidf;

		// Token: 0x0400063E RID: 1598
		[Token(Token = "0x400063E")]
		[FieldOffset(Offset = "0x4")]
		public static readonly Vector3f Invalid;

		// Token: 0x0400063F RID: 1599
		[Token(Token = "0x400063F")]
		[FieldOffset(Offset = "0x10")]
		public string name;

		// Token: 0x04000640 RID: 1600
		[Token(Token = "0x4000640")]
		[FieldOffset(Offset = "0x18")]
		public int id;

		// Token: 0x02000193 RID: 403
		[Token(Token = "0x2000193")]
		public enum KnownMaterialTypes
		{
			// Token: 0x04000643 RID: 1603
			[Token(Token = "0x4000643")]
			OBJ_MTL_Format
		}
	}
}
