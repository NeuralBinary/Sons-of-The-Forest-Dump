using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000047 RID: 71
	[Token(Token = "0x2000047")]
	public class RegisterClipSurfaceInput : RegisterLodDataInput<LodDataMgrClipSurface>
	{
		// Token: 0x17000055 RID: 85
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x00002A00 File Offset: 0x00000C00
		[Token(Token = "0x17000055")]
		public override bool Enabled
		{
			[Token(Token = "0x60001A7")]
			[Address(RVA = "0x674880", Offset = "0x672E80", VA = "0x180674880", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x00002A18 File Offset: 0x00000C18
		[Token(Token = "0x17000056")]
		public override float Wavelength
		{
			[Token(Token = "0x60001A8")]
			[Address(RVA = "0x620A90", Offset = "0x61F090", VA = "0x180620A90", Slot = "7")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00002A30 File Offset: 0x00000C30
		[Token(Token = "0x17000057")]
		protected override Color GizmoColor
		{
			[Token(Token = "0x60001A9")]
			[Address(RVA = "0x9EAA60", Offset = "0x9E9060", VA = "0x1809EAA60", Slot = "13")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x060001AA RID: 426 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000058")]
		protected override string ShaderPrefix
		{
			[Token(Token = "0x60001AA")]
			[Address(RVA = "0x9EAA80", Offset = "0x9E9080", VA = "0x1809EAA80", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x060001AB RID: 427 RVA: 0x00002A48 File Offset: 0x00000C48
		[Token(Token = "0x17000059")]
		protected override bool FollowHorizontalMotion
		{
			[Token(Token = "0x60001AB")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001AC RID: 428 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AC")]
		[Address(RVA = "0x9EAAB0", Offset = "0x9E90B0", VA = "0x1809EAAB0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060001AD RID: 429 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001AD")]
		[Address(RVA = "0x9EB130", Offset = "0x9E9730", VA = "0x1809EB130")]
		public RegisterClipSurfaceInput()
		{
		}

		// Token: 0x04000148 RID: 328
		[Token(Token = "0x4000148")]
		[FieldOffset(Offset = "0x40")]
		private bool _enabled;

		// Token: 0x04000149 RID: 329
		[Token(Token = "0x4000149")]
		[FieldOffset(Offset = "0x41")]
		[SerializeField]
		[Tooltip("Prevents inputs from cancelling each other out when aligned vertically. It is imperfect so custom logic might be needed for your use case.")]
		[Header("Convex Hull Options")]
		private bool _disableClipSurfaceWhenTooFarFromSurface;

		// Token: 0x0400014A RID: 330
		[Token(Token = "0x400014A")]
		[FieldOffset(Offset = "0x44")]
		[Tooltip("Large, choppy waves require higher iterations to have accurate holes.")]
		[SerializeField]
		private uint _animatedWavesDisplacementSamplingIterations;

		// Token: 0x0400014B RID: 331
		[Token(Token = "0x400014B")]
		[FieldOffset(Offset = "0x48")]
		private PropertyWrapperMPB _mpb;

		// Token: 0x0400014C RID: 332
		[Token(Token = "0x400014C")]
		[FieldOffset(Offset = "0x50")]
		private SampleHeightHelper _sampleHeightHelper;

		// Token: 0x0400014D RID: 333
		[Token(Token = "0x400014D")]
		[FieldOffset(Offset = "0x0")]
		private static int sp_DisplacementSamplingIterations;
	}
}
