using System;
using Il2CppDummyDll;
using UdpKit;
using UnityEngine;

namespace Bolt
{
	// Token: 0x020000D2 RID: 210
	[Token(Token = "0x20000D2")]
	internal struct PropertyQuaternionCompression
	{
		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600066C RID: 1644 RVA: 0x000041D0 File Offset: 0x000023D0
		[Token(Token = "0x17000125")]
		public int BitsRequired
		{
			[Token(Token = "0x600066C")]
			[Address(RVA = "0x8FE430", Offset = "0x8FCA30", VA = "0x1808FE430")]
			get
			{
				return 0;
			}
		}

		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x000041E8 File Offset: 0x000023E8
		[Token(Token = "0x17000126")]
		public bool StrictComparison
		{
			[Token(Token = "0x600066D")]
			[Address(RVA = "0x8FE450", Offset = "0x8FCA50", VA = "0x1808FE450")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x00004200 File Offset: 0x00002400
		[Token(Token = "0x600066E")]
		[Address(RVA = "0x8FE460", Offset = "0x8FCA60", VA = "0x1808FE460")]
		public static PropertyQuaternionCompression Create(PropertyVectorCompressionSettings euler)
		{
			return default(PropertyQuaternionCompression);
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00004218 File Offset: 0x00002418
		[Token(Token = "0x600066F")]
		[Address(RVA = "0x8FE4A0", Offset = "0x8FCAA0", VA = "0x1808FE4A0")]
		public static PropertyQuaternionCompression Create(PropertyFloatCompressionSettings quaternion)
		{
			return default(PropertyQuaternionCompression);
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00004230 File Offset: 0x00002430
		[Token(Token = "0x6000670")]
		[Address(RVA = "0x8FE510", Offset = "0x8FCB10", VA = "0x1808FE510")]
		public static PropertyQuaternionCompression Create(PropertyFloatCompressionSettings quaternion, bool strict)
		{
			return default(PropertyQuaternionCompression);
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000671")]
		[Address(RVA = "0x8FE550", Offset = "0x8FCB50", VA = "0x1808FE550")]
		public void Pack(UdpPacket stream, Quaternion value)
		{
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00004248 File Offset: 0x00002448
		[Token(Token = "0x6000672")]
		[Address(RVA = "0x8FE6E0", Offset = "0x8FCCE0", VA = "0x1808FE6E0")]
		public Quaternion Read(UdpPacket stream)
		{
			return default(Quaternion);
		}

		// Token: 0x040002EC RID: 748
		[Token(Token = "0x40002EC")]
		[FieldOffset(Offset = "0x0")]
		private bool QuaternionMode;

		// Token: 0x040002ED RID: 749
		[Token(Token = "0x40002ED")]
		[FieldOffset(Offset = "0x1")]
		private bool QuaternionStrictComparison;

		// Token: 0x040002EE RID: 750
		[Token(Token = "0x40002EE")]
		[FieldOffset(Offset = "0x4")]
		public PropertyVectorCompressionSettings Euler;

		// Token: 0x040002EF RID: 751
		[Token(Token = "0x40002EF")]
		[FieldOffset(Offset = "0x38")]
		public PropertyFloatCompressionSettings Quaternion;
	}
}
