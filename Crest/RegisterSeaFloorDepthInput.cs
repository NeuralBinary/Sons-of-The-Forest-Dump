using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x0200004E RID: 78
	[Token(Token = "0x200004E")]
	[ExecuteAlways]
	public class RegisterSeaFloorDepthInput : RegisterLodDataInput<LodDataMgrSeaFloorDepth>
	{
		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00002B80 File Offset: 0x00000D80
		[Token(Token = "0x1700006C")]
		public override bool Enabled
		{
			[Token(Token = "0x60001D3")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x00002B98 File Offset: 0x00000D98
		[Token(Token = "0x1700006D")]
		public override float Wavelength
		{
			[Token(Token = "0x60001D4")]
			[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "7")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00002BB0 File Offset: 0x00000DB0
		[Token(Token = "0x1700006E")]
		protected override Color GizmoColor
		{
			[Token(Token = "0x60001D5")]
			[Address(RVA = "0x9FA020", Offset = "0x9F8620", VA = "0x1809FA020", Slot = "13")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x1700006F")]
		protected override string ShaderPrefix
		{
			[Token(Token = "0x60001D6")]
			[Address(RVA = "0x9FA040", Offset = "0x9F8640", VA = "0x1809FA040", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D7")]
		[Address(RVA = "0x9FA070", Offset = "0x9F8670", VA = "0x1809FA070", Slot = "14")]
		protected override void OnEnable()
		{
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001D8")]
		[Address(RVA = "0x9FA180", Offset = "0x9F8780", VA = "0x1809FA180")]
		public RegisterSeaFloorDepthInput()
		{
		}

		// Token: 0x04000158 RID: 344
		[Token(Token = "0x4000158")]
		[FieldOffset(Offset = "0x40")]
		public bool _assignOceanDepthMaterial;
	}
}
