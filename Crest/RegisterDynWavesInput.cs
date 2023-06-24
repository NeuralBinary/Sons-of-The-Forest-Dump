using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000048 RID: 72
	[Token(Token = "0x2000048")]
	[ExecuteAlways]
	public class RegisterDynWavesInput : RegisterLodDataInput<LodDataMgrDynWaves>
	{
		// Token: 0x1700005A RID: 90
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00002A60 File Offset: 0x00000C60
		[Token(Token = "0x1700005A")]
		public override float Wavelength
		{
			[Token(Token = "0x60001AF")]
			[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "7")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x00002A78 File Offset: 0x00000C78
		[Token(Token = "0x1700005B")]
		public override bool Enabled
		{
			[Token(Token = "0x60001B0")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x00002A90 File Offset: 0x00000C90
		[Token(Token = "0x1700005C")]
		protected override Color GizmoColor
		{
			[Token(Token = "0x60001B1")]
			[Address(RVA = "0x9F91F0", Offset = "0x9F77F0", VA = "0x1809F91F0", Slot = "13")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x1700005D")]
		protected override string ShaderPrefix
		{
			[Token(Token = "0x60001B2")]
			[Address(RVA = "0x9F9210", Offset = "0x9F7810", VA = "0x1809F9210", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B3")]
		[Address(RVA = "0x9F9240", Offset = "0x9F7840", VA = "0x1809F9240")]
		public RegisterDynWavesInput()
		{
		}
	}
}
