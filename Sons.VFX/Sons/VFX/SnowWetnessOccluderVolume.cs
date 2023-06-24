using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.VFX
{
	// Token: 0x02000026 RID: 38
	[Token(Token = "0x2000026")]
	[AddComponentMenu("Sons/VFX/SnowWetnessOccluderVolume")]
	public class SnowWetnessOccluderVolume : MonoBehaviour
	{
		// Token: 0x060000BD RID: 189 RVA: 0x00002148 File Offset: 0x00000348
		[Token(Token = "0x60000BD")]
		[Address(RVA = "0x31739F0", Offset = "0x3171FF0", VA = "0x1831739F0")]
		public Matrix4x4 GetMatrix()
		{
			return default(Matrix4x4);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00002160 File Offset: 0x00000360
		[Token(Token = "0x60000BE")]
		[Address(RVA = "0x9D9860", Offset = "0x9D7E60", VA = "0x1809D9860")]
		public float GetStrength()
		{
			return 0f;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x00002178 File Offset: 0x00000378
		[Token(Token = "0x60000BF")]
		[Address(RVA = "0x3173AA0", Offset = "0x31720A0", VA = "0x183173AA0")]
		public float GetOccluderType()
		{
			return 0f;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x00002190 File Offset: 0x00000390
		[Token(Token = "0x60000C0")]
		[Address(RVA = "0x29A2980", Offset = "0x29A0F80", VA = "0x1829A2980")]
		public Vector3 GetOccluderSize()
		{
			return default(Vector3);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C1")]
		[Address(RVA = "0x3173AB0", Offset = "0x31720B0", VA = "0x183173AB0")]
		public void SetOccluderSize(Vector3 size)
		{
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C2")]
		[Address(RVA = "0x722560", Offset = "0x720B60", VA = "0x180722560")]
		public void SetOccluderStrength(float strength)
		{
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C3")]
		[Address(RVA = "0x3173DC0", Offset = "0x31723C0", VA = "0x183173DC0")]
		private void OnEnable()
		{
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C4")]
		[Address(RVA = "0x3173FC0", Offset = "0x31725C0", VA = "0x183173FC0")]
		private void OnDisable()
		{
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60000C5")]
		[Address(RVA = "0x31740E0", Offset = "0x31726E0", VA = "0x1831740E0")]
		public SnowWetnessOccluderVolume()
		{
		}

		// Token: 0x040000E9 RID: 233
		[Token(Token = "0x40000E9")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private SnowWetnessOccluderVolume.OccluderType _type;

		// Token: 0x040000EA RID: 234
		[Token(Token = "0x40000EA")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private Vector3 _size;

		// Token: 0x040000EB RID: 235
		[Token(Token = "0x40000EB")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		[Range(0f, 1f)]
		private float _strength;

		// Token: 0x040000EC RID: 236
		[Token(Token = "0x40000EC")]
		[FieldOffset(Offset = "0x34")]
		public bool _enableGizmos;

		// Token: 0x040000ED RID: 237
		[Token(Token = "0x40000ED")]
		[FieldOffset(Offset = "0x38")]
		private Transform _trans;

		// Token: 0x02000027 RID: 39
		[Token(Token = "0x2000027")]
		private enum OccluderType
		{
			// Token: 0x040000EF RID: 239
			[Token(Token = "0x40000EF")]
			Box,
			// Token: 0x040000F0 RID: 240
			[Token(Token = "0x40000F0")]
			Ramp
		}
	}
}
