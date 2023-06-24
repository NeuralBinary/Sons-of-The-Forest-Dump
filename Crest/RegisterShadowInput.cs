using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000056 RID: 86
	[Token(Token = "0x2000056")]
	[ExecuteAlways]
	public class RegisterShadowInput : RegisterLodDataInput<LodDataMgrShadow>
	{
		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00002C88 File Offset: 0x00000E88
		[Token(Token = "0x17000078")]
		public override bool Enabled
		{
			[Token(Token = "0x60001F8")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00002CA0 File Offset: 0x00000EA0
		[Token(Token = "0x17000079")]
		public override float Wavelength
		{
			[Token(Token = "0x60001F9")]
			[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "7")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001FA RID: 506 RVA: 0x00002CB8 File Offset: 0x00000EB8
		[Token(Token = "0x1700007A")]
		protected override Color GizmoColor
		{
			[Token(Token = "0x60001FA")]
			[Address(RVA = "0x9FD450", Offset = "0x9FBA50", VA = "0x1809FD450", Slot = "13")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001FB RID: 507 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x1700007B")]
		protected override string ShaderPrefix
		{
			[Token(Token = "0x60001FB")]
			[Address(RVA = "0x9FD470", Offset = "0x9FBA70", VA = "0x1809FD470", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001FC RID: 508 RVA: 0x00002CD0 File Offset: 0x00000ED0
		[Token(Token = "0x1700007C")]
		protected override bool FollowHorizontalMotion
		{
			[Token(Token = "0x60001FC")]
			[Address(RVA = "0x66FB70", Offset = "0x66E170", VA = "0x18066FB70", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001FD")]
		[Address(RVA = "0x9FD4A0", Offset = "0x9FBAA0", VA = "0x1809FD4A0")]
		public RegisterShadowInput()
		{
		}
	}
}
