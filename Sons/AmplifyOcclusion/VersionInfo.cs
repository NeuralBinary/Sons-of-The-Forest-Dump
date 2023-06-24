using System;
using Il2CppDummyDll;
using UnityEngine;

namespace AmplifyOcclusion
{
	// Token: 0x020004C8 RID: 1224
	[Token(Token = "0x20004C8")]
	[Serializable]
	public class VersionInfo
	{
		// Token: 0x06002000 RID: 8192 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002000")]
		[Address(RVA = "0x330EC30", Offset = "0x330D230", VA = "0x18330EC30")]
		public static string StaticToString()
		{
			return null;
		}

		// Token: 0x06002001 RID: 8193 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002001")]
		[Address(RVA = "0x330EF30", Offset = "0x330D530", VA = "0x18330EF30", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		// Token: 0x1700047B RID: 1147
		// (get) Token: 0x06002002 RID: 8194 RVA: 0x00009540 File Offset: 0x00007740
		[Token(Token = "0x1700047B")]
		public int Number
		{
			[Token(Token = "0x6002002")]
			[Address(RVA = "0x330F1A0", Offset = "0x330D7A0", VA = "0x18330F1A0")]
			get
			{
				return 0;
			}
		}

		// Token: 0x06002003 RID: 8195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002003")]
		[Address(RVA = "0x330F1C0", Offset = "0x330D7C0", VA = "0x18330F1C0")]
		private VersionInfo()
		{
		}

		// Token: 0x06002004 RID: 8196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6002004")]
		[Address(RVA = "0x330F1D0", Offset = "0x330D7D0", VA = "0x18330F1D0")]
		private VersionInfo(byte major, byte minor, byte release)
		{
		}

		// Token: 0x06002005 RID: 8197 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6002005")]
		[Address(RVA = "0x330F1F0", Offset = "0x330D7F0", VA = "0x18330F1F0")]
		public static VersionInfo Current()
		{
			return null;
		}

		// Token: 0x06002006 RID: 8198 RVA: 0x00009558 File Offset: 0x00007758
		[Token(Token = "0x6002006")]
		[Address(RVA = "0x330F230", Offset = "0x330D830", VA = "0x18330F230")]
		public static bool Matches(VersionInfo version)
		{
			return default(bool);
		}

		// Token: 0x04001D67 RID: 7527
		[Token(Token = "0x4001D67")]
		public const byte Major = 2;

		// Token: 0x04001D68 RID: 7528
		[Token(Token = "0x4001D68")]
		public const byte Minor = 0;

		// Token: 0x04001D69 RID: 7529
		[Token(Token = "0x4001D69")]
		public const byte Release = 3;

		// Token: 0x04001D6A RID: 7530
		[Token(Token = "0x4001D6A")]
		public const byte Revision = 0;

		// Token: 0x04001D6B RID: 7531
		[Token(Token = "0x4001D6B")]
		[FieldOffset(Offset = "0x10")]
		[SerializeField]
		private int m_major;

		// Token: 0x04001D6C RID: 7532
		[Token(Token = "0x4001D6C")]
		[FieldOffset(Offset = "0x14")]
		[SerializeField]
		private int m_minor;

		// Token: 0x04001D6D RID: 7533
		[Token(Token = "0x4001D6D")]
		[FieldOffset(Offset = "0x18")]
		[SerializeField]
		private int m_release;
	}
}
