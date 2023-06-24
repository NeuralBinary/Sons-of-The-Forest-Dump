using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000049 RID: 73
	[Token(Token = "0x2000049")]
	[ExecuteAlways]
	public class RegisterFlowInput : RegisterLodDataInputDisplacementCorrection<LodDataMgrFlow>
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00002AA8 File Offset: 0x00000CA8
		[Token(Token = "0x1700005E")]
		public override bool Enabled
		{
			[Token(Token = "0x60001B4")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00002AC0 File Offset: 0x00000CC0
		[Token(Token = "0x1700005F")]
		public override float Wavelength
		{
			[Token(Token = "0x60001B5")]
			[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "7")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00002AD8 File Offset: 0x00000CD8
		[Token(Token = "0x17000060")]
		protected override Color GizmoColor
		{
			[Token(Token = "0x60001B6")]
			[Address(RVA = "0x9F9280", Offset = "0x9F7880", VA = "0x1809F9280", Slot = "13")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000061")]
		protected override string ShaderPrefix
		{
			[Token(Token = "0x60001B7")]
			[Address(RVA = "0x9F92A0", Offset = "0x9F78A0", VA = "0x1809F92A0", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001B8")]
		[Address(RVA = "0x9F92D0", Offset = "0x9F78D0", VA = "0x1809F92D0")]
		public RegisterFlowInput()
		{
		}
	}
}
