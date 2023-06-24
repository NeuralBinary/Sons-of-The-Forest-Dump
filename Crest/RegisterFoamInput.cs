using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x0200004A RID: 74
	[Token(Token = "0x200004A")]
	[ExecuteAlways]
	public class RegisterFoamInput : RegisterLodDataInputDisplacementCorrection<LodDataMgrFoam>
	{
		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00002AF0 File Offset: 0x00000CF0
		[Token(Token = "0x17000062")]
		public override bool Enabled
		{
			[Token(Token = "0x60001B9")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00002B08 File Offset: 0x00000D08
		[Token(Token = "0x17000063")]
		public override float Wavelength
		{
			[Token(Token = "0x60001BA")]
			[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "7")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00002B20 File Offset: 0x00000D20
		[Token(Token = "0x17000064")]
		protected override Color GizmoColor
		{
			[Token(Token = "0x60001BB")]
			[Address(RVA = "0x9F9320", Offset = "0x9F7920", VA = "0x1809F9320", Slot = "13")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000065")]
		protected override string ShaderPrefix
		{
			[Token(Token = "0x60001BC")]
			[Address(RVA = "0x9F9340", Offset = "0x9F7940", VA = "0x1809F9340", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001BD")]
		[Address(RVA = "0x9F9370", Offset = "0x9F7970", VA = "0x1809F9370")]
		public RegisterFoamInput()
		{
		}
	}
}
