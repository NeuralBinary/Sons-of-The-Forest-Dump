using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Crest
{
	// Token: 0x02000046 RID: 70
	[Token(Token = "0x2000046")]
	[ExecuteAlways]
	public class RegisterAnimWavesInput : RegisterLodDataInput<LodDataMgrAnimWaves>
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600019F RID: 415 RVA: 0x000029A0 File Offset: 0x00000BA0
		[Token(Token = "0x17000050")]
		public override bool Enabled
		{
			[Token(Token = "0x600019F")]
			[Address(RVA = "0x5EF590", Offset = "0x5EDB90", VA = "0x1805EF590", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x000029B8 File Offset: 0x00000BB8
		[Token(Token = "0x17000051")]
		public override float Wavelength
		{
			[Token(Token = "0x60001A0")]
			[Address(RVA = "0x781570", Offset = "0x77FB70", VA = "0x180781570", Slot = "7")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x060001A1 RID: 417 RVA: 0x000029D0 File Offset: 0x00000BD0
		[Token(Token = "0x17000052")]
		protected override Color GizmoColor
		{
			[Token(Token = "0x60001A1")]
			[Address(RVA = "0x9EA610", Offset = "0x9E8C10", VA = "0x1809EA610", Slot = "13")]
			get
			{
				return default(Color);
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x000020E2 File Offset: 0x000002E2
		[Token(Token = "0x17000053")]
		protected override string ShaderPrefix
		{
			[Token(Token = "0x60001A2")]
			[Address(RVA = "0x9EA670", Offset = "0x9E8C70", VA = "0x1809EA670", Slot = "10")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x000029E8 File Offset: 0x00000BE8
		[Token(Token = "0x17000054")]
		protected override bool FollowHorizontalMotion
		{
			[Token(Token = "0x60001A3")]
			[Address(RVA = "0x9EA6A0", Offset = "0x9E8CA0", VA = "0x1809EA6A0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A4")]
		[Address(RVA = "0x9EA6B0", Offset = "0x9E8CB0", VA = "0x1809EA6B0", Slot = "11")]
		protected override void Update()
		{
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60001A5")]
		[Address(RVA = "0x9EA9E0", Offset = "0x9E8FE0", VA = "0x1809EA9E0")]
		public RegisterAnimWavesInput()
		{
		}

		// Token: 0x04000142 RID: 322
		[Token(Token = "0x4000142")]
		[FieldOffset(Offset = "0x40")]
		[SerializeField]
		[Tooltip("Which octave to render into, for example set this to 2 to use render into the 2m-4m octave. These refer to the same octaves as the wave spectrum editor. Set this value to 0 to render into all LODs.")]
		private float _octaveWavelength;

		// Token: 0x04000143 RID: 323
		[Token(Token = "0x4000143")]
		[FieldOffset(Offset = "0x0")]
		public static readonly Color s_gizmoColor;

		// Token: 0x04000144 RID: 324
		[Token(Token = "0x4000144")]
		[FieldOffset(Offset = "0x44")]
		[SerializeField]
		[Tooltip("Whether this input data should displace horizontally with waves. If false, data will not move from side to side with the waves. Adds a small performance overhead when disabled.")]
		private bool _followHorizontalMotion;

		// Token: 0x04000145 RID: 325
		[Token(Token = "0x4000145")]
		[FieldOffset(Offset = "0x48")]
		[SerializeField]
		[Tooltip("Inform ocean how much this input will displace the ocean surface vertically. This is used to set bounding box heights for the ocean tiles.")]
		private float _maxDisplacementVertical;

		// Token: 0x04000146 RID: 326
		[Token(Token = "0x4000146")]
		[FieldOffset(Offset = "0x4C")]
		[Tooltip("Inform ocean how much this input will displace the ocean surface horizontally. This is used to set bounding box widths for the ocean tiles.")]
		[SerializeField]
		private float _maxDisplacementHorizontal;

		// Token: 0x04000147 RID: 327
		[Token(Token = "0x4000147")]
		[FieldOffset(Offset = "0x50")]
		[Tooltip("Use the bounding box of an attached renderer component to determine the max vertical displacement.")]
		[SerializeField]
		private bool _reportRendererBoundsToOceanSystem;
	}
}
