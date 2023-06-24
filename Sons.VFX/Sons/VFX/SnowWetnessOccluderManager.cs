using System;
using System.Collections.Generic;
using Endnight.Types;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.VFX
{
	// Token: 0x02000025 RID: 37
	[Token(Token = "0x2000025")]
	[AddComponentMenu("Sons/VFX/SnowWetnessOccluderManager")]
	public class SnowWetnessOccluderManager : SingletonBehaviour<SnowWetnessOccluderManager>
	{
		// Token: 0x060000B4 RID: 180 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B4")]
		[Address(RVA = "0x3172B10", Offset = "0x3171110", VA = "0x183172B10", Slot = "7")]
		protected override void PostAwake()
		{
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B5")]
		[Address(RVA = "0x3172BD0", Offset = "0x31711D0", VA = "0x183172BD0", Slot = "9")]
		protected override void PostOnDestroy()
		{
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B6")]
		[Address(RVA = "0x3172C80", Offset = "0x3171280", VA = "0x183172C80")]
		private void SetMaxVolumes(string quality)
		{
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B7")]
		[Address(RVA = "0x3172CE0", Offset = "0x31712E0", VA = "0x183172CE0")]
		private void LateUpdate()
		{
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B8")]
		[Address(RVA = "0x3172CF0", Offset = "0x31712F0", VA = "0x183172CF0")]
		private void DoUpdate()
		{
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000B9")]
		[Address(RVA = "0x3173260", Offset = "0x3171860", VA = "0x183173260")]
		public static void Unregister(SnowWetnessOccluderVolume volume)
		{
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BA")]
		[Address(RVA = "0x3173350", Offset = "0x3171950", VA = "0x183173350")]
		public static void Register(SnowWetnessOccluderVolume volume)
		{
		}

		// Token: 0x060000BB RID: 187 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000BB")]
		[Address(RVA = "0x3173490", Offset = "0x3171A90", VA = "0x183173490")]
		public SnowWetnessOccluderManager()
		{
		}

		// Token: 0x040000DA RID: 218
		[Token(Token = "0x40000DA")]
		[FieldOffset(Offset = "0x28")]
		private List<SnowWetnessOccluderVolume> _volumes;

		// Token: 0x040000DB RID: 219
		[Token(Token = "0x40000DB")]
		[FieldOffset(Offset = "0x0")]
		private static readonly int _Sons_OcclusionVolumeCount;

		// Token: 0x040000DC RID: 220
		[Token(Token = "0x40000DC")]
		[FieldOffset(Offset = "0x4")]
		private static readonly int _Sons_OcclusionVolumeMatrix;

		// Token: 0x040000DD RID: 221
		[Token(Token = "0x40000DD")]
		[FieldOffset(Offset = "0x8")]
		private static readonly int _Sons_OcclusionVolumeSize;

		// Token: 0x040000DE RID: 222
		[Token(Token = "0x40000DE")]
		[FieldOffset(Offset = "0xC")]
		private static readonly int _Sons_OcclusionVolumeStrength;

		// Token: 0x040000DF RID: 223
		[Token(Token = "0x40000DF")]
		[FieldOffset(Offset = "0x10")]
		private static readonly int _Sons_OcclusionSharpnessValues;

		// Token: 0x040000E0 RID: 224
		[Token(Token = "0x40000E0")]
		[FieldOffset(Offset = "0x14")]
		private static readonly int _Sons_OcclusionVolumeType;

		// Token: 0x040000E1 RID: 225
		[Token(Token = "0x40000E1")]
		[FieldOffset(Offset = "0x30")]
		private int maxVolumesOnScreen;

		// Token: 0x040000E2 RID: 226
		[Token(Token = "0x40000E2")]
		[FieldOffset(Offset = "0x38")]
		private Matrix4x4[] _vmatrix;

		// Token: 0x040000E3 RID: 227
		[Token(Token = "0x40000E3")]
		[FieldOffset(Offset = "0x40")]
		private Vector4[] _vsize;

		// Token: 0x040000E4 RID: 228
		[Token(Token = "0x40000E4")]
		[FieldOffset(Offset = "0x48")]
		private float[] _vstrength;

		// Token: 0x040000E5 RID: 229
		[Token(Token = "0x40000E5")]
		[FieldOffset(Offset = "0x50")]
		private float[] _vtype;

		// Token: 0x040000E6 RID: 230
		[Token(Token = "0x40000E6")]
		[FieldOffset(Offset = "0x58")]
		[Range(0f, 10f)]
		[SerializeField]
		private float _snowSharpness;

		// Token: 0x040000E7 RID: 231
		[Token(Token = "0x40000E7")]
		[FieldOffset(Offset = "0x5C")]
		[Range(0f, 10f)]
		[SerializeField]
		private float _wetnessSharpness;

		// Token: 0x040000E8 RID: 232
		[Token(Token = "0x40000E8")]
		[FieldOffset(Offset = "0x60")]
		[Range(0f, 10f)]
		[SerializeField]
		private float _strengthSharpness;
	}
}
