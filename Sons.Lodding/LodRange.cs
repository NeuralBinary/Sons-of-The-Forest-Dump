using System;
using Il2CppDummyDll;
using UnityEngine;

namespace Sons.Lodding
{
	// Token: 0x0200000C RID: 12
	[Token(Token = "0x200000C")]
	[Serializable]
	public class LodRange
	{
		// Token: 0x06000064 RID: 100 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000064")]
		[Address(RVA = "0x30C2020", Offset = "0x30C0620", VA = "0x1830C2020")]
		private void UpdateLod02Overrides()
		{
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000065")]
		[Address(RVA = "0x30C2060", Offset = "0x30C0660", VA = "0x1830C2060")]
		public LodRange(float[] baseRanges)
		{
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000066 RID: 102 RVA: 0x00002238 File Offset: 0x00000438
		[Token(Token = "0x17000007")]
		private bool ShowLod02EndQuality
		{
			[Token(Token = "0x6000066")]
			[Address(RVA = "0x30C20E0", Offset = "0x30C06E0", VA = "0x1830C20E0")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000067 RID: 103 RVA: 0x00002250 File Offset: 0x00000450
		[Token(Token = "0x17000008")]
		public bool EnableLod01
		{
			[Token(Token = "0x6000067")]
			[Address(RVA = "0x5FD560", Offset = "0x5FBB60", VA = "0x1805FD560")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00002268 File Offset: 0x00000468
		[Token(Token = "0x17000009")]
		public bool EnableLod02
		{
			[Token(Token = "0x6000068")]
			[Address(RVA = "0x150B770", Offset = "0x1509D70", VA = "0x18150B770")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000069 RID: 105 RVA: 0x00002280 File Offset: 0x00000480
		[Token(Token = "0x1700000A")]
		public float Lod00End
		{
			[Token(Token = "0x6000069")]
			[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600006A RID: 106 RVA: 0x00002298 File Offset: 0x00000498
		[Token(Token = "0x1700000B")]
		public float Lod01End
		{
			[Token(Token = "0x600006A")]
			[Address(RVA = "0x9FA1C0", Offset = "0x9F87C0", VA = "0x1809FA1C0")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600006B RID: 107 RVA: 0x000022B0 File Offset: 0x000004B0
		[Token(Token = "0x1700000C")]
		public float Lod02End
		{
			[Token(Token = "0x600006B")]
			[Address(RVA = "0x5EA820", Offset = "0x5E8E20", VA = "0x1805EA820")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x000022C8 File Offset: 0x000004C8
		[Token(Token = "0x600006C")]
		[Address(RVA = "0x30C20F0", Offset = "0x30C06F0", VA = "0x1830C20F0")]
		public int GetLodIndex(float dist, float occlusionScale, int qualityOverride = -1)
		{
			return 0;
		}

		// Token: 0x0600006D RID: 109 RVA: 0x000022E0 File Offset: 0x000004E0
		[Token(Token = "0x600006D")]
		[Address(RVA = "0x9FA1C0", Offset = "0x9F87C0", VA = "0x1809FA1C0")]
		public float CalculateLod01EndRange(float occlusionScale)
		{
			return 0f;
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000022F8 File Offset: 0x000004F8
		[Token(Token = "0x600006E")]
		[Address(RVA = "0xA308D0", Offset = "0xA2EED0", VA = "0x180A308D0")]
		public float CalculateLod00EndRange()
		{
			return 0f;
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002310 File Offset: 0x00000510
		[Token(Token = "0x600006F")]
		[Address(RVA = "0x30C2170", Offset = "0x30C0770", VA = "0x1830C2170")]
		public float CalculateLod02EndRange(float occlusionScale, int qualityOverride)
		{
			return 0f;
		}

		// Token: 0x04000072 RID: 114
		[Token(Token = "0x4000072")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private float _lod00End;

		// Token: 0x04000073 RID: 115
		[Token(Token = "0x4000073")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private bool _enableLod01;

		// Token: 0x04000074 RID: 116
		[Token(Token = "0x4000074")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private float _lod01End;

		// Token: 0x04000075 RID: 117
		[Token(Token = "0x4000075")]
		[FieldOffset(Offset = "0x1C")]
		[SerializeField]
		private bool _enableLod02;

		// Token: 0x04000076 RID: 118
		[Token(Token = "0x4000076")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		private float _lod02End;

		// Token: 0x04000077 RID: 119
		[Token(Token = "0x4000077")]
		[FieldOffset(Offset = "0x24")]
		[SerializeField]
		private bool _setLod02EndQuality;

		// Token: 0x04000078 RID: 120
		[Token(Token = "0x4000078")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		private float _lod2EndHigh;

		// Token: 0x04000079 RID: 121
		[Token(Token = "0x4000079")]
		[FieldOffset(Offset = "0x2C")]
		[SerializeField]
		private float _lod2EndMedium;

		// Token: 0x0400007A RID: 122
		[Token(Token = "0x400007A")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		private float _lod2EndLow;

		// Token: 0x0400007B RID: 123
		[Token(Token = "0x400007B")]
		[FieldOffset(Offset = "0x34")]
		[SerializeField]
		private float _lod2EndUltraLow;
	}
}
