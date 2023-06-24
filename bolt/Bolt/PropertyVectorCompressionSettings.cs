using System;
using Il2CppDummyDll;
using UdpKit;
using UnityEngine;

namespace Bolt
{
	// Token: 0x020000D5 RID: 213
	[Token(Token = "0x20000D5")]
	internal struct PropertyVectorCompressionSettings
	{
		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06000674 RID: 1652 RVA: 0x00004278 File Offset: 0x00002478
		[Token(Token = "0x17000127")]
		public int BitsRequired
		{
			[Token(Token = "0x6000674")]
			[Address(RVA = "0x8FE880", Offset = "0x8FCE80", VA = "0x1808FE880")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00004290 File Offset: 0x00002490
		[Token(Token = "0x6000675")]
		[Address(RVA = "0x8FE890", Offset = "0x8FCE90", VA = "0x1808FE890")]
		public static PropertyVectorCompressionSettings Create(PropertyFloatCompressionSettings x, PropertyFloatCompressionSettings y, PropertyFloatCompressionSettings z)
		{
			return default(PropertyVectorCompressionSettings);
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x000042A8 File Offset: 0x000024A8
		[Token(Token = "0x6000676")]
		[Address(RVA = "0x8FE8F0", Offset = "0x8FCEF0", VA = "0x1808FE8F0")]
		public static PropertyVectorCompressionSettings Create(PropertyFloatCompressionSettings x, PropertyFloatCompressionSettings y, PropertyFloatCompressionSettings z, bool strict)
		{
			return default(PropertyVectorCompressionSettings);
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6000677")]
		[Address(RVA = "0x8FE920", Offset = "0x8FCF20", VA = "0x1808FE920")]
		public void Pack(UdpPacket stream, Vector3 value)
		{
		}

		// Token: 0x06000678 RID: 1656 RVA: 0x000042C0 File Offset: 0x000024C0
		[Token(Token = "0x6000678")]
		[Address(RVA = "0x8FEA20", Offset = "0x8FD020", VA = "0x1808FEA20")]
		public Vector3 Read(UdpPacket stream)
		{
			return default(Vector3);
		}

		// Token: 0x040002F4 RID: 756
		[Token(Token = "0x40002F4")]
		[FieldOffset(Offset = "0x0")]
		public bool StrictComparison;

		// Token: 0x040002F5 RID: 757
		[Token(Token = "0x40002F5")]
		[FieldOffset(Offset = "0x4")]
		public PropertyFloatCompressionSettings X;

		// Token: 0x040002F6 RID: 758
		[Token(Token = "0x40002F6")]
		[FieldOffset(Offset = "0x14")]
		public PropertyFloatCompressionSettings Y;

		// Token: 0x040002F7 RID: 759
		[Token(Token = "0x40002F7")]
		[FieldOffset(Offset = "0x24")]
		public PropertyFloatCompressionSettings Z;
	}
}
